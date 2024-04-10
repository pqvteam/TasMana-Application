using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Repositories.Entities;
using Repositories.Utilities;
using Services;

namespace UIs
{
    public partial class C_AccountManagement : Form
    {
        NhanSuService nhanSuService = new NhanSuService();
        NhanVienService nhanVienService = new NhanVienService();
        CeoService ceoService = new CeoService();
        QuanLyService quanLyService = new QuanLyService();
        PhongBanService phongBanService = new PhongBanService();

        public C_AccountManagement()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e) { }

        private void C_AccountManagement_Load(object sender, EventArgs e)
        {
            Session.Instance.UserName = "GD-101";
            if (!(Session.Instance.UserName.Contains("GD") || Session.Instance.laQuanLi))
            {
                customButton19.Enabled = false;
            }
            membersGrid.Columns.Add("ID", "ID");
            membersGrid.Columns.Add("Name", "Name");
            membersGrid.Columns.Add("Birthday", "Birthday");
            membersGrid.Columns.Add("Type Account", "Type Account");
            membersGrid.Columns.Add("Department", "Department");
            membersGrid.Columns.Add("Role", "Role");
            membersGrid.Columns.Add("Startdate", "Start Date");

            DataGridViewCheckBoxColumn btnManagerColumn = new DataGridViewCheckBoxColumn();
            btnManagerColumn.HeaderText = "Manager";
            btnManagerColumn.Name = "btnAppoint";
            membersGrid.Columns.Add(btnManagerColumn);
            DataGridViewCheckBoxColumn btnLeaderColumn = new DataGridViewCheckBoxColumn();
            btnLeaderColumn.HeaderText = "Leader";
            btnLeaderColumn.Name = "btnLeader";
            membersGrid.Columns.Add(btnLeaderColumn);

            DataGridViewCheckBoxColumn firedColumn = new DataGridViewCheckBoxColumn();
            firedColumn.HeaderText = "Fired";
            firedColumn.Name = "Fired";
            firedColumn.ReadOnly = true;
            membersGrid.Columns.Add(firedColumn);
            List<PhongBan> departments = phongBanService.getAllDepartment();
            departmentsBox.Items.Clear();
            foreach (PhongBan department in departments)
            {
                departmentsBox.Items.Add(department.MaPb);
            }
            departmentsBox.Items.Add("All");
            reload();
        }

        private void reload()
        {
            DatabaseConnection.Instance.OpenConnection();
            List<NhanSu> members = nhanSuService.getAllMembers();
            membersGrid.Rows.Clear();

            foreach (var member in members)
            {
                string memberType = "";
                string role = "Staff";
                if (ceoService.getCeo(member.MaThanhVien) != null)
                {
                    role = "CEO";
                    memberType = "CEO";
                }
                else if (quanLyService.findManager(member.MaThanhVien) != null)
                {
                    role = "Manager";
                    memberType = "Manager";
                }
                else
                {
                    memberType = member.LoaiNhanSu;
                }
                string departmentID = member.MaThanhVien.Split("-")[0];
                DateOnly dateOnly = member.NgayBatDau.Value;
                string start = dateOnly.ToString("dd/MM/yyyy");

                int rowIndex = membersGrid.Rows.Add(
                    member.MaThanhVien,
                    member.HoVaTen,
                    member.NamSinh.ToString("dd/MM/yyyy"),
                    memberType,
                    departmentID,
                    role,
                    start
                );

                if (role == "Manager")
                {
                    membersGrid.Rows[rowIndex].Cells["btnAppoint"].Value = true;
                    membersGrid.Rows[rowIndex].Cells["btnLeader"].ReadOnly = true;
                }

                if (role == "CEO")
                {
                    membersGrid.Rows[rowIndex].Cells["btnAppoint"].ReadOnly = true;
                    membersGrid.Rows[rowIndex].Cells["btnLeader"].ReadOnly = true;
                }

                if (nhanVienService.checkLeader(member.MaThanhVien))
                {
                    membersGrid.Rows[rowIndex].Cells["btnLeader"].Value = true;
                }

                membersGrid.Rows[rowIndex].Cells["Fired"].Value = member.NghiViec;
            }

            
        }

        public void ReloadDataGrid()
        {
            // Thực hiện lại việc tải dữ liệu cho grid
            reload();
        }

        private void customPanel1_Paint(object sender, PaintEventArgs e) { }

        private void membersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string? memberId = membersGrid.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            bool isManager =
                membersGrid.Rows[e.RowIndex].Cells["btnAppoint"].Value != null
                    ? (bool)membersGrid.Rows[e.RowIndex].Cells["btnAppoint"].Value
                    : false;
            string CEOID = "GD-001";
            if (e.ColumnIndex == membersGrid.Columns["btnAppoint"].Index && e.RowIndex >= 0)
            {
                if (memberId != null)
                {
                    if (isManager)
                    {
                        string confirmMessage = "ARE YOU SURE TO DEPOSE THIS MANAGER?";
                        A_Confirm confirmForm = new A_Confirm(confirmMessage, "danger");
                        confirmForm.ConfirmClicked += (confirmSender, confirmArgs) =>
                        {
                            bool isSuccess = ceoService.deposeManager(memberId, CEOID);
                            if (isSuccess)
                            {
                                MessageBox.Show("Depose manager successfully");
                                PerformSearch();
                            }
                            else
                            {
                                MessageBox.Show("Depose manager failure");
                            }
                        };
                        confirmForm.ShowDialog();
                    }
                    else
                    {
                        string confirmMessage = "ARE YOU SURE TO APPOINT THIS MANAGER?";
                        A_Confirm confirmForm = new A_Confirm(confirmMessage, "confirm");
                        confirmForm.ConfirmClicked += (confirmSender, confirmArgs) =>
                        {
                            bool isSuccess = ceoService.appointManager(memberId, CEOID);
                            if (isSuccess)
                            {
                                MessageBox.Show("Appoint manager successfully");
                                PerformSearch();
                            }
                            else
                            {
                                MessageBox.Show("Appoint manager failure");
                            }
                        };
                        confirmForm.ShowDialog();
                    }
                }
            }
            else if (e.ColumnIndex == membersGrid.Columns["btnLeader"].Index && e.RowIndex >= 0)
            {
                A_Appoint appointForm = new A_Appoint(memberId, CEOID);
                appointForm.ShowDialog();
                PerformSearch();
            }
            reload();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string keySearch = searchBox.Text;
            try
            {
                DatabaseConnection.Instance.OpenConnection();

                SqlConnection conn = DatabaseConnection.Instance.GetConnection();

                membersGrid.Rows.Clear();
                using (
                    SqlCommand command = new SqlCommand(
                        "SELECT * FROM dbo.timKiemNhanSu(@noidung)",
                        conn
                    )
                )
                {
                    command.Parameters.AddWithValue("@noidung", keySearch);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string ID = reader.GetString(reader.GetOrdinal("maThanhVien"));
                                string name = reader.GetString(reader.GetOrdinal("hoVaTen"));
                                string memberType = "";
                                if (!reader.IsDBNull(reader.GetOrdinal("loaiNhanSu")))
                                {
                                    memberType = reader.GetString(reader.GetOrdinal("loaiNhanSu"));
                                    // Thực hiện các thao tác khác với giá trị của cột "loaiNhanSu"
                                }
                                string birthday = reader
                                    .GetDateTime("namSinh")
                                    .ToString("dd/MM/yyyy");
                                string start = reader
                                    .GetDateTime("ngayBatDau")
                                    .ToString("dd/MM/yyyy");
                                bool fired = reader.GetBoolean("nghiViec");
                                string departmentID = ID.Split('-')[0];
                                string role = "Staff";
                                string selectedDepartment =
                                    departmentsBox.SelectedItem != null
                                        ? departmentsBox.SelectedItem.ToString()
                                        : "";
                                string selectedType =
                                    typeAccountBox.SelectedItem != null
                                        ? typeAccountBox.SelectedItem.ToString()
                                        : "";
                                if (ceoService.getCeo(ID) != null)
                                {
                                    role = "CEO";
                                    memberType = "CEO";
                                }
                                else if (quanLyService.findManager(ID) != null)
                                {
                                    role = "Manager";
                                    memberType = "Manager";
                                }

                                if (
                                    (selectedDepartment == "" || selectedDepartment == "All")
                                    && (selectedType == "All" || selectedType == "")
                                )
                                {
                                    int rowIndex = membersGrid.Rows.Add(
                                        ID,
                                        name,
                                        birthday,
                                        memberType,
                                        departmentID,
                                        role,
                                        start
                                    );

                                    membersGrid.Rows[rowIndex].Cells["Fired"].Value = fired;

                                    if (role == "Manager")
                                    {
                                        membersGrid.Rows[rowIndex].Cells["btnAppoint"].Value = true;
                                    }

                                    if (role == "CEO")
                                    {
                                        membersGrid.Rows[rowIndex].Cells["btnAppoint"].ReadOnly =
                                            true;
                                    }
                                }
                                else if (
                                    (selectedDepartment == "" || selectedDepartment == "All")
                                    && (selectedType != "All" || selectedType != "")
                                )
                                {
                                    if (selectedType == "CEO")
                                    {
                                        if (ceoService.getCeo(ID) != null)
                                        {
                                            int rowIndex = membersGrid.Rows.Add(
                                                ID,
                                                name,
                                                birthday,
                                                selectedType,
                                                departmentID,
                                                selectedType,
                                                start
                                            );

                                            membersGrid.Rows[rowIndex].Cells["Fired"].Value = fired;

                                            if (role == "Manager")
                                            {
                                                membersGrid
                                                    .Rows[rowIndex]
                                                    .Cells["btnAppoint"]
                                                    .Value = true;
                                            }

                                            if (role == "CEO")
                                            {
                                                membersGrid
                                                    .Rows[rowIndex]
                                                    .Cells["btnAppoint"]
                                                    .ReadOnly = true;
                                            }
                                        }
                                    }
                                    else if (selectedType == "Manager")
                                    {
                                        if (quanLyService.findManager(ID) != null)
                                        {
                                            int rowIndex = membersGrid.Rows.Add(
                                                ID,
                                                name,
                                                birthday,
                                                selectedType,
                                                departmentID,
                                                selectedType,
                                                start
                                            );

                                            membersGrid.Rows[rowIndex].Cells["Fired"].Value = fired;

                                            if (role == "Manager")
                                            {
                                                membersGrid
                                                    .Rows[rowIndex]
                                                    .Cells["btnAppoint"]
                                                    .Value = true;
                                            }

                                            if (role == "CEO")
                                            {
                                                membersGrid
                                                    .Rows[rowIndex]
                                                    .Cells["btnAppoint"]
                                                    .ReadOnly = true;
                                            }
                                        }
                                    }
                                    else if (selectedType == "Staff")
                                    {
                                        if (
                                            quanLyService.findManager(ID) == null
                                            && ceoService.getCeo(ID) == null
                                        )
                                        {
                                            int rowIndex = membersGrid.Rows.Add(
                                                ID,
                                                name,
                                                birthday,
                                                memberType,
                                                departmentID,
                                                selectedType,
                                                start
                                            );

                                            membersGrid.Rows[rowIndex].Cells["Fired"].Value = fired;

                                            if (role == "Manager")
                                            {
                                                membersGrid
                                                    .Rows[rowIndex]
                                                    .Cells["btnAppoint"]
                                                    .Value = true;
                                            }

                                            if (role == "CEO")
                                            {
                                                membersGrid
                                                    .Rows[rowIndex]
                                                    .Cells["btnAppoint"]
                                                    .ReadOnly = true;
                                            }
                                        }
                                    }
                                }
                                else if (
                                    (selectedDepartment != "" || selectedDepartment != "All")
                                    && (selectedType == "All" || selectedType == "")
                                )
                                {
                                    if (ID.Contains(selectedDepartment))
                                    {
                                        int rowIndex = membersGrid.Rows.Add(
                                            ID,
                                            name,
                                            birthday,
                                            memberType,
                                            departmentID,
                                            role,
                                            start
                                        );

                                        membersGrid.Rows[rowIndex].Cells["Fired"].Value = fired;

                                        if (role == "Manager")
                                        {
                                            membersGrid.Rows[rowIndex].Cells["btnAppoint"].Value =
                                                true;
                                        }

                                        if (role == "CEO")
                                        {
                                            membersGrid
                                                .Rows[rowIndex]
                                                .Cells["btnAppoint"]
                                                .ReadOnly = true;
                                        }
                                    }
                                }
                                else if (
                                    (selectedDepartment != "" || selectedDepartment != "All")
                                    && (selectedType != "All" || selectedType != "")
                                )
                                {
                                    if (ID.Contains(selectedDepartment))
                                    {
                                        if (selectedType == "CEO")
                                        {
                                            if (ceoService.getCeo(ID) != null)
                                            {
                                                int rowIndex = membersGrid.Rows.Add(
                                                    ID,
                                                    name,
                                                    birthday,
                                                    selectedType,
                                                    departmentID,
                                                    selectedType,
                                                    start
                                                );

                                                membersGrid.Rows[rowIndex].Cells["Fired"].Value =
                                                    fired;

                                                if (role == "Manager")
                                                {
                                                    membersGrid
                                                        .Rows[rowIndex]
                                                        .Cells["btnAppoint"]
                                                        .Value = true;
                                                }

                                                if (role == "CEO")
                                                {
                                                    membersGrid
                                                        .Rows[rowIndex]
                                                        .Cells["btnAppoint"]
                                                        .ReadOnly = true;
                                                }
                                            }
                                        }
                                        else if (selectedType == "Manager")
                                        {
                                            if (quanLyService.findManager(ID) != null)
                                            {
                                                int rowIndex = membersGrid.Rows.Add(
                                                    ID,
                                                    name,
                                                    birthday,
                                                    selectedType,
                                                    departmentID,
                                                    selectedType,
                                                    start
                                                );

                                                membersGrid.Rows[rowIndex].Cells["Fired"].Value =
                                                    fired;

                                                if (role == "Manager")
                                                {
                                                    membersGrid
                                                        .Rows[rowIndex]
                                                        .Cells["btnAppoint"]
                                                        .Value = true;
                                                }

                                                if (role == "CEO")
                                                {
                                                    membersGrid
                                                        .Rows[rowIndex]
                                                        .Cells["btnAppoint"]
                                                        .ReadOnly = true;
                                                }
                                            }
                                        }
                                        else if (selectedType == "Staff")
                                        {
                                            if (
                                                quanLyService.findManager(ID) == null
                                                && ceoService.getCeo(ID) == null
                                            )
                                            {
                                                int rowIndex = membersGrid.Rows.Add(
                                                    ID,
                                                    name,
                                                    birthday,
                                                    memberType,
                                                    departmentID,
                                                    selectedType,
                                                    start
                                                );

                                                membersGrid.Rows[rowIndex].Cells["Fired"].Value =
                                                    fired;

                                                if (role == "Manager")
                                                {
                                                    membersGrid
                                                        .Rows[rowIndex]
                                                        .Cells["btnAppoint"]
                                                        .Value = true;
                                                }

                                                if (role == "CEO")
                                                {
                                                    membersGrid
                                                        .Rows[rowIndex]
                                                        .Cells["btnAppoint"]
                                                        .ReadOnly = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy kết quả nào.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DatabaseConnection.Instance.CloseConnection();
            }
        }

        private void departmentsBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void typeAccountBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void PerformSearch()
        {
            string keySearch = searchBox.Text;
            string selectedDepartment =
                departmentsBox.SelectedItem != null ? departmentsBox.SelectedItem.ToString() : "";
            string selectedType =
                typeAccountBox.SelectedItem != null ? typeAccountBox.SelectedItem.ToString() : "";

            try
            {
                DatabaseConnection.Instance.OpenConnection();

                SqlConnection conn = DatabaseConnection.Instance.GetConnection();

                membersGrid.Rows.Clear();
                using (
                    SqlCommand command = new SqlCommand(
                        "SELECT * FROM dbo.timKiemNhanSu(@noidung)",
                        conn
                    )
                )
                {
                    command.Parameters.AddWithValue("@noidung", keySearch);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string ID = reader.GetString(reader.GetOrdinal("maThanhVien"));
                                string name = reader.GetString(reader.GetOrdinal("hoVaTen"));
                                string memberType = "";
                                if (!reader.IsDBNull(reader.GetOrdinal("loaiNhanSu")))
                                {
                                    memberType = reader.GetString(reader.GetOrdinal("loaiNhanSu"));
                                    // Thực hiện các thao tác khác với giá trị của cột "loaiNhanSu"
                                }
                                string birthday = reader
                                    .GetDateTime("namSinh")
                                    .ToString("dd/MM/yyyy");
                                string start = reader
                                    .GetDateTime("ngayBatDau")
                                    .ToString("dd/MM/yyyy");
                                bool fired = reader.GetBoolean("nghiViec");
                                string departmentID = ID.Split('-')[0];
                                string role = "Staff";

                                if (ceoService.getCeo(ID) != null)
                                {
                                    role = "CEO";
                                    memberType = "CEO";
                                }
                                else if (quanLyService.findManager(ID) != null)
                                {
                                    role = "Manager";
                                    memberType = "Manager";
                                }

                                bool isValidDepartment =
                                    string.IsNullOrEmpty(selectedDepartment)
                                    || selectedDepartment == "All"
                                    || departmentID == selectedDepartment;
                                bool isValidType =
                                    string.IsNullOrEmpty(selectedType)
                                    || selectedType == "All"
                                    || role == selectedType;

                                if (isValidDepartment && isValidType)
                                {
                                    int rowIndex = membersGrid.Rows.Add(
                                        ID,
                                        name,
                                        birthday,
                                        memberType,
                                        departmentID,
                                        role,
                                        start
                                    );

                                    membersGrid.Rows[rowIndex].Cells["Fired"].Value = fired;

                                    if (role == "Manager")
                                    {
                                        membersGrid.Rows[rowIndex].Cells["btnAppoint"].Value = true;
                                    }

                                    if (role == "CEO")
                                    {
                                        membersGrid.Rows[rowIndex].Cells["btnAppoint"].ReadOnly =
                                            true;
                                    }

                                    if (nhanVienService.checkLeader(ID))
                                    {
                                        membersGrid.Rows[rowIndex].Cells["btnLeader"].Value = true;
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy kết quả nào.");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                string logFilePath = "error.log"; // Đường dẫn tới tệp tin log, bạn có thể thay đổi đường dẫn này
                using (StreamWriter writer = new StreamWriter(logFilePath, true))
                {
                    writer.WriteLine($"Error occurred at {DateTime.Now}: {e.Message}");
                    writer.WriteLine($"Stack trace: {e.StackTrace}");
                    writer.WriteLine("----------------------------------------------");
                }
                MessageBox.Show(e.Message);
            }
            finally
            {
                DatabaseConnection.Instance.CloseConnection();
            }
        }

        private void customButton19_Click(object sender, EventArgs e)
        {
            CM_CreateAccount frm = new CM_CreateAccount();
            frm.ShowDialog();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {

        }

        private void customButton4_Click(object sender, EventArgs e)
        {
            reload();
            searchBox.Clear();
            typeAccountBox.SelectedIndex = -1;
            departmentsBox.SelectedIndex = -1;
        }
    }
}
