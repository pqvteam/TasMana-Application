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
            GetWeather getWeather = new GetWeather();
            string[] currentWeather = getWeather.getWeatherData("Ho Chi Minh City");
            weatherType.Text = currentWeather[1];
            weatherTempurature.Text = currentWeather[2];
            weatherWindSpeed.Text = currentWeather[3];
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
            List<GiaoViec> members = giaoViecService.getAll();
            int taskQuantity = 0;
            int completedTaskQuantity = 0;
            int incompletedTaskQuantity = 0;
            foreach (GiaoViec member in members)
            {
                List < (string name, string ID, string description) > tag = tagService.getTaskTagInfo(member.MaGiaoViec);
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(membersGrid);
                row.Cells[0].Value = member.MaGiaoViec;
                row.Cells[1].Value = member.TenCongViec;
                row.Cells[2].Value = member.MoTaCongViec;
                row.Cells[3].Value = member.NgayGiao;
                row.Cells[4].Value = member.HanHoanThanh;
                row.Cells[5].Value = member.TinhTrangCongViec;
                row.Cells[6].Value = tag.Count >0 ? tag[0].name : "NA";
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
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(membersGrid);
                row.Cells[0].Value = member.MaGiaoViec;
                row.Cells[1].Value = member.TenCongViec;
                row.Cells[2].Value = member.MoTaCongViec;
                row.Cells[3].Value = member.NgayGiao;
                row.Cells[4].Value = member.HanHoanThanh;
                row.Cells[5].Value = member.TinhTrangCongViec;
                membersGrid.Rows.Add(row);
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
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(membersGrid);
                row.Cells[0].Value = member.MaGiaoViec;
                row.Cells[1].Value = member.TenCongViec;
                row.Cells[2].Value = member.MoTaCongViec;
                row.Cells[3].Value = member.NgayGiao;
                row.Cells[4].Value = member.HanHoanThanh;
                row.Cells[5].Value = member.TinhTrangCongViec;
                membersGrid.Rows.Add(row);
            }
        }

        private void customButton18_Click(object sender, EventArgs e)
        {
            membersGrid.Rows.Clear();
            List<GiaoViec> members = giaoViecService.getAll();
            foreach (GiaoViec member in members)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(membersGrid);
                row.Cells[0].Value = member.MaGiaoViec;
                row.Cells[1].Value = member.TenCongViec;
                row.Cells[2].Value = member.MoTaCongViec;
                row.Cells[3].Value = member.NgayGiao;
                row.Cells[4].Value = member.HanHoanThanh;
                row.Cells[5].Value = member.TinhTrangCongViec;
                membersGrid.Rows.Add(row);
            }
        }

        private void maButton_Click(object sender, EventArgs e)
        {
            membersGrid.Rows.Clear();
            List<GiaoViec> members = giaoViecService.getTaskOfDeparment("KT");
            foreach (GiaoViec member in members)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(membersGrid);
                row.Cells[0].Value = member.MaGiaoViec;
                row.Cells[1].Value = member.TenCongViec;
                row.Cells[2].Value = member.MoTaCongViec;
                row.Cells[3].Value = member.NgayGiao;
                row.Cells[4].Value = member.HanHoanThanh;
                row.Cells[5].Value = member.TinhTrangCongViec;
                membersGrid.Rows.Add(row);
            }
        }

        private void coButton_Click(object sender, EventArgs e)
        {
            membersGrid.Rows.Clear();
            List<GiaoViec> members = giaoViecService.getTaskOfDeparment("XD");
            foreach (GiaoViec member in members)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(membersGrid);
                row.Cells[0].Value = member.MaGiaoViec;
                row.Cells[1].Value = member.TenCongViec;
                row.Cells[2].Value = member.MoTaCongViec;
                row.Cells[3].Value = member.NgayGiao;
                row.Cells[4].Value = member.HanHoanThanh;
                row.Cells[5].Value = member.TinhTrangCongViec;
                membersGrid.Rows.Add(row);
            }
        }

        private void fiButton_Click(object sender, EventArgs e)
        {
            membersGrid.Rows.Clear();
            List<GiaoViec> members = giaoViecService.getTaskOfDeparment("TC");
            foreach (GiaoViec member in members)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(membersGrid);
                row.Cells[0].Value = member.MaGiaoViec;
                row.Cells[1].Value = member.TenCongViec;
                row.Cells[2].Value = member.MoTaCongViec;
                row.Cells[3].Value = member.NgayGiao;
                row.Cells[4].Value = member.HanHoanThanh;
                row.Cells[5].Value = member.TinhTrangCongViec;
                membersGrid.Rows.Add(row);
            }
        }

        private void saButton_Click(object sender, EventArgs e)
        {
            membersGrid.Rows.Clear();
            List<GiaoViec> members = giaoViecService.getTaskOfDeparment("VS");
            foreach (GiaoViec member in members)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(membersGrid);
                row.Cells[0].Value = member.MaGiaoViec;
                row.Cells[1].Value = member.TenCongViec;
                row.Cells[2].Value = member.MoTaCongViec;
                row.Cells[3].Value = member.NgayGiao;
                row.Cells[4].Value = member.HanHoanThanh;
                row.Cells[5].Value = member.TinhTrangCongViec;
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

        private void customButton15_Click(object sender, EventArgs e)
        {
            reload();
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

        }
        private void C_AllTaskList_Shown(object sender, EventArgs e)
        {
           
        }
    }
}
