using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repositories.Entities;
using Repositories.Utilities;
using Services;

namespace UIs
{
    public partial class M_AssignTask : Form
    {
        GiaoViecService giaoViecService = new GiaoViecService();
        NhanSuService nhanSuService = new NhanSuService();
        TagService tagService = new TagService();
        private string receiverID = "";
        private string venueID = "";
        private string authorizedBy = "";
        private string tagName = "";
        private string sharedDepartment = "";

        public M_AssignTask()
        {
            InitializeComponent();
        }

        private void userPanel_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 30;
            int diameter = radius * 2;

            Rectangle rectTopLeft = new Rectangle(0, 0, diameter, diameter);
            Rectangle rectTopRight = new Rectangle(
                userPanel.Width - diameter,
                0,
                diameter,
                diameter
            );
            Rectangle rectBottomLeft = new Rectangle(
                0,
                userPanel.Height - diameter,
                diameter,
                diameter
            );
            Rectangle rectBottomRight = new Rectangle(
                userPanel.Width - diameter,
                userPanel.Height - diameter,
                diameter,
                diameter
            );

            // Vẽ góc trên bên trái
            path.AddArc(rectTopLeft, 180, 90);
            // Vẽ đoạn thẳng ở trên
            path.AddLine(radius, 0, userPanel.Width - radius, 0);
            // Vẽ góc trên bên phải
            path.AddArc(rectTopRight, 270, 90);
            // Vẽ đoạn thẳng ở phải
            path.AddLine(userPanel.Width, radius, userPanel.Width, userPanel.Height - radius);
            // Vẽ góc dưới bên phải
            path.AddArc(rectBottomRight, 0, 90);
            // Vẽ đoạn thẳng ở dưới
            path.AddLine(userPanel.Width - radius, userPanel.Height, radius, userPanel.Height);
            // Vẽ góc dưới bên trái
            path.AddArc(rectBottomLeft, 90, 90);
            // Vẽ đoạn thẳng ở trái
            path.AddLine(0, userPanel.Height - radius, 0, radius);
            // Kết thúc
            path.CloseFigure();

            userPanel.Region = new Region(path);
        }

        private void label10_Click(object sender, EventArgs e) { }

        private void label12_Click(object sender, EventArgs e) { }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }

        private void customButton1_Click(object sender, EventArgs e) { }

        private void customButton2_Click(object sender, EventArgs e) { }

        private void pictureBox14_Click(object sender, EventArgs e) { }

        private void editReceiverButton_Click(object sender, EventArgs e)
        {
            A_ShowStaff showStaffsForm = new A_ShowStaff();
            showStaffsForm.StaffSelected += ShowStaffsForm_StaffSelected;
            showStaffsForm.ShowDialog();
        }

        private void ShowStaffsForm_StaffSelected(string memberId)
        {
            receiverLabel.Text = memberId;
            receiverID = memberId;
        }

        private void label11_Click(object sender, EventArgs e) { }

        private void M_AssignTask_Load(object sender, EventArgs e)
        {
            assignerLabel.Text = Session.Instance.UserName;
            taskStatus.SelectedIndex = 0;
            taskPriority.SelectedIndex = 0;
            if (Session.Instance.laQuanLi)
            {
                membersGrid.Enabled = false;
                membersGrid.Visible = false;
            }
            else if (!Session.Instance.laQuanLi && !Session.Instance.laCEO)
            {
                membersGrid.Enabled = true;
                membersGrid.Columns.Add("ID", "ID");
                membersGrid.Columns.Add("Name", "Name");
                membersGrid.Columns.Add("Role", "Role");
                List<NhanSu> members = nhanSuService.getAllMembers();
                foreach (NhanSu member in members)
                {
                    if (member.LaQuanLi || member.MaThanhVien.Contains("GD"))
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(membersGrid);
                        row.Cells[0].Value = member.MaThanhVien;
                        row.Cells[1].Value = member.HoVaTen;
                        row.Cells[2].Value = member.LaQuanLi ? "Manager" : "CEO";

                        membersGrid.Rows.Add(row);
                    }
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string tStaffName = nhanSuService.findMember(receiverID).HoVaTen;
            string tManagerName = nhanSuService.findMember(Session.Instance.UserName).HoVaTen;
            string tManagerID = Session.Instance.UserName;
            string tID = GiaoViecUtilities.createAssignTaskID(tManagerID);
            string tName = taskName.Text;
            string tDescription = taskDescription.Text;
            string tStart = taskStart.Value.ToString("yyyyMMdd");
            string tEnd = taskEnd.Value.ToString("yyyyMMdd");
            string tFile = taskFile.Text;
            string tStatus = taskStatus.SelectedItem.ToString();
            string tPriority = taskPriority.SelectedItem.ToString();
            string tSubject = $"THÔNG BÁO GIAO VIỆC - {tName}";
            string tGiaoViec =
                $"Kính gửi {tStaffName},\nChúng ta đã xác định một công việc mới cần hoàn thành, và tôi muốn giao nhiệm vụ này cho bạn. Dưới đây là thông tin chi tiết về công việc:\nTên công việc: {tName}\nMô tả: {tDescription}\nThời hạn: {tEnd}\nƯu tiên: {tPriority}\nNgười giao việc: {tManagerName}\nXin vui lòng kiểm tra thông tin trên và bắt đầu làm việc ngay khi bạn có thể. Nếu bạn có bất kỳ câu hỏi hoặc cần hỗ trợ nào, đừng ngần ngại liên hệ với tôi.\nCảm ơn bạn đã đảm nhận nhiệm vụ này.\nTrân trọng,\nQuản lý {tManagerName}";
            string tTo = nhanSuService.findMember(receiverID).Email;

            int tMode = taskMode.Checked ? 1 : 0;
            int tIsCEO = 0;
            int intime = 1;
            string sharedDepartment = selectDepartment.Text;

            bool isSuccess = giaoViecService.assignTask(
                tDescription,
                tStart,
                tEnd,
                tStatus,
                tFile,
                tID,
                tMode,
                tName,
                venueID,
                receiverID,
                tIsCEO,
                tManagerID,
                authorizedBy,
                intime,
                sharedDepartment
            );

            bool isTagAdded = tagService.addTag(tagName, tID, "");

            if (isSuccess && isTagAdded)
            {
                MailService mailService = new MailService();
                mailService.sendMail(tSubject, tGiaoViec, tTo);
                taskName.Text = "";
                taskDescription.Text = "";
                taskStart.Value = DateTime.Now;
                taskEnd.Value = DateTime.Now;
                taskFile.Text = "";
                taskStatus.SelectedIndex = 0;
                taskPriority.SelectedIndex = 0;
                taskMode.Checked = false;
                receiverLabel.Text = "";
                venueLabel.Text = "";
                tagNameBox.Text = "";
                MessageBox.Show("Assign task successfully!");
            }
            else
            {
                MessageBox.Show($"EXEC taoViec '{tDescription}', '{tStart}', '{tEnd}', '{tStatus}', '{tFile}', '{tID}', '{tMode}', '{tName}', '{venueID}', '{receiverID}', '{tIsCEO}', '{tManagerID}', '{authorizedBy}'");
            }
        }

        private void venueEditButton_Click(object sender, EventArgs e)
        {
            A_ShowVenue showVenueForm = new A_ShowVenue();
            showVenueForm.VenueSelected += ShowVenueForm_VenueSelected;
            showVenueForm.ShowDialog();
        }

        private void ShowVenueForm_VenueSelected(string venueId)
        {
            venueLabel.Text = venueId;
            venueID = venueId;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowDepartmentForm_DepartmentSelected(string department)
        {
            selectDepartment.Text = department;
            sharedDepartment = department;
        }

        private void label13_Click(object sender, EventArgs e) { }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fDialog = new OpenFileDialog();
            fDialog.Title = "Select file to be upload";
            //fDialog.Filter = "PDF Files|*.pdf|All Files|*.*";
            fDialog.Filter = "PDF Files|*.pdf";
            if (fDialog.ShowDialog() == DialogResult.OK)
            {
                taskFile.Text = fDialog.FileName.ToString();
            }
        }

        private void customButton8_Click(object sender, EventArgs e) { }

        private void membersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = membersGrid.Rows[e.RowIndex];
                authorizedBy = selectedRow.Cells["ID"].Value.ToString();
            }
        }

        private void tagEditButton_Click(object sender, EventArgs e)
        {
            A_ShowTag showTagForm = new A_ShowTag();
            showTagForm.TagSelected += ShowTagForm_TagSelected;
            showTagForm.ShowDialog();
        }

        private void ShowTagForm_TagSelected(string tag)
        {
            tagNameBox.Text = tag;
            tagName = tag;
        }

        private void customButton13_Click(object sender, EventArgs e)
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

        private void customButton14_Click(object sender, EventArgs e)
        {
            if (tableLayoutPanel3.Visible == false)
            {
                tableLayoutPanel3.Visible = true;
            }
            else
            {
                tableLayoutPanel3.Visible = false;
            }
        }

<<<<<<< HEAD
        private void departmentMode_CheckedChanged(object sender, EventArgs e)
        {
            if (departmentMode.Checked)
            {
                A_ShowDepartment showDepartmentForm = new A_ShowDepartment();
                showDepartmentForm.DepartmentSelected += ShowDepartmentForm_DepartmentSelected;
                showDepartmentForm.ShowDialog();
            }
        }
=======
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

        private void label29_Click(object sender, EventArgs e)
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

        private void label28_Click(object sender, EventArgs e)
        {
            G_ForgotPassword g_ForgotPassword = new G_ForgotPassword();
        }

        private void label27_Click(object sender, EventArgs e)
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
>>>>>>> f3f8f59c861b70670f26a885a3f5d45b3b532f58
    }
}
