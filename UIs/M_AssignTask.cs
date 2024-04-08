using Repositories.Utilities;
using Services;
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

namespace UIs
{
    public partial class M_AssignTask : Form
    {
        private string receiverID = "";
        private string venueID = "";
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
            Rectangle rectTopRight = new Rectangle(userPanel.Width - diameter, 0, diameter, diameter);
            Rectangle rectBottomLeft = new Rectangle(0, userPanel.Height - diameter, diameter, diameter);
            Rectangle rectBottomRight = new Rectangle(userPanel.Width - diameter, userPanel.Height - diameter, diameter, diameter);

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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void customButton1_Click(object sender, EventArgs e)
        {

        }

        private void customButton2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

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


        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void M_AssignTask_Load(object sender, EventArgs e)
        {
            taskStatus.SelectedIndex = 0;
            taskPriority.SelectedIndex = 0;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            GiaoViecService giaoViecService = new GiaoViecService();
            NhanSuService nhanSuService = new NhanSuService();
            string tStaffName = nhanSuService.findMember(receiverID).HoVaTen;
            string tManagerName = nhanSuService.findMember("AN-402").HoVaTen;
            string tManagerID = "AN-402";
            string tID = GiaoViecUtilities.createAssignTaskID(tManagerID);
            string tName = taskName.Text;
            string tDescription = taskDescription.Text;
            string tStart = taskStart.Value.ToString("yyyyMMdd");
            string tEnd = taskEnd.Value.ToString("yyyyMMdd");
            string tFile = taskFile.Text;
            string tStatus = taskStatus.SelectedItem.ToString();
            string tPriority = taskPriority.SelectedItem.ToString();
            string tSubject = $"THÔNG BÁO GIAO VIỆC - {tName}";
            string tGiaoViec = $"Kính gửi {tStaffName},\nChúng ta đã xác định một công việc mới cần hoàn thành, và tôi muốn giao nhiệm vụ này cho bạn. Dưới đây là thông tin chi tiết về công việc:\nTên công việc: {tName}\nMô tả: {tDescription}\nThời hạn: {tEnd}\nƯu tiên: {tPriority}\nNgười giao việc: {tManagerName}\nXin vui lòng kiểm tra thông tin trên và bắt đầu làm việc ngay khi bạn có thể. Nếu bạn có bất kỳ câu hỏi hoặc cần hỗ trợ nào, đừng ngần ngại liên hệ với tôi.\nCảm ơn bạn đã đảm nhận nhiệm vụ này.\nTrân trọng,\nQuản lý {tManagerName}";
            string tTo = nhanSuService.findMember(receiverID).Email;

            int tMode = taskMode.Checked ? 1 : 0;
            int tIsCEO = 0;

            bool isSuccess = giaoViecService.assignTask(tDescription, tStart, tEnd, tStatus, tFile, tID, tMode, tName, venueID, receiverID, tIsCEO, tManagerID);

            if (isSuccess)
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
                MessageBox.Show("Assign task successfully!");
            }
            else
            {
                MessageBox.Show(tID);
                MessageBox.Show(tStart);
                MessageBox.Show(tEnd);
                MessageBox.Show(tName);
                MessageBox.Show(tDescription);
                MessageBox.Show(tFile);
                MessageBox.Show(tStatus);
                MessageBox.Show(tPriority);
                MessageBox.Show(tMode.ToString());
                MessageBox.Show(receiverID);
                MessageBox.Show(venueID);
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

        private void label13_Click(object sender, EventArgs e)
        {

        }

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

        private void customButton8_Click(object sender, EventArgs e)
        {

        }
    }
}
