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
    public partial class A_MyTaskList : Form
    {
        GiaoViecService giaoViecService = new GiaoViecService();
        NhanViecService nhanViecService = new NhanViecService();
        PhongBanService phongBanService = new PhongBanService();
        KhuVucLamViecService khuVucLamViecService = new KhuVucLamViecService();
        TagService tagService = new TagService();
        private string selectedTaskID = "";

        public A_MyTaskList()
        {
            InitializeComponent();
        }

        private void currentUserName_Click(object sender, EventArgs e) { }

        private void customButton3_Click(object sender, EventArgs e) { }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changeLanguage()
        {
            if (Session.Instance.Language == "vi")
            {
                languageSelect.SelectedItem = "VIETNAMESE";
            }
            else
            {
                languageSelect.SelectedItem = "ENGLISH";
            }
            Font font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            Font fontLarge = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            if (Session.Instance.Language == "vi")
            {
                customButton8.Text = "THỐNG KÊ";
                customButton9.Text = "BÁO CÁO";
                customButton7.Text = "CÔNG VIỆC";
                customButton18.Text = "CƯ DÂN VÀ CĂN HỘ";
                customButton1.Text = "DỊCH VỤ CƯ DÂN";
                customButton17.Text = "QUẢN LÝ TÀI KHOẢN";
                customButton2.Text = "TẤT CẢ CÔNG VIỆC";
                customButton16.Text = "CÔNG VIỆC CỦA TÔI";
                customButton5.Text = "CÔNG VIỆC ĐƯỢC CHIA SẺ";
                createGroupButton.Text = "TẠO NHÓM";
                grandChart.Text = "VẼ BIỂU ĐỒ";
                label1.Text = "TRẠNG THÁI";
                label2.Text = "PHÒNG BAN";
                label3.Text = "NHÃN";
                label19.Text = "CHỈNH SỬA";
                font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            }
            else
            {
                fontLarge = new Font("Copperplate Gothic Bold", 12);
                font = new Font("Copperplate Gothic Bold", 10);
                customButton8.Text = "STATISTIC";
                customButton9.Text = "REPORT";
                customButton7.Text = "WORK";
                customButton18.Text = "APARTMENT RESIDENT";
                customButton1.Text = "RESIDENT SERVICE";
                customButton17.Text = "ACCOUNT MANAGEMENT";
                customButton2.Text = "ALL TASK LIST";
                customButton16.Text = "MY TASK LIST";
                customButton5.Text = "OBSERVED TASK";
                createGroupButton.Text = "CREATE GROUP";
                grandChart.Text = "GRAND CHART";
                label1.Text = "STATUS";
                label2.Text = "DEPARTMENT";
                label3.Text = "TAG";
                label19.Text = "EDIT MODE";
            }
            customButton8.Font = font;
            customButton7.Font = font;
            customButton18.Font = font;
            customButton1.Font = font;
            customButton17.Font = font;
            customButton2.Font = font;
            customButton16.Font = font;
            customButton5.Font = font;
            createGroupButton.Font = font;
            grandChart.Font = font;
            label1.Font = font;
            label2.Font = font;
            label3.Font = font;
            label19.Font = font;
            // Special element
            customButton2.Font = fontLarge;
            customButton16.Font = fontLarge;
            customButton5.Font = fontLarge;
            createGroupButton.Font = fontLarge;
            grandChart.Font = fontLarge;
        }


        private void A_EditTask_Load(object sender, EventArgs e)
        {
            changeLanguage();
            if (editMode.Checked)
            {
                cancelButton.Visible = true;
                saveButton.Visible = true;
            }
            departmentsBox.Items.Clear();
            List<PhongBan> departments = phongBanService.getAllDepartment();
            foreach (PhongBan department in departments)
            {
                departmentsBox.Items.Add(department.MaPb);
            }
            departmentsBox.Items.Add("All");

            tagBox.Items.Clear();
            List<(string name, string ID, string description)> tags = tagService.getAllTag();
            foreach ((string name, string ID, string description) tag in tags)
            {
                tagBox.Items.Add(tag.name);
            }
            tagBox.Items.Add("All");

            string currentUser = Session.Instance.Name;
            if (Session.Instance.laCEO)
            {
                currentPosition.Text = "CEO";
            }
            else if (Session.Instance.laQuanLi)
            {
                currentPosition.Text = "MANAGER";
            }
            else
            {
                currentPosition.Text = "STAFF";
                createGroupButton.Visible = false;
                createGroupButton.Enabled = false;
            }
            currentUserName.Text = Session.Instance.Name;
            currentID.Text = Session.Instance.UserName;
            if (currentUser != null && !Session.Instance.UserName.Contains("GD"))
            {
                grandChart.Enabled = false;
                grandChart.Visible = false;
            }
            membersGrid.Columns.Add("MaGiaoViec", "ID");
            membersGrid.Columns.Add("TenCongViec", "Name");
            membersGrid.Columns.Add("MoTaCongViec", "Description");
            membersGrid.Columns.Add("NgayGiao", "Start Day");
            membersGrid.Columns.Add("HanHoanThanh", "End Day");
            membersGrid.Columns.Add("TinhTrangCongViec", "Status");
            membersGrid.Columns.Add("Tag", "Tag");
            reload();
            DataGridViewLinkColumn links = new DataGridViewLinkColumn();
            links.UseColumnTextForLinkValue = true;
            links.HeaderText = "Download";
            links.DataPropertyName = "lnkColumn";
            links.Name = "lnkColumn";
            links.ActiveLinkColor = Color.White;
            links.LinkBehavior = LinkBehavior.SystemDefault;
            links.LinkColor = Color.Blue;
            links.Text = "Click here";
            links.TrackVisitedState = true;
            links.VisitedLinkColor = Color.YellowGreen;
            membersGrid.Columns.Add(links);
        }

        private void reload()
        {
            if (IsValidImageData(Session.Instance.Avatar))
            {
                currentAvatarSmall.Image = convertByteToImage(Session.Instance.Avatar);
                currentAvatarBig.Image = convertByteToImage(Session.Instance.Avatar);
            }
            membersGrid.Rows.Clear();
            // Authentication
            List<GiaoViec> members = [];
            if (Session.Instance.laCEO)
            {
                members = giaoViecService.getAll();
            }
            else if (Session.Instance.laQuanLi)
            {
                string departmentID = Session.Instance.UserName.Split('-')[0];
                members = giaoViecService.getTaskOfDeparment(departmentID);
            }
            else
            {
                string departmentID = Session.Instance.UserName.Split('-')[0];
                members = giaoViecService.getTaskOfDeparment(departmentID);
            }
            int taskQuantity = 0;
            int completedTaskQuantity = 0;
            int incompletedTaskQuantity = 0;
            foreach (GiaoViec member in members)
            {
                List<(string name, string ID, string description)> tag = tagService.getTaskTagInfo(
                    member.MaGiaoViec
                );
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(membersGrid);
                row.Cells[0].Value = member.MaGiaoViec;
                row.Cells[1].Value = member.TenCongViec;
                row.Cells[2].Value = member.MoTaCongViec;
                row.Cells[3].Value = member.NgayGiao;
                row.Cells[4].Value = member.HanHoanThanh;
                row.Cells[5].Value = member.TinhTrangCongViec;
                row.Cells[6].Value = tag.Count > 0 ? tag[0].name : "N/A";
                membersGrid.Rows.Add(row);
                taskQuantity++;
                if (member.TinhTrangCongViec != null && member.TinhTrangCongViec == "Completed")
                {
                    completedTaskQuantity++;
                }
                else
                {
                    incompletedTaskQuantity++;
                }
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

        private void membersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedTaskID = membersGrid.Rows[e.RowIndex].Cells["MaGiaoViec"].Value.ToString();
            }
        }

        private void membersGrid_CellContentDownloadClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == membersGrid.Columns["lnkColumn"].Index && e.RowIndex >= 0)
            {
                string id = membersGrid.Rows[e.RowIndex].Cells["MaGiaoViec"].Value.ToString();
                giaoViecService.downloadAttachedFile(id);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            GiaoViec? task = giaoViecService.findAssignedTask(selectedTaskID);
            string implementor = nhanViecService.getInplementor(selectedTaskID);
            string venue = khuVucLamViecService.getVenue(selectedTaskID);
            bool isValidFile = giaoViecService.checkValidPdf(selectedTaskID);
            List<(string name, string ID, string description)> tag = tagService.getTaskTagInfo(
                selectedTaskID
            );
            if (task != null)
            {
                A_EditTask editTask = new A_EditTask(
                    task.MoTaCongViec,
                    task.NgayGiao,
                    task.HanHoanThanh,
                    task.TinhTrangCongViec,
                    isValidFile,
                    task.MaGiaoViec,
                    task.CheDo == true ? 1 : 0,
                    task.TenCongViec,
                    venue,
                    implementor,
                    Session.Instance.laCEO == true ? 1 : 0,
                    Session.Instance.UserName,
                    task.UyQuyenBoi,
                    tag.Count != 0 ? tag[0].name : "N/A"
                );
                editTask.ShowDialog();
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void typeBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            performSearch();
        }

        private void statusBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            performSearch();
        }

        private void performSearch()
        {
            string keySearch = searchBox.Text;
            string selectedDepartment =
                departmentsBox.SelectedItem != null ? departmentsBox.SelectedItem.ToString() : "";
            string selectedTag = tagBox.SelectedItem != null ? tagBox.SelectedItem.ToString() : "";
            string selectedStatus =
                statusBox.SelectedItem != null ? statusBox.SelectedItem.ToString() : "";

            try
            {
                DatabaseConnection.Instance.OpenConnection();

                SqlConnection conn = DatabaseConnection.Instance.GetConnection();

                membersGrid.Rows.Clear();
                using (
                    SqlCommand command = new SqlCommand(
                        "SELECT * FROM dbo.timKiemCongViec(@noidung)",
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
                                string ID = reader.GetString(reader.GetOrdinal("maGiaoViec"));
                                string assignerID = ID.Split('.')[0];
                                string departmentID = assignerID.Split('-')[0];
                                string name = reader.GetString(reader.GetOrdinal("tenCongViec"));
                                string description = reader.GetString(
                                    reader.GetOrdinal("moTaCongViec")
                                );
                                string start = reader
                                    .GetDateTime("ngayGiao")
                                    .ToString("dd/MM/yyyy");
                                string end = reader
                                    .GetDateTime("hanHoanThanh")
                                    .ToString("dd/MM/yyyy");
                                string status = reader.GetString(
                                    reader.GetOrdinal("tinhTrangCongViec")
                                );

                                bool isValidDepartment =
                                    string.IsNullOrEmpty(selectedDepartment)
                                    || selectedDepartment == "All"
                                    || departmentID == selectedDepartment;

                                bool isValidStatus =
                                    string.IsNullOrEmpty(selectedStatus)
                                    || selectedStatus == "All"
                                    || status == selectedStatus;

                                List<(string name, string ID, string description)> tags =
                                    tagService.getTaskTagInfo(ID);
                                string tag = tags.Count > 0 ? tags[0].name : "N/A";

                                bool isValidTag =
                                    string.IsNullOrEmpty(selectedTag)
                                    || selectedTag == "All"
                                    || tag == selectedTag;

                                if (isValidDepartment && isValidStatus && isValidTag)
                                {
                                    int rowIndex = membersGrid.Rows.Add(
                                        ID,
                                        name,
                                        description,
                                        start,
                                        end,
                                        status,
                                        tag
                                    );
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
            }
            finally
            {
                DatabaseConnection.Instance.CloseConnection();
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void departmentsBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            performSearch();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            performSearch();
        }

        private void editMode_CheckedChanged(object sender, EventArgs e)
        {
            if (editMode.Checked)
            {
                cancelButton.Visible = true;
                saveButton.Visible = true;
            }
            else
            {
                cancelButton.Visible = false;
                saveButton.Visible = false;
            }
        }

        private void languageSelect_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            Font font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            Font fontLarge = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            if (languageSelect.SelectedItem.ToString() == "VIETNAMESE")
            {
                Session.Instance.Language = "vi";
                customButton8.Text = "THỐNG KÊ";
                customButton9.Text = "BÁO CÁO";
                customButton7.Text = "CÔNG VIỆC";
                customButton18.Text = "CƯ DÂN VÀ CĂN HỘ";
                customButton1.Text = "DỊCH VỤ CƯ DÂN";
                customButton17.Text = "QUẢN LÝ TÀI KHOẢN";
                customButton2.Text = "TẤT CẢ CÔNG VIỆC";
                customButton16.Text = "CÔNG VIỆC CỦA TÔI";
                customButton5.Text = "CÔNG VIỆC ĐƯỢC CHIA SẺ";
                createGroupButton.Text = "TẠO NHÓM";
                cancelButton.Text = "THOÁT";
                saveButton.Text = "LƯU";
                grandChart.Text = "VẼ BIỂU ĐỒ";
                label1.Text = "TRẠNG THÁI";
                label2.Text = "PHÒNG BAN";
                label3.Text = "NHÃN";
                label19.Text = "CHỈNH SỬA";
                font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            }
            else
            {
                Session.Instance.Language = "en";
                fontLarge = new Font("Copperplate Gothic Bold", 12);
                font = new Font("Copperplate Gothic Bold", 10);
                customButton8.Text = "STATISTIC";
                customButton9.Text = "REPORT";
                customButton7.Text = "WORK";
                customButton18.Text = "APARTMENT RESIDENT";
                customButton1.Text = "RESIDENT SERVICE";
                customButton17.Text = "ACCOUNT MANAGEMENT";
                customButton2.Text = "ALL TASK LIST";
                customButton16.Text = "MY TASK LIST";
                customButton5.Text = "OBSERVED TASK";
                cancelButton.Text = "CANCEL";
                saveButton.Text = "SAVE";
                createGroupButton.Text = "CREATE GROUP";
                grandChart.Text = "GRAND CHART";
                label1.Text = "STATUS";
                label2.Text = "DEPARTMENT";
                label3.Text = "TAG";
                label19.Text = "EDIT MODE";
            }
            customButton8.Font = font;
            customButton7.Font = font;
            customButton18.Font = font;
            customButton1.Font = font;
            customButton17.Font = font;
            customButton2.Font = font;
            customButton16.Font = font;
            customButton5.Font = font;
            createGroupButton.Font = font;
            grandChart.Font = font;
            label1.Font = font;
            label2.Font = font;
            label3.Font = font;
            label19.Font = font;
            customButton2.Font = fontLarge;
            customButton16.Font = fontLarge;
            customButton5.Font = fontLarge;
            createGroupButton.Font = fontLarge;
            grandChart.Font = fontLarge;
        }

        private void headerPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
