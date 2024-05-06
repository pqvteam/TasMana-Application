using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
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
    public partial class C_AllTaskList : Form
    {
        GiaoViecService giaoViecService = new GiaoViecService();
        TagService tagService = new TagService();

        public C_AllTaskList()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e) { }

        private void rjTextBox1__TextChanged(object sender, EventArgs e) { }

        private void rjTextBox2__TextChanged(object sender, EventArgs e) { }

        private void customDateTimePicker3_ValueChanged(object sender, EventArgs e) { }

        private void C_AllTaskList_Load(object sender, EventArgs e)
        {
            changeLanguage();
            languageSelect.SelectedItem = "ENGLISH";

            GetWeather getWeather = new GetWeather();
            string[] currentWeather = getWeather.getWeatherData("Ho Chi Minh City");
            //weatherType.Text = currentWeather[1];
            //weatherTempurature.Text = currentWeather[2];
            //weatherWindSpeed.Text = currentWeather[3];
            weatherLocation.Text = "Ho Chi Minh City";
            //MessageBox.Show($"0: {currentWeather[0]}");
            //MessageBox.Show($"1: {currentWeather[1]}");
            //MessageBox.Show($"2: {currentWeather[2]}");
            //MessageBox.Show($"3: {currentWeather[3]}");
            currentTime.Text = DateTime.Now.ToLongTimeString();
            timer.Start();
            if (weatherType.Text.ToLower() == "cloudy")
            {
                weatherPic.Image = Properties.Resources.cloudy;
                weatherType.ForeColor = Color.White;
            }
            else if (weatherType.Text.ToLower() == "rainy")
            {
                weatherPic.Image = Properties.Resources.rainy;
                weatherType.ForeColor = Color.Blue;
            }
            else if (weatherType.Text.ToLower() == "sunny")
            {
                weatherPic.Image = Properties.Resources.sunny;
                weatherType.ForeColor = Color.Yellow;
            }
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
            currentNameLabel.Text = $"Hello {currentUser}";
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
            taskQuantityLabel.Text = taskQuantity + "";
            compeletedQuantityLabel.Text = completedTaskQuantity + "";
            incompletedQuantityLabel.Text = incompletedTaskQuantity + "";
        }

        private void hrButton_Click(object sender, EventArgs e)
        {
            membersGrid.Rows.Clear();
            List<GiaoViec> members = giaoViecService.getTaskOfDeparment("DV");
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
            }
        }

        private void PerformSearch()
        {
            string keySearch = searchBox.Text;

            if (!keySearch.Equals(""))
            {
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
                                    string name = reader.GetString(
                                        reader.GetOrdinal("tenCongViec")
                                    );
                                    string description = reader.GetString(
                                        reader.GetOrdinal("moTaCongViec")
                                    );
                                    string memberType = "";
                                    string start = reader
                                        .GetDateTime("ngayGiao")
                                        .ToString("dd/MM/yyyy");
                                    string end = reader
                                        .GetDateTime("hanHoanThanh")
                                        .ToString("dd/MM/yyyy");
                                    string status = reader.GetString(
                                        reader.GetOrdinal("tinhTrangCongViec")
                                    );
                                    List<(string name, string ID, string description)> tags =
                                        tagService.getTaskTagInfo(ID);
                                    string tag = tags.Count > 0 ? tags[0].name : "N/A";
                                    if (Session.Instance.laCEO)
                                    {
                                        int rowIndex = membersGrid.Rows.Add(
                                            ID,
                                            name,
                                            description,
                                            start,
                                            end,
                                            status,
                                            start,
                                            tag
                                        );
                                    }
                                    else
                                    {
                                        if (ID.Contains(Session.Instance.UserName.Split('-')[0]))
                                        {
                                            int rowIndex = membersGrid.Rows.Add(
                                                ID,
                                                name,
                                                description,
                                                start,
                                                end,
                                                status,
                                                start,
                                                tag
                                            );
                                        }
                                    }
                                }
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
            else
            {
                reload();
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

        private void seButton_Click(object sender, EventArgs e)
        {
            membersGrid.Rows.Clear();
            List<GiaoViec> members = giaoViecService.getTaskOfDeparment("AN");
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
            }
        }

        private void customButton18_Click(object sender, EventArgs e)
        {
            membersGrid.Rows.Clear();
            List<GiaoViec> members = giaoViecService.getAll();
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
            }
        }

        private void maButton_Click(object sender, EventArgs e)
        {
            membersGrid.Rows.Clear();
            List<GiaoViec> members = giaoViecService.getTaskOfDeparment("KT");
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
            }
        }

        private void coButton_Click(object sender, EventArgs e)
        {
            membersGrid.Rows.Clear();
            List<GiaoViec> members = giaoViecService.getTaskOfDeparment("XD");
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
            }
        }

        private void fiButton_Click(object sender, EventArgs e)
        {
            membersGrid.Rows.Clear();
            List<GiaoViec> members = giaoViecService.getTaskOfDeparment("TC");
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
            }
        }

        private void saButton_Click(object sender, EventArgs e)
        {
            membersGrid.Rows.Clear();
            List<GiaoViec> members = giaoViecService.getTaskOfDeparment("VS");
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
            }
        }

        private void membersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == membersGrid.Columns["lnkColumn"].Index && e.RowIndex >= 0)
            {
                string id = membersGrid.Rows[e.RowIndex].Cells["MaGiaoViec"].Value.ToString();
                giaoViecService.downloadAttachedFile(id);
            }
        }

        private void customButton19_Click(object sender, EventArgs e)
        {
            if (Session.Instance.laCEO)
            {
                C_AssignTask cassignTask = new C_AssignTask();
                cassignTask.ShowDialog();
            }
            else
            {
                M_AssignTask massignTask = new M_AssignTask();
                massignTask.ShowDialog();
            }
        }

        private void currentAvatarButton_Click(object sender, EventArgs e) { }

        private void customButton7_Click(object sender, EventArgs e)
        {
            C_AccountManagement managements = new C_AccountManagement();
            managements.ShowDialog();
        }

        private void tasksQuantity_Click(object sender, EventArgs e) { }

        private void completedQuantity_Click(object sender, EventArgs e) { }

        private void timer_Tick(object sender, EventArgs e)
        {
            currentTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void weatherTempurature_Click(object sender, EventArgs e) { }

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

        private void customButton15_Click(object sender, EventArgs e)
        {
            reload();
            PerformSearch();
        }

        private void currentAvatarBig_Click(object sender, EventArgs e)
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

        private void C_AllTaskList_Shown(object sender, EventArgs e) { }

        private void createGroupButton_Click(object sender, EventArgs e)
        {
            CM_CreateGroup createGroup = new CM_CreateGroup();
            createGroup.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            PerformSearch();
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

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void customButton16_Click(object sender, EventArgs e)
        {
            A_MyTaskList editTask = new A_MyTaskList();
            editTask.ShowDialog();
        }

        private void changeLanguage()
        {
            Font font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            Font fontLarge = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            if (Session.Instance.Language == "vi")
            {
                customButton13.Text = "CÔNG VIỆC";
                customButton8.Text = "THỐNG KÊ";
                customButton9.Text = "BÁO CÁO";
                customButton7.Text = "QUẢN LÝ TÀI KHOẢN";
                customButton6.Text = "CƯ DÂN VÀ CĂN HỘ";
                customButton17.Text = "TẤT CẢ CÔNG VIỆC";
                customButton16.Text = "CÔNG VIỆC CỦA TÔI";
                createGroupButton.Text = "TẠO NHÓM";
                grandChart.Text = "BIỂU ĐỒ";
                label7.Text = "TỔNG QUAN NHIỆM VỤ";
                label6.Text = "TẤT CẢ CÔNG VIỆC";
                label10.Text = "ĐÃ HOÀN THÀNH";
                label12.Text = "CHƯA HOÀN THÀNH";
                customButton19.Text = "THÊM VIỆC";
                customButton18.Text = "CẢ CÔNG TY";
                hrButton.Text = "NHÂN SỰ";
                coButton.Text = "XÂY DỰNG";
                seButton.Text = "AN NINH";
                maButton.Text = "BẢO TRÌ";
                saButton.Text = "VỆ SINH";
                fiButton.Text = "TÀI CHÍNH KẾ TOÁN";
                font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                customButton13.Font = font;
                customButton8.Font = font;
                customButton9.Font = font;
                customButton7.Font = font;
                customButton6.Font = font;
                customButton17.Font = font;
                customButton16.Font = font;
                createGroupButton.Font = font;
                grandChart.Font = font;
                label7.Font = font;
                label6.Font = font;
                label10.Font = font;
                label12.Font = font;
                customButton19.Font = font;
                customButton18.Font = font;
                hrButton.Font = font;
                coButton.Font = font;
                seButton.Font = font;
                maButton.Font = font;
                saButton.Font = font;
                fiButton.Font = font;
            }
            else
            {
                customButton13.Text = "WORK";
                customButton8.Text = "STATISTIC";
                customButton9.Text = "REPORT";
                customButton7.Text = "ACCOUNT MANAGEMENT";
                customButton6.Text = "DEPARTMENT RESIDENT";
                customButton17.Text = "ALL TASK LIST";
                customButton16.Text = "MY TASK LIST";
                createGroupButton.Text = "CREATE GROUP";
                grandChart.Text = "GRAND CHART";
                label7.Text = "DashBoard Overview";
                label6.Text = "TOTAL TASKS";
                label10.Text = "COMPLETED";
                label12.Text = "NOT COMPLETED";
                customButton19.Text = "ADD TASK";
                customButton18.Text = "ALL COMPANY";
                hrButton.Text = "HR & RS";
                coButton.Text = "CONSTRUCTION";
                seButton.Text = "SECURITY";
                maButton.Text = "MAINTAINANCE";
                saButton.Text = "SANTINATION";
                fiButton.Text = "FINANCIAL ACCOUNTING";
                font = new Font("Copperplate Gothic Bold", 12);
            }
            customButton13.Font = font;
            customButton8.Font = font;
            customButton9.Font = font;
            customButton7.Font = font;
            customButton6.Font = font;
            customButton17.Font = font;
            customButton16.Font = font;
            createGroupButton.Font = font;
            grandChart.Font = font;
            label7.Font = font;
            label6.Font = font;
            label10.Font = font;
            label12.Font = font;
            customButton19.Font = font;
            customButton18.Font = font;
            hrButton.Font = font;
            coButton.Font = font;
            seButton.Font = font;
            maButton.Font = font;
            saButton.Font = font;
            fiButton.Font = font;
            // Special button
            customButton17.Font = fontLarge;
            customButton16.Font = fontLarge;
            createGroupButton.Font = fontLarge;
            grandChart.Font = fontLarge;
        }

        private void languageSelect_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            Font font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            Font fontLarge = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            if (languageSelect.SelectedItem.ToString() == "Vietnamese" || languageSelect.SelectedItem.ToString() == "VIETNAMESE")
            {
                Session.Instance.Language = "vi";
                customButton13.Text = "CÔNG VIỆC";
                customButton8.Text = "THỐNG KÊ";
                customButton9.Text = "BÁO CÁO";
                customButton7.Text = "QUẢN LÝ TÀI KHOẢN";
                customButton6.Text = "CƯ DÂN VÀ CĂN HỘ";
                customButton17.Text = "TẤT CẢ CÔNG VIỆC";
                customButton16.Text = "CÔNG VIỆC CỦA TÔI";
                createGroupButton.Text = "TẠO NHÓM";
                grandChart.Text = "BIỂU ĐỒ";
                label7.Text = "TỔNG QUAN NHIỆM VỤ";
                label6.Text = "TẤT CẢ CÔNG VIỆC";
                label10.Text = "ĐÃ HOÀN THÀNH";
                label12.Text = "CHƯA HOÀN THÀNH";
                customButton19.Text = "THÊM VIỆC";
                customButton18.Text = "CẢ CÔNG TY";
                hrButton.Text = "NHÂN SỰ";
                coButton.Text = "XÂY DỰNG";
                seButton.Text = "AN NINH";
                maButton.Text = "BẢO TRÌ";
                saButton.Text = "VỆ SINH";
                fiButton.Text = "TÀI CHÍNH KẾ TOÁN";
                font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                customButton13.Font = font;
                customButton8.Font = font;
                customButton9.Font = font;
                customButton7.Font = font;
                customButton6.Font = font;
                customButton17.Font = font;
                customButton16.Font = font;
                createGroupButton.Font = font;
                grandChart.Font = font;
                label7.Font = font;
                label6.Font = font;
                label10.Font = font;
                label12.Font = font;
                customButton19.Font = font;
                customButton18.Font = font;
                hrButton.Font = font;
                coButton.Font = font;
                seButton.Font = font;
                maButton.Font = font;
                saButton.Font = font;
                fiButton.Font = font;
            }
            else
            {
                Session.Instance.Language = "en";
                customButton13.Text = "WORK";
                customButton8.Text = "STATISTIC";
                customButton9.Text = "REPORT";
                customButton7.Text = "ACCOUNT MANAGEMENT";
                customButton6.Text = "DEPARTMENT RESIDENT";
                customButton17.Text = "ALL TASK LIST";
                customButton16.Text = "MY TASK LIST";
                createGroupButton.Text = "CREATE GROUP";
                grandChart.Text = "GRAND CHART";
                label7.Text = "DashBoard Overview";
                label6.Text = "TOTAL TASKS";
                label10.Text = "COMPLETED";
                label12.Text = "NOT COMPLETED";
                customButton19.Text = "ADD TASK";
                customButton18.Text = "ALL COMPANY";
                hrButton.Text = "HR & RS";
                coButton.Text = "CONSTRUCTION";
                seButton.Text = "SECURITY";
                maButton.Text = "MAINTAINANCE";
                saButton.Text = "SANTINATION";
                fiButton.Text = "FINANCIAL ACCOUNTING";
                font = new Font("Copperplate Gothic Bold", 10);
                fontLarge = new Font("Copperplate Gothic Bold", 12);
            }
            customButton13.Font = font;
            customButton8.Font = font;
            customButton9.Font = font;
            customButton7.Font = font;
            customButton6.Font = font;
            customButton17.Font = font;
            customButton16.Font = font;
            createGroupButton.Font = font;
            grandChart.Font = font;
            label7.Font = font;
            label6.Font = font;
            label10.Font = font;
            label12.Font = font;
            customButton19.Font = font;
            customButton18.Font = font;
            hrButton.Font = font;
            coButton.Font = font;
            seButton.Font = font;
            maButton.Font = font;
            saButton.Font = font;
            fiButton.Font = font;
            // Special button
            customButton17.Font = fontLarge;
            customButton16.Font = fontLarge;
            createGroupButton.Font = fontLarge;
            grandChart.Font = fontLarge;

        }

        private void customButton13_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void customButton6_Click(object sender, EventArgs e)
        {
            CM_Resident_sDetail cM = new CM_Resident_sDetail();
            cM.ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
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

        private void grandChart_Click(object sender, EventArgs e)
        {
            A_Statistic a_Statistic = new A_Statistic();
            a_Statistic.ShowDialog();
        }

        private void membersGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != membersGrid.Columns["lnkColumn"].Index && e.RowIndex >= 0)
            {
                string id = membersGrid.Rows[e.RowIndex].Cells["MaGiaoViec"].Value.ToString();
                A_TaskDetail a_TaskDetail = new A_TaskDetail(id);
                a_TaskDetail.ShowDialog();
            }
        }

        private void customButton8_Click(object sender, EventArgs e)
        {
            A_Statistic a_Statistic = new A_Statistic();
            a_Statistic.ShowDialog();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
