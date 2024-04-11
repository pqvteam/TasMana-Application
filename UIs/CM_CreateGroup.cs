using System;
using System.Collections;
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
using static System.Windows.Forms.AxHost;

namespace UIs
{
    public partial class CM_CreateGroup : Form
    {
        NhanSuService nhanSuService = new NhanSuService();
        NhanVienService nhanVienService = new NhanVienService();
        PhongBanService phongBanService = new PhongBanService();
        NhomService nhomService = new NhomService();

        public CM_CreateGroup()
        {
            InitializeComponent();
        }

        private void CM_CreateGroup_Load(object sender, EventArgs e)
        {
            if (IsValidImageData(Session.Instance.Avatar))
            {
                currentAvatarSmall.Image = convertByteToImage(Session.Instance.Avatar);
            }
            membersGrid.Columns.Add("ID", "ID");
            membersGrid.Columns.Add("Name", "Name");
            membersGrid.Columns.Add("Birthday", "Birthday");
            membersGrid.Columns.Add("Department", "Department");
            membersGrid.Columns.Add("Startdate", "Start Date");
            DataGridViewCheckBoxColumn btnColumn = new DataGridViewCheckBoxColumn();
            btnColumn.HeaderText = "Add to group";
            btnColumn.Name = "btnAdd";
            membersGrid.Columns.Add(btnColumn);
            List<PhongBan> departments = phongBanService.getAllDepartment();
            reload();

            departmentsBox.Items.Clear();
            foreach (PhongBan department in departments)
            {
                departmentsBox.Items.Add(department.MaPb);
            }
            departmentsBox.Items.Add("All");
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reload()
        {
            DatabaseConnection.Instance.OpenConnection();
            membersGrid.Rows.Clear();

            DatabaseConnection.Instance.OpenConnection();
            List<NhanSu> members = nhanSuService.getAllStaffs();
            membersGrid.Rows.Clear();

            List<NhanVien> staffNoGroup = nhanVienService.getStaffsDoNotHaveGroup();
            foreach (var member in members)
            {
                foreach (NhanVien staff in staffNoGroup)
                {
                    if (staff.MaThanhVien == member.MaThanhVien)
                    {
                        string departmentID = member.MaThanhVien.Split("-")[0];
                        DateOnly dateOnly = member.NgayBatDau.Value;
                        string start = dateOnly.ToString("dd/MM/yyyy");

                        membersGrid.Rows.Add(
                            member.MaThanhVien,
                            member.HoVaTen,
                            member.NamSinh.ToString("dd/MM/yyyy"),
                            departmentID,
                            start
                        );
                    }
                }
            }
        }

        private void customButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void typeAccountBox_OnSelectedIndexChanged(object sender, EventArgs e) { }

        private void departmentsBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void PerformSearch()
        {
            string keySearch = searchBox.Text;
            string selectedDepartment =
                departmentsBox.SelectedItem != null ? departmentsBox.SelectedItem.ToString() : "";

            try
            {
                DatabaseConnection.Instance.OpenConnection();

                SqlConnection conn = DatabaseConnection.Instance.GetConnection();
                List<NhanVien> staffNoGroup = nhanVienService.getStaffsDoNotHaveGroup();

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
                                string birthday = reader
                                    .GetDateTime("namSinh")
                                    .ToString("dd/MM/yyyy");
                                string start = reader
                                    .GetDateTime("ngayBatDau")
                                    .ToString("dd/MM/yyyy");
                                bool fired = reader.GetBoolean("nghiViec");
                                string departmentID = ID.Split('-')[0];

                                bool isValidDepartment =
                                    string.IsNullOrEmpty(selectedDepartment)
                                    || selectedDepartment == "All"
                                    || departmentID == selectedDepartment;

                                if (isValidDepartment)
                                {
                                    foreach (NhanVien staff in staffNoGroup)
                                    {
                                        if (staff.MaThanhVien == ID)
                                        {
                                            membersGrid.Rows.Add(
                                                ID,
                                                name,
                                                birthday,
                                                departmentID,
                                                start
                                            );
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                DatabaseConnection.Instance.CloseConnection();
            }
        }

        private void membersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == membersGrid.Columns["btnAdd"].Index && e.RowIndex >= 0)
            {
                // Lấy giá trị của checkbox được chọn
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)
                    membersGrid.Rows[e.RowIndex].Cells["btnAdd"];
                if (chk.Value == chk.FalseValue)
                {
                    string selectedMember = membersGrid
                        .Rows[e.RowIndex]
                        .Cells["ID"]
                        .Value.ToString();

                    if (!chosenMembersBox.Items.Contains(selectedMember))
                    {
                        chosenMembersBox.Items.Add(selectedMember);
                    }
                }
                else
                {
                    string selectedMember = membersGrid
                        .Rows[e.RowIndex]
                        .Cells["ID"]
                        .Value.ToString();

                    if (chosenMembersBox.Items.Contains(selectedMember))
                    {
                        chosenMembersBox.Items.Remove(selectedMember);
                    }
                }
            }
        }

        private void customButton4_Click(object sender, EventArgs e) { }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string keySearch = searchBox.Text;
            try
            {
                DatabaseConnection.Instance.OpenConnection();

                SqlConnection conn = DatabaseConnection.Instance.GetConnection();
                List<NhanVien> staffNoGroup = nhanVienService.getStaffsDoNotHaveGroup();

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
                                if (
                                    (selectedDepartment == "" || selectedDepartment == "All")
                                    && (selectedType == "All" || selectedType == "")
                                )
                                {
                                    foreach (NhanVien staff in staffNoGroup)
                                    {
                                        if (staff.MaThanhVien == ID)
                                        {
                                            membersGrid.Rows.Add(
                                                ID,
                                                name,
                                                birthday,
                                                departmentID,
                                                start
                                            );
                                        }
                                    }
                                }
                                else if (
                                    (selectedDepartment != "" || selectedDepartment != "All")
                                    && (selectedType == "All" || selectedType == "")
                                )
                                {
                                    foreach (NhanVien staff in staffNoGroup)
                                    {
                                        if (
                                            ID.Contains(selectedDepartment)
                                            && staff.MaThanhVien == ID
                                        )
                                        {
                                            membersGrid.Rows.Add(
                                                ID,
                                                name,
                                                birthday,
                                                departmentID,
                                                start
                                            );
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

        private void confirmButton_Click(object sender, EventArgs e)
        {
            List<string> selectedIDs = new List<string>();
            List<string> IDsList = [];
            foreach (DataGridViewRow row in membersGrid.Rows)
            {
                if (
                    row.Cells["btnAdd"] is DataGridViewCheckBoxCell checkBoxCell
                    && Convert.ToBoolean(checkBoxCell.Value)
                )
                {
                    selectedIDs.Add(row.Cells["ID"].Value.ToString());
                    IDsList.Add(row.Cells["ID"].Value.ToString());
                }
            }

            if (selectedIDs.Count > 0)
            {
                List<string> departmentsList = [];
                string groupName = groupNameBox.Text;
                string leaderID =
                    chosenMembersBox.SelectedItem != null
                        ? chosenMembersBox.SelectedItem.ToString()
                        : "";

                MessageBox.Show(leaderID);
                foreach (string memberID in selectedIDs)
                {
                    if (!departmentsList.Contains(memberID.Split('-')[0]))
                    {
                        departmentsList.Add(memberID.Split('-')[0]);
                    }
                }
                string IDs = string.Join(",", IDsList);
                MessageBox.Show(IDs);
                if (departmentsList.Count > 1)
                {
                    string confirmMessage =
                        "ARE YOU SURE TO CREATE GROUP FROM DIFFERENT DEPARTMENTS?";
                    A_Confirm confirmForm = new A_Confirm(confirmMessage, "warning");
                    confirmForm.ConfirmClicked += (confirmSender, confirmArgs) =>
                    {
                        bool isSuccess = nhomService.createGroup(groupName, IDs, leaderID);
                        if (isSuccess)
                        {
                            MessageBox.Show("Create group successfully");
                            groupNameBox.Text = "";
                            groupNameBox.Focus();
                            chosenMembersBox.Items.Clear();
                            reload();
                        }
                        else
                        {
                            MessageBox.Show("Create group failed");
                        }
                    };
                    confirmForm.ShowDialog();
                }
                else
                {
                    bool isSuccess = nhomService.createGroup(groupName, IDs, leaderID);
                    if (isSuccess)
                    {
                        MessageBox.Show("Create group successfully");
                    }
                    else
                    {
                        MessageBox.Show("Create group failed");
                    }
                }
            }
            else
            {
                MessageBox.Show("No IDs selected.");
            }
        }

        private void customButton22_Click(object sender, EventArgs e)
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
    }
}
