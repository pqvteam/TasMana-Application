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
            changelanguage();
            languageSelect.SelectedItem = Session.Instance.Language == "en" ? "ENGLISH" : "VIETNAMESE";
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
                            showToast("INFO", "No result is found");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                showToast("ERROR", "An error occurred");
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
                            showToast("INFO", "No result is found");

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                showToast("ERROR", "An error occurred");
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

                foreach (string memberID in selectedIDs)
                {
                    if (!departmentsList.Contains(memberID.Split('-')[0]))
                    {
                        departmentsList.Add(memberID.Split('-')[0]);
                    }
                }
                string IDs = string.Join(",", IDsList);
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
                            showToast("SUCCESS", "Create group successfully");
                            groupNameBox.Text = "";
                            groupNameBox.Focus();
                            chosenMembersBox.Items.Clear();
                            reload();
                        }
                        else
                        {
                            showToast("ERROR", "Create group failed");
                        }
                    };
                    confirmForm.ShowDialog();
                }
                else
                {
                    bool isSuccess = nhomService.createGroup(groupName, IDs, leaderID);
                    if (isSuccess)
                    {
                        showToast("SUCCESS", "Create group successfully");
                    }
                    else
                    {
                        showToast("ERROR", "Create group failed");
                    }
                }
            }
            else
            {
                showToast("ERROR", "No IDs selected");
            }
        }

        private void customButton22_Click(object sender, EventArgs e)
        {
            if (tableLayoutPanel2.Visible == false)
            {
                tableLayoutPanel2.Visible = true;
            }
            else
            {
                tableLayoutPanel2.Visible = false;
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

        private void changelanguage()
        {
            Font font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            Font fontLarger = new Font("Copperplate Gothic Bold", 14);
            Font fontSmaller = new Font("Copperplate Gothic Bold", 10);
            if (Session.Instance.Language == "vi")
            {
                customButton7.Text = "CÔNG VIỆC";
                customButton8.Text = "THỐNG KÊ";
                customButton9.Text = "BÁO CÁO";
                customButton17.Text = "QUẢN LÝ TÀI KHOẢN";
                customButton18.Text = "CƯ DÂN VÀ CĂN HỘ";
                label10.Text = "THÔNG TIN";
                label9.Text = "ĐỔI MẬT KHẨU";
                label8.Text = "ĐĂNG XUẤT";
                label3.Text = "TÊN NHÓM";
                label5.Text = "BỘ PHẬN";
                label6.Text = "TÌM KIẾM";
                label2.Text = "NHÓM TRƯỞNG";
                cancelButton.Text = "HỦY";
                confirmButton.Text = "HOÀN THÀNH";
                fontSmaller = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);

                titleBox.Text = "TẠO NHÓM MỚI";
                fontLarger = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);

                label1.Text = "CHỌN THÀNH VIÊN";
                font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            }
            else
            {
                customButton7.Text = "WORK";
                customButton8.Text = "STATISTIC";
                customButton9.Text = "REPORT";
                customButton17.Text = "ACCOUNTING MANAGEMENT";
                customButton18.Text = "APARTMENT RESIDENT";
                label10.Text = "INFORMATION";
                label9.Text = "CHANGE PASSWORD";
                label8.Text = "SIGN OUT";
                label3.Text = "GROUP NAME";
                label5.Text = "DEPARTMENT";
                label6.Text = "SEARCH";
                label2.Text = "LEADER";
                cancelButton.Text = "CANCEL";
                confirmButton.Text = "DONE";
                fontSmaller = new Font("Copperplate Gothic Bold", 10);

                titleBox.Text = "CREATE NEW GROUP";
                fontLarger = new Font("Copperplate Gothic Bold", 14);

                label1.Text = "CHOOSE MEMBER";
                font = new Font("Copperplate Gothic Bold", 12);
            }
            customButton7.Font = fontSmaller;
            customButton8.Font = fontSmaller;
            customButton9.Font = fontSmaller;
            customButton17.Font = fontSmaller;
            customButton18.Font = fontSmaller;
            label10.Font = fontSmaller;
            label9.Font = fontSmaller;
            label8.Font = fontSmaller;
            label3.Font = fontSmaller;
            label5.Font = fontSmaller;
            label6.Font = fontSmaller;
            label2.Font = fontSmaller;
            groupNameBox.Font = fontSmaller;
            searchBox.Font = fontSmaller;
            cancelButton.Font = fontSmaller;
            confirmButton.Font = fontSmaller;

            titleBox.Font = fontLarger;

            label1.Font = font;
        }

        private void languageSelect_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            Font font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            Font fontLarger = new Font("Copperplate Gothic Bold", 12);
            Font fontSmaller = new Font("Copperplate Gothic Bold", 9);
            if (languageSelect.SelectedItem.ToString() == "VIETNAMESE")
            {
                Session.Instance.Language = "vi";
                customButton7.Text = "CÔNG VIỆC";
                customButton8.Text = "THỐNG KÊ";
                customButton9.Text = "BÁO CÁO";
                customButton17.Text = "QUẢN LÝ TÀI KHOẢN";
                customButton18.Text = "CƯ DÂN VÀ CĂN HỘ";
                label10.Text = "THÔNG TIN";
                label9.Text = "ĐỔI MẬT KHẨU";
                label8.Text = "ĐĂNG XUẤT";
                label3.Text = "TÊN NHÓM";
                label5.Text = "BỘ PHẬN";
                label6.Text = "TÌM KIẾM";
                label2.Text = "NHÓM TRƯỞNG";
                cancelButton.Text = "HỦY";
                confirmButton.Text = "HOÀN THÀNH";
                fontSmaller = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);

                titleBox.Text = "TẠO NHÓM MỚI";
                fontLarger = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);

                label1.Text = "CHỌN THÀNH VIÊN";
                font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            }
            else
            {
                Session.Instance.Language = "en";
                customButton7.Text = "WORK";
                customButton8.Text = "STATISTIC";
                customButton9.Text = "REPORT";
                customButton17.Text = "ACCOUNTING MANAGEMENT";
                customButton18.Text = "APARTMENT RESIDENT";
                label10.Text = "INFORMATION";
                label9.Text = "CHANGE PASSWORD";
                label8.Text = "SIGN OUT";
                label3.Text = "GROUP NAME";
                label5.Text = "DEPARTMENT";
                label6.Text = "SEARCH";
                label2.Text = "LEADER";
                cancelButton.Text = "CANCEL";
                confirmButton.Text = "DONE";
                fontSmaller = new Font("Copperplate Gothic Bold", 10);

                titleBox.Text = "CREATE NEW GROUP";
                fontLarger = new Font("Copperplate Gothic Bold", 14);

                label1.Text = "CHOOSE MEMBER";
                font = new Font("Copperplate Gothic Bold", 12);
            }
            customButton7.Font = fontSmaller;
            customButton8.Font = fontSmaller;
            customButton9.Font = fontSmaller;
            customButton17.Font = fontSmaller;
            customButton18.Font = fontSmaller;
            label10.Font = fontSmaller;
            label9.Font = fontSmaller;
            label8.Font = fontSmaller;
            label3.Font = fontSmaller;
            label5.Font = fontSmaller;
            label6.Font = fontSmaller;
            label2.Font = fontSmaller;
            groupNameBox.Font = fontSmaller;
            searchBox.Font = fontSmaller;
            cancelButton.Font = fontSmaller;
            confirmButton.Font = fontSmaller;

            titleBox.Font = fontLarger;

            label1.Font = font;
        }

        private void customButton7_Click(object sender, EventArgs e)
        {
            C_AllTaskList c_AllTaskList = new C_AllTaskList();
            c_AllTaskList.ShowDialog();
        }

        private void customButton17_Click(object sender, EventArgs e)
        {
            C_AccountManagement c_AccountManagement = new C_AccountManagement();
            c_AccountManagement.ShowDialog();
        }

        private void customButton18_Click(object sender, EventArgs e)
        {
            CM_Resident_sDetail cM = new CM_Resident_sDetail();
            cM.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
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

        private void label9_Click(object sender, EventArgs e)
        {
            G_ForgotPassword g_ForgotPassword = new G_ForgotPassword();
            g_ForgotPassword.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            List<Form> formsToClose = new List<Form>();

            foreach (Form form in Application.OpenForms)
            {
                if (form != this)
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
        public void showToast(string type, string message)
        {
            ToastForm show = new ToastForm(type, message);
            show.Show();
        }
    }
}
