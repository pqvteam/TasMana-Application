using Microsoft.Data.SqlClient;
using Repositories.Utilities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIs.CustomComponent;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace UIs
{
    public partial class C_AssignTask : Form
    {
        TagService tagService = new TagService();
        private string receiverID = "";
        private string venueID = "";
        private string tagName = "";
        SqlConnection sqlcon = new SqlConnection(@"Data Source=LAPTOP-SM9GFST3\SQLEXPRESS;Initial Catalog=TasMana;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        SqlCommand sqlcmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public C_AssignTask()
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
            A_ShowMember showMembersForm = new A_ShowMember();
            showMembersForm.MemberSelected += ShowMembersForm_MemberSelected;
            showMembersForm.ShowDialog();
        }

        private void ShowMembersForm_MemberSelected(string memberId)
        {
            receiverLabel.Text = memberId;
            receiverID = memberId;
        }


        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void C_AssignTask_Load(object sender, EventArgs e)
        {
            taskName.Focus();
            assignerLabel.Text = Session.Instance.UserName;
            if (IsValidImageData(Session.Instance.Avatar))
            {
                currentAvatarSmall.Image = convertByteToImage(Session.Instance.Avatar);
            }
            changelanguage();
            languageSelect.SelectedItem = Session.Instance.Language == "en" ? "ENGLISH" : "VIETNAMESE";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            GiaoViecService giaoViecService = new GiaoViecService();
            NhanSuService nhanSuService = new NhanSuService();
            string tCEOID = Session.Instance.UserName;
            string tCEOName = nhanSuService.findMember(tCEOID).HoVaTen;
            string tReceiverName = nhanSuService.findMember(receiverID).HoVaTen;
            string tID = GiaoViecUtilities.createAssignTaskID(tCEOID);
            string tName = taskName.Text;
            string tDescription = taskDescription.Text;
            string tStart = taskStart.Value.ToString("yyyyMMdd");
            string tEnd = taskEnd.Value.ToString("yyyyMMdd");
            string tFile = taskFile.Text;
            string tStatus = taskStatus.SelectedItem.ToString();
            string tPriority = taskPriority.SelectedItem.ToString();
            string tSubject = $"THÔNG BÁO GIAO VIỆC - {tName}";
            string tGiaoViec = $"Kính gửi {tReceiverName},\nChúng ta đã xác định một công việc mới cần hoàn thành, và tôi muốn giao nhiệm vụ này cho bạn. Dưới đây là thông tin chi tiết về công việc:\nTên công việc: {tName}\nMô tả: {tDescription}\nThời hạn: {tEnd}\nƯu tiên: {tPriority}\nNgười giao việc: {tCEOName}\nXin vui lòng kiểm tra thông tin trên và bắt đầu làm việc ngay khi bạn có thể. Nếu bạn có bất kỳ câu hỏi hoặc cần hỗ trợ nào, đừng ngần ngại liên hệ với tôi.\nCảm ơn bạn đã đảm nhận nhiệm vụ này.\nTrân trọng,\nCEO {tCEOName}";
            string tTo = nhanSuService.findMember(receiverID).Email;

            int tMode = taskMode.Checked ? 1 : 0;
            // Create new form here
            string tSharedDepartment = selectDepartment.Text;
            int tIsCEO = 1;

            bool isSuccess = giaoViecService.assignTask(tDescription, tStart, tEnd, tStatus, tFile, tID, tMode, tName, venueID, receiverID, tIsCEO, tCEOID, "", 0, tSharedDepartment);
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

        private void customButton7_Click(object sender, EventArgs e)
        {
            C_AllTaskList c_AllTaskList = new C_AllTaskList();
            c_AllTaskList.ShowDialog();
        }

        private async void uploadButton_Click(object sender, EventArgs e)
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

        private void customButton19_Click(object sender, EventArgs e)
        {
            string filetype;
            string filename;

            filetype = taskFile.Text.Substring(Convert.ToInt32(taskFile.Text.LastIndexOf(".")) + 1, taskFile.Text.Length - (Convert.ToInt32(taskFile.Text.LastIndexOf(".")) + 1));

            if (filetype.ToUpper() != "PDF")
            {
                MessageBox.Show("Upload Only PDF Files");
                return;
            }

            byte[] FileBytes = null;

            try
            {
                // Open file to read using file path
                FileStream FS = new FileStream(taskFile.Text, System.IO.FileMode.Open, System.IO.FileAccess.Read);

                // Add filestream to binary reader
                BinaryReader BR = new BinaryReader(FS);

                // get total byte length of the file
                long allbytes = new FileInfo(taskFile.Text).Length;

                // read entire file into buffer
                FileBytes = BR.ReadBytes((Int32)allbytes);

                // close all instances
                FS.Close();
                FS.Dispose();
                BR.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during File Read " + ex.ToString());
            }

            sqlcon.Open();
            SqlCommand sqlcmd = new SqlCommand("update GiaoViec set dinhKemFile = @FB where maGiaoViec = 'KT-501.002'", sqlcon);
            sqlcmd.Parameters.AddWithValue("@FB", FileBytes);
            sqlcmd.ExecuteNonQuery();
            sqlcon.Close();
            //LoadGrid();
            MessageBox.Show("Upload file successfully!");
        }

        private void RemoveDefaultTabOrder(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                control.TabStop = false; // Set TabStop to false
                if (control.HasChildren) // If control has children, recursively call RemoveDefaultTabOrder
                {
                    RemoveDefaultTabOrder(control.Controls);
                }
            }
        }

        private void currentFileGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string id;
                FileStream FS = null;
                byte[] dbbyte;

                sqlcon.Open();
                sqlcmd = new SqlCommand("select dinhKemFile from GiaoViec where maGiaoViec = 'KT-501.002'", sqlcon);
                da = new SqlDataAdapter(sqlcmd);
                dt = new DataTable();
                da.Fill(dt);
                sqlcon.Close();


                if (dt.Rows.Count > 0)
                {
                    dbbyte = (byte[])dt.Rows[0]["dinhKemFile"];

                    string filepath = "D:\\temp.pdf";

                    File.WriteAllBytes(filepath, dbbyte);

                    Process.Start("explorer", filepath);
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

        private void customButton22_Click(object sender, EventArgs e)
        {
            if (tableLayoutPanel6.Visible == false)
            {
                tableLayoutPanel6.Visible = true;
            }
            else
            {
                tableLayoutPanel6.Visible = false;
            }
        }

        private void headerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tagEditButton_Click(object sender, EventArgs e)
        {
            A_ShowTag showTagForm = new A_ShowTag();
            showTagForm.TagSelected += ShowTagForm_TagSelected;
            showTagForm.ShowDialog();
        }
        private void ShowDepartmentForm_DepartmentSelected(string department)
        {
            selectDepartment.Text = department;
        }

        private void ShowTagForm_TagSelected(string tag)
        {
            tagNameBox.Text = tag;
            tagName = tag;
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

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        public void changelanguage()
        {
            Font font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            Font fontLarger = new Font("Copperplate Gothic Bold", 12);
            Font fontSmaller = new Font("Copperplate Gothic Bold", 9);
            if (Session.Instance.Language == "vi")
            {
                customButton7.Text = "CÔNG VIỆC";
                customButton8.Text = "THỐNG KÊ";
                customButton9.Text = "BÁO CÁO";
                customButton17.Text = "QUẢN LÝ TÀI KHOẢN";
                customButton18.Text = "CƯ DÂN VÀ CĂN HỘ";
                label34.Text = "THÔNG TIN";
                label33.Text = "ĐỔI MẬT KHẨU";
                label32.Text = "ĐĂNG XUẤT";
                label6.Text = "TÊN CÔNG VIỆC";
                label7.Text = "MÔ TẢ";
                label8.Text = "TỆP ĐÍNH KÈM";
                label9.Text = "NGÀY BẮT ĐẦU";
                label10.Text = "HẠN CHÓT";
                label11.Text = "TIẾN ĐỘ";
                label12.Text = "ĐỘ ƯU TIÊN";
                label19.Text = "LÀM NỔI BẬC";
                label16.Text = "TRUY CẬP CÔNG KHAI";
                label18.Text = "CÔNG TY";
                label17.Text = "BỘ PHẬN";
                editReceiverButton.Text = "SỬA";
                button1.Text = "SỬA";
                button2.Text = "SỬA";
                venueEditButton.Text = "SỬA";
                tagEditButton.Text = "SỬA";
                font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);


                customButton2.Text = "CẬP NHẬT TIẾN ĐỘ";
                customButton1.Text = "HẠN CHÓT";
                customButton5.Text = "ĐÍNH KÈM";
                customButton3.Text = "XÓA CÔNG VIỆC";
                label15.Text = "TRẠNG THÁI";
                label14.Text = "SỬA ĐỔI";
                name.Text = "NGƯỜI THỰC HIỆN";
                label1.Text = "ĐƯỢC GIAO BỞI";
                label2.Text = "CHIA SẺ TIẾN ĐỘ";
                label3.Text = "KHÁCH HÀNG";
                label4.Text = "NƠI LÀM VIỆC";
                label5.Text = "THẺ";
                tagNameBox.Text = "KIỂM TRA";
                fontLarger = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

                uploadButton.Text = "ĐĂNG";
                cancelButton.Text = "HỦY";
                saveButton.Text = "LƯU";
                fontSmaller = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);

                heading.Text = "CHI TIẾT CÔNG VIỆC";
                heading.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Bold);
            }
            else
            {
                customButton7.Text = "WORK";
                customButton8.Text = "STATISTIC";
                customButton9.Text = "REPORT";
                customButton17.Text = "ACCOUNTING MANAGEMENT";
                customButton18.Text = "APARTMENT RESIDENT";
                label34.Text = "INFORMATION";
                label33.Text = "CHANGE PASSWORD";
                label32.Text = "SIGN OUT";
                label6.Text = "TASK NAME";
                label7.Text = "DISCRIPTION";
                label8.Text = "ATTACHED FILES";
                label9.Text = "START";
                label10.Text = "DEADLINE";
                label11.Text = "PROCESS";
                label12.Text = "PRIORITY";
                label19.Text = "HIGHLIGHT";
                label16.Text = "PUBLIC ACCESS";
                label18.Text = "COMPANY";
                label17.Text = "DEPARTMENT";
                editReceiverButton.Text = "EDIT";
                button1.Text = "EDIT";
                button2.Text = "EDIT";
                venueEditButton.Text = "EDIT";
                tagEditButton.Text = "EDIT";
                font = new Font("Copperplate Gothic Bold", 10);

                customButton2.Text = "UPDATE PROCESS";
                customButton1.Text = "DEADLINE";
                customButton5.Text = "ATTACHMENT";
                customButton3.Text = "DELETE TASK";
                label15.Text = "STATUS";
                label14.Text = "MODIFYING";
                name.Text = "IMPLEMENTOR";
                label1.Text = "ASSIGNED BY";
                label2.Text = "SHARED PROCESS";
                label3.Text = "CUSTOMER";
                label4.Text = "WORKPLACE";
                label5.Text = "TAGS";
                tagNameBox.Text = "CHECKING";
                fontLarger = new Font("Copperplate Gothic Bold", 12);

                uploadButton.Text = "BROWSE";
                cancelButton.Text = "CANCEL";
                saveButton.Text = "SAVE";
                fontSmaller = new Font("Copperplate Gothic Bold", 9);

                heading.Text = "TASK DETAILS";
                heading.Font = new Font("Copperplate Gothic Bold", 18);
            }
            customButton7.Font = font;
            customButton8.Font = font;
            customButton9.Font = font;
            customButton17.Font = font;
            customButton18.Font = font;
            label34.Font = font;
            label33.Font = font;
            label32.Font = font;
            label6.Font = font;
            label7.Font = font;
            label8.Font = font;
            label9.Font = font;
            label10.Font = font;
            label11.Font = font;
            label12.Font = font;
            label19.Font = font;
            label16.Font = font;
            label18.Font = font;
            label17.Font = font;
            editReceiverButton.Font = font;
            button1.Font = font;
            button2.Font = font;
            venueEditButton.Font = font;
            tagEditButton.Font = font;

            customButton2.Font = fontLarger;
            customButton1.Font = fontLarger;
            customButton5.Font = fontLarger;
            customButton3.Font = fontLarger;
            label15.Font = fontLarger;
            label14.Font = fontLarger;
            name.Font = fontLarger;
            label1.Font = fontLarger;
            label2.Font = fontLarger;
            label3.Font = fontLarger;
            label4.Font = fontLarger;
            label5.Font = fontLarger;
            tagNameBox.Font = fontLarger;

            uploadButton.Font = fontSmaller;
            cancelButton.Font = fontSmaller;
            saveButton.Font = fontSmaller;
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
                label34.Text = "THÔNG TIN";
                label33.Text = "ĐỔI MẬT KHẨU";
                label32.Text = "ĐĂNG XUẤT";
                label6.Text = "TÊN CÔNG VIỆC";
                label7.Text = "MÔ TẢ";
                label8.Text = "TỆP ĐÍNH KÈM";
                label9.Text = "NGÀY BẮT ĐẦU";
                label10.Text = "HẠN CHÓT";
                label11.Text = "TIẾN ĐỘ";
                label12.Text = "ĐỘ ƯU TIÊN";
                label19.Text = "LÀM NỔI BẬC";
                label16.Text = "TRUY CẬP CÔNG KHAI";
                label18.Text = "CÔNG TY";
                label17.Text = "BỘ PHẬN";
                editReceiverButton.Text = "SỬA";
                button1.Text = "SỬA";
                button2.Text = "SỬA";
                venueEditButton.Text = "SỬA";
                tagEditButton.Text = "SỬA";
                font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);


                customButton2.Text = "CẬP NHẬT TIẾN ĐỘ";
                customButton1.Text = "HẠN CHÓT";
                customButton5.Text = "ĐÍNH KÈM";
                customButton3.Text = "XÓA CÔNG VIỆC";
                label15.Text = "TRẠNG THÁI";
                label14.Text = "SỬA ĐỔI";
                name.Text = "NGƯỜI THỰC HIỆN";
                label1.Text = "ĐƯỢC GIAO BỞI";
                label2.Text = "CHIA SẺ TIẾN ĐỘ";
                label3.Text = "KHÁCH HÀNG";
                label4.Text = "NƠI LÀM VIỆC";
                label5.Text = "THẺ";
                tagNameBox.Text = "KIỂM TRA";
                fontLarger = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

                uploadButton.Text = "ĐĂNG";
                cancelButton.Text = "HỦY";
                saveButton.Text = "LƯU";
                fontSmaller = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);

                heading.Text = "CHI TIẾT CÔNG VIỆC";
                heading.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Bold);
            }
            else
            {
                Session.Instance.Language = "en";
                customButton7.Text = "WORK";
                customButton8.Text = "STATISTIC";
                customButton9.Text = "REPORT";
                customButton17.Text = "ACCOUNTING MANAGEMENT";
                customButton18.Text = "APARTMENT RESIDENT";
                label34.Text = "INFORMATION";
                label33.Text = "CHANGE PASSWORD";
                label32.Text = "SIGN OUT";
                label6.Text = "TASK NAME";
                label7.Text = "DISCRIPTION";
                label8.Text = "ATTACHED FILES";
                label9.Text = "START";
                label10.Text = "DEADLINE";
                label11.Text = "PROCESS";
                label12.Text = "PRIORITY";
                label19.Text = "HIGHLIGHT";
                label16.Text = "PUBLIC ACCESS";
                label18.Text = "COMPANY";
                label17.Text = "DEPARTMENT";
                editReceiverButton.Text = "EDIT";
                button1.Text = "EDIT";
                button2.Text = "EDIT";
                venueEditButton.Text = "EDIT";
                tagEditButton.Text = "EDIT";
                font = new Font("Copperplate Gothic Bold", 10);

                customButton2.Text = "UPDATE PROCESS";
                customButton1.Text = "DEADLINE";
                customButton5.Text = "ATTACHMENT";
                customButton3.Text = "DELETE TASK";
                label15.Text = "STATUS";
                label14.Text = "MODIFYING";
                name.Text = "IMPLEMENTOR";
                label1.Text = "ASSIGNED BY";
                label2.Text = "SHARED PROCESS";
                label3.Text = "CUSTOMER";
                label4.Text = "WORKPLACE";
                label5.Text = "TAGS";
                tagNameBox.Text = "CHECKING";
                fontLarger = new Font("Copperplate Gothic Bold", 12);

                uploadButton.Text = "BROWSE";
                cancelButton.Text = "CANCEL";
                saveButton.Text = "SAVE";
                fontSmaller = new Font("Copperplate Gothic Bold", 9);

                heading.Text = "TASK DETAILS";
                heading.Font = new Font("Copperplate Gothic Bold", 18);
            }
            customButton7.Font = font;
            customButton8.Font = font;
            customButton9.Font = font;
            customButton17.Font = font;
            customButton18.Font = font;
            label34.Font = font;
            label33.Font = font;
            label32.Font = font;
            label6.Font = font;
            label7.Font = font;
            label8.Font = font;
            label9.Font = font;
            label10.Font = font;
            label11.Font = font;
            label12.Font = font;
            label19.Font = font;
            label16.Font = font;
            label18.Font = font;
            label17.Font = font;
            editReceiverButton.Font = font;
            button1.Font = font;
            button2.Font = font;
            venueEditButton.Font = font;
            tagEditButton.Font = font;

            customButton2.Font = fontLarger;
            customButton1.Font = fontLarger;
            customButton5.Font = fontLarger;
            customButton3.Font = fontLarger;
            label15.Font = fontLarger;
            label14.Font = fontLarger;
            name.Font = fontLarger;
            label1.Font = fontLarger;
            label2.Font = fontLarger;
            label3.Font = fontLarger;
            label4.Font = fontLarger;
            label5.Font = fontLarger;
            tagNameBox.Font = fontLarger;

            uploadButton.Font = fontSmaller;
            cancelButton.Font = fontSmaller;
            saveButton.Font = fontSmaller;
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

        private void label28_Click(object sender, EventArgs e)
        {
            G_ForgotPassword g_ForgotPassword = new G_ForgotPassword();
            g_ForgotPassword.ShowDialog();
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
        
        private void customButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void departmentMode_CheckedChanged(object sender, EventArgs e)
        {
            if (departmentMode.Checked)
            {
                A_ShowDepartment showDepartmentForm = new A_ShowDepartment();
                showDepartmentForm.DepartmentSelected += ShowDepartmentForm_DepartmentSelected;
                showDepartmentForm.ShowDialog();
            }
        }
    }
}
