using Repositories.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIs
{
    public partial class A_MyTaskList : Form
    {
        GiaoViecService giaoViecService = new GiaoViecService();
        NhanViecService nhanViecService = new NhanViecService();
        KhuVucLamViecService khuVucLamViecService = new KhuVucLamViecService();
        TagService tagService = new TagService();
        private string selectedTaskID = "";
        public A_MyTaskList()
        {
            InitializeComponent();
        }

        private void currentUserName_Click(object sender, EventArgs e)
        {

        }

        private void customButton3_Click(object sender, EventArgs e)
        {
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void A_EditTask_Load(object sender, EventArgs e)
        {
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
                A_EditTask editTask = new A_EditTask(task.MoTaCongViec, task.NgayGiao, task.HanHoanThanh, task.TinhTrangCongViec, isValidFile, task.MaGiaoViec, task.CheDo == true ? 1 : 0, task.TenCongViec, venue, implementor, Session.Instance.laCEO == true ? 1 : 0, Session.Instance.UserName, task.UyQuyenBoi, tag.Count != 0 ? tag[0].name : "N/A");
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
    }
}
