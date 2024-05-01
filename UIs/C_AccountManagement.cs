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
using UIs.CustomComponent;

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
            changeLanguage();
            languageSelect.SelectedItem = Session.Instance.Language == "en" ? "ENGLISH" : "VIETNAMESE";
            if (IsValidImageData(Session.Instance.Avatar))
            {
                currentAvatarSmall.Image = convertByteToImage(Session.Instance.Avatar);
            }

            if (!(Session.Instance.UserName.Contains("GD") || Session.Instance.laQuanLi))
            {
                customButton19.Visible = false;
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
            List<NhanSu> members = nhanSuService.getAllMembers();
            membersGrid.Rows.Clear();

            foreach (var member in members)
            {
                string memberType = "";
                string role = "Staff";
                if (member.MaThanhVien.StartsWith("GD"))
                {
                    role = "CEO";
                    memberType = "CEO";
                }
                else if (member.LaQuanLi)
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
                bool fired = member.NghiViec;
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

                if (fired)
                {
                    membersGrid.Rows[rowIndex].Cells["Fired"].Value = true;
                }
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
            string? department = membersGrid.Rows[e.RowIndex].Cells["Department"].Value.ToString();
            bool isManager =
                membersGrid.Rows[e.RowIndex].Cells["btnAppoint"].Value != null
                    ? (bool)membersGrid.Rows[e.RowIndex].Cells["btnAppoint"].Value
                    : false;
            bool isFired =
                membersGrid.Rows[e.RowIndex].Cells["Fired"].Value != null
                    ? (bool)membersGrid.Rows[e.RowIndex].Cells["Fired"].Value
                    : false;
            string CEOID = Session.Instance.UserName;
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
                            if (Session.Instance.UserName.Contains("GD"))
                            {
                                bool isSuccess = ceoService.deposeManager(memberId, CEOID);
                                if (isSuccess)
                                {
                                    showToast("SUCCESS", "Depose manager successfully");
                                    PerformSearch();
                                }
                                else
                                {
                                    showToast("ERROR", "Depose manager failure");

                                }
                            }
                            else
                            {
                                showToast("ERROR", "You don't have right to depose");

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
                            if (Session.Instance.UserName.Contains("GD"))
                            {
                                bool isSuccess = ceoService.appointManager(memberId, CEOID);
                                if (isSuccess)
                                {
                                    showToast("SUCCESS", "Appoint manager successfully");
                                    PerformSearch();
                                }
                                else
                                {
                                    showToast("ERROR", "Appoint manager failure");
                                }
                            }
                            else
                            {
                                showToast("ERROR", "You don't have right to appoint");
                            }

                        };
                        confirmForm.ShowDialog();
                    }
                }
            }
            else if (e.ColumnIndex == membersGrid.Columns["btnLeader"].Index && e.RowIndex >= 0)
            {
                if (Session.Instance.UserName.Contains("GD") || Session.Instance.laQuanLi)
                {
                    A_Appoint appointForm = new A_Appoint(memberId, CEOID);
                    appointForm.ShowDialog();
                }
                else
                {
                    showToast("ERROR", "You don't have right to appoint");
                }

                PerformSearch();
            }
            else if (e.ColumnIndex == membersGrid.Columns["Fired"].Index && e.RowIndex >= 0)
            {
                if (memberId != null)
                {
                    if (!isFired)
                    {
                        string confirmMessage = "ARE YOU SURE TO DEACTIVE THIS ACCOUNT?";
                        A_Confirm confirmForm = new A_Confirm(confirmMessage, "danger");
                        confirmForm.ConfirmClicked += (confirmSender, confirmArgs) =>
                        {
                            if (Session.Instance.UserName.Contains("GD"))
                            {
                                bool isSuccess = ceoService.firedStaff(memberId, CEOID);
                                if (isSuccess)
                                {
                                    showToast("SUCCESS", "You don't have right to deactive");
                                    reload();
                                    PerformSearch();
                                }
                                else
                                {
                                    showToast("ERROR", "Deactive account failure");

                                }
                            }
                            else if (Session.Instance.UserName.Contains(department) && isManager == false && Session.Instance.laQuanLi == true)
                            {
                                bool isSuccess = quanLyService.firedStaff(memberId, Session.Instance.UserName);
                                if (isSuccess)
                                {
                                    showToast("SUCCESS", "Deactive this account successfully");
                                    reload();
                                    PerformSearch();
                                }
                                else
                                {
                                    showToast("ERROR", "Deactive this account failure");

                                }
                            }
                            else
                            {
                                showToast("ERROR", "Deactive account failure");
                            }
                        };
                        confirmForm.ShowDialog();
                    }
                    else
                    {
                        showToast("ERROR", "This account has been deactive");

                    }
                }
            }
            reload();
            PerformSearch();
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
                            showToast("ERROR", "No result is found");

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                showToast("ERROR", "An Error Occur");

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
                                    if (fired)
                                    {
                                        membersGrid.Rows[rowIndex].Cells["Fired"].Value = true;
                                    }
                                }
                            }
                        }
                        else
                        {
                            showToast("ERROR", "No result is found");

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
                showToast("ERROR", "An Error Occur");

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

        private void customButton22_Click(object sender, EventArgs e)
        {
            if (tableLayoutPanel1.Visible == false)
            {
                tableLayoutPanel1.Visible = true;
            }
            else
            {
                tableLayoutPanel1.Visible = false;
            }

        }

        public Image convertByteToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        private bool IsValidImageData(byte[] imageData)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    Image.FromStream(ms);
                }
                return true; // Image data is valid
            }
            catch (Exception)
            {
                return false; // Image data is not valid
            }
        }

        private void currentAvatarSmall_Click(object sender, EventArgs e)
        {
            if (Session.Instance.UserName.Contains("GD") || Session.Instance.laQuanLi)
            {
                M_Information information = new M_Information();
                information.ShowDialog();
            }
            else
            {
                E_Information information = new E_Information();
                information.ShowDialog();
            }
        }

        private void headerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customButton5_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void info_button_Click(object sender, EventArgs e)
        {

        }

        private void changeLanguage()
        {
            Font font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            if (Session.Instance.Language == "vi")
            {
                customButton8.Text = "THỐNG KÊ";
                customButton9.Text = "BÁO CÁO";
                customButton7.Text = "CÔNG VIỆC";
                customButton18.Text = "CƯ DÂN VÀ CĂN HỘ";
                customButton17.Text = "QUẢN LÝ TÀI KHOẢN";
                label1.Text = "TỪ KHÓA";
                label2.Text = "PHÒNG BAN";
                label3.Text = "LOẠI TÀI KHOẢN";
                customButton19.Text = "TẠO MỚI";
                font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            }
            else
            {
                font = new Font("Copperplate Gothic Bold", 10, FontStyle.Bold);
                customButton8.Text = "STATISTIC";
                customButton9.Text = "REPORT";
                customButton7.Text = "WORK";
                customButton18.Text = "APARTMENT RESIDENT";
                customButton17.Text = "ACCOUNT MANAGEMENT";
                label1.Text = "SEARCH";
                label2.Text = "DEPARTMENT";
                label3.Text = "ACCOUNT TYPE";
                customButton19.Text = "CREATE";
            }
            customButton8.Font = font;
            customButton9.Font = font;
            customButton7.Font = font;
            customButton18.Font = font;
            customButton17.Font = font;
            customButton3.Font = font;
            customButton19.Font = font;
            customButton2.Font = font;
            label1.Font = font;
            label2.Font = font;
            label3.Font = font;
        }

        private void languageSelect_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            Font font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            if (languageSelect.SelectedItem.ToString() == "Vietnamese" || languageSelect.SelectedItem.ToString() == "VIETNAMESE")
            {
                Session.Instance.Language = "vi";
                customButton8.Text = "THỐNG KÊ";
                customButton9.Text = "BÁO CÁO";
                customButton7.Text = "CÔNG VIỆC";
                customButton18.Text = "CƯ DÂN VÀ CĂN HỘ";
                customButton17.Text = "QUẢN LÝ TÀI KHOẢN";
                label1.Text = "TỪ KHÓA";
                label2.Text = "PHÒNG BAN";
                label3.Text = "LOẠI TÀI KHOẢN";
                customButton19.Text = "TẠO MỚI";
                font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            }
            else
            {
                Session.Instance.Language = "en";
                font = new Font("Copperplate Gothic Bold", 10, FontStyle.Bold);
                customButton8.Text = "STATISTIC";
                customButton9.Text = "REPORT";
                customButton7.Text = "WORK";
                customButton18.Text = "APARTMENT RESIDENT";
                customButton17.Text = "ACCOUNT MANAGEMENT";
                label1.Text = "SEARCH";
                label2.Text = "DEPARTMENT";
                label3.Text = "ACCOUNT TYPE";
                customButton3.Text = "ACTIVE ACCOUNT";
                customButton19.Text = "CREATE";
                customButton2.Text = "INACTIVE ACCOUNT";
            }
            customButton8.Font = font;
            customButton9.Font = font;
            customButton7.Font = font;
            customButton18.Font = font;
            customButton17.Font = font;
            customButton19.Font = font;
            label1.Font = font;
            label2.Font = font;
            label3.Font = font;
        }

        private void customButton7_Click(object sender, EventArgs e)
        {
            C_AllTaskList c_AllTaskList = new C_AllTaskList();
            c_AllTaskList.ShowDialog();
        }

        private void customButton18_Click(object sender, EventArgs e)
        {
            CM_Resident_sDetail cM_Resident_SDetail = new CM_Resident_sDetail();
            cM_Resident_SDetail.ShowDialog();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            if (Session.Instance.UserName.Contains("GD") || Session.Instance.laQuanLi)
            {
                M_Information information = new M_Information();
                information.ShowDialog();
            }
            else
            {
                E_Information information = new E_Information();
                information.ShowDialog();
            }
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            G_ForgotPassword g_ForgotPassword = new G_ForgotPassword();
            g_ForgotPassword.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            List<Form> formsToClose = new List<Form>();

            foreach (Form form in Application.OpenForms)
            {
                if (form != this) // Assuming "this" refers to the main form
                {
                    formsToClose.Add(form);
                }
            }

            foreach (Form form in formsToClose)
            {
                form.Close();
            }

            G_Login g_Login = new G_Login();
            g_Login.ShowDialog();
        }

        private void customButton17_Click(object sender, EventArgs e)
        {
            reload();
        }
        public void showToast(string type, string message)
        {
            ToastForm show = new ToastForm(type, message);
            show.Show();
        }
    }
}
