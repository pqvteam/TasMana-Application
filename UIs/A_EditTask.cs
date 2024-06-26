﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Repositories.Entities;
using Repositories.Utilities;
using Services;
using UIs.CustomComponent;

namespace UIs
{
    public partial class A_EditTask : Form
    {
        GiaoViecService giaoViecService = new GiaoViecService();
        NhanSuService nhanSuService = new NhanSuService();
        CanHoService canHoService = new CanHoService();
        TagService tagService = new TagService();
        private string receiverID = "";
        private string venueID = "";
        private string authorizedBy = "";
        private string tagName = "";
        private string description;
        private DateOnly start;
        private DateOnly end;
        private string status;
        private bool file;
        private string ID;
        private int mode;
        private string jobName;
        private int isCEO;
        private string assignerID;
        private string oldImplementor;
        private int intime;
        private string sharedDepartment;

        public A_EditTask()
        {
            InitializeComponent();
        }

        public A_EditTask(
            string tDescription,
            DateOnly tStart,
            DateOnly tEnd,
            string tStatus,
            bool tFile,
            string tID,
            int tMode,
            string tName,
            string venueID,
            string receiverID,
            int tIsCEO,
            string tManagerID,
            string authorizedBy,
            string tTag,
            int tInTime,
            string tSharedDepartment
        )
        {
            InitializeComponent();
            this.description = tDescription;
            this.start = tStart;
            this.end = tEnd;
            this.status = tStatus;
            this.file = tFile;
            this.ID = tID;
            this.mode = tMode;
            this.jobName = tName;
            this.venueID = venueID;
            this.receiverID = receiverID;
            this.isCEO = tIsCEO;
            this.assignerID = tManagerID;
            this.authorizedBy = authorizedBy;
            this.tagName = tTag;
            this.oldImplementor = receiverID;
            this.intime = tInTime;
            this.sharedDepartment = tSharedDepartment;
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
            changeLanguage();
            languageSelect.SelectedItem = Session.Instance.Language == "en" ? "ENGLISH" : "VIETNAMESE";
            selectDepartment.Text = sharedDepartment;
            sharedProcess.Text = sharedDepartment;
            string? customerID = canHoService.findApartment(venueID).MaCuDan;
            if (customerID != null)
            {
                customerLabel.Text = customerID;
            }

            ////
            taskStatus.SelectedItem = this.status;
            taskPriority.SelectedIndex = 0;
            nameBox.Text = this.jobName;
            taskDescription.Text = this.description;

            taskStart.Value = new DateTime(
                Convert.ToInt32(this.start.ToString().Split('/')[2]),
                Convert.ToInt32(this.start.ToString().Split('/')[0]),
                Convert.ToInt32(this.start.ToString().Split('/')[1])
            );
            taskEnd.Value = new DateTime(
                Convert.ToInt32(this.end.ToString().Split('/')[2]),
                Convert.ToInt32(this.end.ToString().Split('/')[0]),
                Convert.ToInt32(this.end.ToString().Split('/')[1])
            );
            receiverLabel.Text = this.receiverID;
            assignerLabel.Text = this.assignerID;
            if (this.isCEO == 1)
            {
                authorizeLabel.Visible = false;
                authorizeIcon.Visible = false;
                membersGrid.Visible = false;
            }
            if (!this.file)
            {
                currentFile.Visible = false;
            }
            venueLabel.Text = this.venueID;
            tagNameBox.Text = this.tagName;
            if (this.mode == 1)
            {
                taskMode.Checked = true;
            }
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
            if (receiverID == "")
            {
                ToastForm toastForm = new ToastForm("WARNING", "Please select implementor!");
                toastForm.ShowDialog();
                return;
            }
            if (venueID == "")
            {
                ToastForm toastForm = new ToastForm("WARNING", "Please select workplace!");
                toastForm.ShowDialog();
                return;
            }
            if (tagName == "")
            {
                ToastForm toastForm = new ToastForm("WARNING", "Please select a tag name!");
                toastForm.ShowDialog();
                return;
            }
            string tStaffName = nhanSuService.findMember(receiverID).HoVaTen;
            string tOldStaffName = nhanSuService.findMember(receiverID).HoVaTen;
            string tManagerName = nhanSuService.findMember(Session.Instance.UserName).HoVaTen;
            string tManagerID = Session.Instance.UserName;
            string tName = nameBox.Text;
            string tDescription = taskDescription.Text;
            string tStart = taskStart.Value.ToString("yyyyMMdd");
            string tEnd = taskEnd.Value.ToString("yyyyMMdd");
            string tFile = taskFile.Text;
            string tStatus = taskStatus.SelectedItem.ToString();
            string tPriority = taskPriority.SelectedItem.ToString();
            string tSubject = $"THÔNG BÁO GIAO VIỆC - {tName}";
            string tSubjectNew = $"THÔNG BÁO THAY ĐỔI CÔNG VIỆC - {tName}";
            string tGiaoViec =
                $"Kính gửi {tStaffName},\nChúng ta đã xác định một công việc mới cần hoàn thành, và tôi muốn giao nhiệm vụ này cho bạn. Dưới đây là thông tin chi tiết về công việc:\nTên công việc: {tName}\nMô tả: {tDescription}\nThời hạn: {tEnd}\nƯu tiên: {tPriority}\nNgười giao việc: {tManagerName}\nXin vui lòng kiểm tra thông tin trên và bắt đầu làm việc ngay khi bạn có thể. Nếu bạn có bất kỳ câu hỏi hoặc cần hỗ trợ nào, đừng ngần ngại liên hệ với tôi.\nCảm ơn bạn đã đảm nhận nhiệm vụ này.\nTrân trọng,\n" + $"{tManagerName}";
            string tTo = nhanSuService.findMember(receiverID).Email;
            string tToNew = nhanSuService.findMember(oldImplementor).Email;
            string tThayDoi = $"Kính gửi {tOldStaffName},\nChúng ta đã xác định thay đổi về chi tiết công việc {tName}\n. Xin vui lòng kiểm tra thông tin mới nhất trên hệ thống. Nếu bạn có bất kỳ câu hỏi hoặc cần hỗ trợ nào, đừng ngần ngại liên hệ với tôi.\nCảm ơn bạn đã đảm nhận nhiệm vụ này.\nTrân trọng,\n {tManagerName}";
            int tMode = taskMode.Checked ? 1 : 0;
            int tIsCEO = Session.Instance.laCEO ? 1 : 0;
            int intime = 1;
            if (tName == "")
            {
                ToastForm toastForm = new ToastForm("WARNING", "Please enter name!");
                toastForm.ShowDialog();
                return;
            }
            if (tDescription == "")
            {
                ToastForm toastForm = new ToastForm("WARNING", "Please enter description!");
                toastForm.ShowDialog();
                return;
            }
            if (tStatus == "")
            {
                ToastForm toastForm = new ToastForm("WARNING", "Please select current status!");
                toastForm.ShowDialog();
                return;
            }
            if (taskStart.Value >= taskEnd.Value)
            {
                ToastForm toastForm = new ToastForm("WARNING", "Please select deadline after today!");
                toastForm.ShowDialog();
                return;
            }

            bool isSuccess = giaoViecService.updateTask(
                tDescription,
                tStart,
                tEnd,
                tStatus,
                tFile,
                this.ID,
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

            bool isTagAdded = tagService.updateTag(tagNameBox.Text, this.ID, "");

            if (isSuccess && isTagAdded)
            {
                MailService mailService = new MailService();
                if (tOldStaffName != tStaffName)
                {
                    mailService.sendMail(tSubjectNew, tThayDoi, tToNew);
                }
                mailService.sendMail(tSubjectNew, tGiaoViec, tTo);
                taskName.Text = "";
                nameBox.Text = "";
                sharedProcess.Text = "";
                customerLabel.Text = "";
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
                departmentMode.Checked = false;
                selectDepartment.Text = "";
                showToast("SUCCESS", "Updated task successfully!");

            }
            else
            {
                showToast("ERROR", "An Error Occur");

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
                MessageBox.Show(authorizedBy);
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

        private void currentFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            giaoViecService.downloadAttachedFile(this.ID);
        }

        private void changeLanguage()
        {
            Font font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            Font fontLarger = new Font("Copperplate Gothic Bold", 12);
            Font fontSmaller = new Font("Copperplate Gothic Bold", 9);
            if (Session.Instance.Language == "vi")
            {
                customButton25.Text = "CÔNG VIỆC";
                customButton24.Text = "THỐNG KÊ";
                customButton23.Text = "BÁO CÁO";
                customButton16.Text = "QUẢN LÝ TÀI KHOẢN";
                customButton15.Text = "CƯ DÂN VÀ CĂN HỘ";
                customButton21.Text = "DỊCH VỤ CƯ DÂN";
                label6.Text = "TÊN CÔNG VIỆC";
                label7.Text = "MÔ TẢ";
                label8.Text = "TÀI LIỆU ĐÍNH KÈM";
                label9.Text = "NGÀY BẮT ĐẦU";
                label10.Text = "HẠN CHÓT";
                label11.Text = "TIẾN ĐỘ";
                label12.Text = "ĐỘ ƯU TIÊN";
                authorizeLabel.Text = "TÁC GIẢ";
                uploadButton.Text = "DUYỆT";
                label19.Text = "NỔI BẬC";
                label16.Text = "TRUY CẬP CÔNG KHAI";
                label18.Text = "CÔNG TY";
                label17.Text = "BỘ PHẬN";
                editReceiverButton.Text = "SỬA";
                venueEditButton.Text = "SỬA";
                tagEditButton.Text = "SỬA";
                currentFile.Text = "TÀI LIỆU HIỆN TẠI";
                tagNameBox.Text = "Kiểm tra";

                font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);

                name.Text = "NGƯỜI THỰC HIỆN";
                label1.Text = "ĐƯỢC GIAO BỞI";
                label2.Text = "TIẾN TRÌNH ĐÃ CHIA SẺ";
                label3.Text = "KHÁCH HÀNG";
                label4.Text = "kHU VỰC LÀM VIỆC";
                label5.Text = "THẺ";
                label15.Text = "TRẠNG THÁI";
                fontLarger = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

                cancelButton.Text = "HỦY";
                saveButton.Text = "LƯU";
                fontSmaller = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);


                customButton25.Font = font;
                customButton24.Font = font;
                customButton23.Font = font;
                customButton16.Font = font;
                customButton15.Font = font;
                customButton21.Font = font;
                label6.Font = font;
                label7.Font = font;
                label8.Font = font;
                label9.Font = font;
                label10.Font = font;
                label11.Font = font;
                label12.Font = font;
                authorizeLabel.Font = font;
                uploadButton.Font = font;
                label19.Font = font;
                label16.Font = font;
                label18.Font = font;
                label17.Font = font;
                editReceiverButton.Font = font;
                venueEditButton.Font = font;
                tagEditButton.Font = font;
                currentFile.Font = font;
                //larger
                name.Font = fontLarger;
                label1.Font = fontLarger;
                label2.Font = fontLarger;
                label3.Font = fontLarger;
                label4.Font = fontLarger;
                label5.Font = fontLarger;
                label15.Font = fontLarger;
                //smaller
                cancelButton.Font = fontSmaller;
                saveButton.Font = fontSmaller;
            }
            else
            {
                customButton25.Text = "WORK";
                customButton24.Text = "STATISTIC";
                customButton23.Text = "REPORT";
                customButton16.Text = "ACCOUNTING MANAGEMENT";
                customButton15.Text = "APARTMENT RESIDENT";
                customButton21.Text = "RESIDENT SERVICE";
                label6.Text = "TASK NAME";
                label7.Text = "DESCRIPTION";
                label8.Text = "ATTACHES FILES";
                label9.Text = "START";
                label10.Text = "DEADLINE";
                label11.Text = "PROCESS";
                label12.Text = "PRIORITY";
                authorizeLabel.Text = "AUTHORIZE BY";
                uploadButton.Text = "BROWSER";
                label19.Text = "HIGHLIGHT";
                label16.Text = "PUBLIC ACCESS";
                label18.Text = "COMPANY";
                label17.Text = "DEPARTMENT";
                editReceiverButton.Text = "EDIT";
                venueEditButton.Text = "EDIT";
                tagEditButton.Text = "EDIT";
                currentFile.Text = "CURRENT FILE";
                tagNameBox.Text = "Checking";
                font = new Font("Copperplate Gothic Bold", 10);

                name.Text = "IMPLEMENTOR";
                label1.Text = "ASSIGNED BY";
                label2.Text = "SHARED PROCESS";
                label3.Text = "CUSTOMER";
                label4.Text = "WORKPLACE";
                label5.Text = "TAGS";
                label15.Text = "STATUS";
                fontLarger = new Font("Copperplate Gothic Bold", 12);

                cancelButton.Text = "CANCEL";
                saveButton.Text = "SAVE";
                fontSmaller = new Font("Copperplate Gothic Bold", 9);

                customButton25.Font = font;
                customButton24.Font = font;
                customButton23.Font = font;
                customButton16.Font = font;
                customButton15.Font = font;
                customButton21.Font = font;
                label6.Font = font;
                label7.Font = font;
                label8.Font = font;
                label9.Font = font;
                label10.Font = font;
                label11.Font = font;
                label12.Font = font;
                authorizeLabel.Font = font;
                uploadButton.Font = font;
                label19.Font = font;
                label16.Font = font;
                label18.Font = font;
                label17.Font = font;
                editReceiverButton.Font = font;
                venueEditButton.Font = font;
                tagEditButton.Font = font;
                currentFile.Font = font;
                //larger
                name.Font = fontLarger;
                label1.Font = fontLarger;
                label2.Font = fontLarger;
                label3.Font = fontLarger;
                label4.Font = fontLarger;
                label5.Font = fontLarger;
                label15.Font = fontLarger;
                //smaller
                cancelButton.Font = fontSmaller;
                saveButton.Font = fontSmaller;
            }
        }

        private void languageSelect_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            Font font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            Font fontLarger = new Font("Copperplate Gothic Bold", 12);
            Font fontSmaller = new Font("Copperplate Gothic Bold", 9);
            if (languageSelect.SelectedItem.ToString() == "VIETNAMESE")//
            {
                Session.Instance.Language = "vi";
                customButton25.Text = "CÔNG VIỆC";
                customButton24.Text = "THỐNG KÊ";
                customButton23.Text = "BÁO CÁO";
                customButton16.Text = "QUẢN LÝ TÀI KHOẢN";
                customButton15.Text = "CƯ DÂN VÀ CĂN HỘ";
                customButton21.Text = "DỊCH VỤ CƯ DÂN";
                label6.Text = "TÊN CÔNG VIỆC";
                label7.Text = "MÔ TẢ";
                label8.Text = "TÀI LIỆU ĐÍNH KÈM";
                label9.Text = "NGÀY BẮT ĐẦU";
                label10.Text = "HẠN CHÓT";
                label11.Text = "TIẾN ĐỘ";
                label12.Text = "ĐỘ ƯU TIÊN";
                authorizeLabel.Text = "TÁC GIẢ";
                uploadButton.Text = "DUYỆT";
                label19.Text = "NỔI BẬC";
                label16.Text = "TRUY CẬP CÔNG KHAI";
                label18.Text = "BỘ PHẬN";
                label17.Text = "CÔNG TY";
                editReceiverButton.Text = "SỬA";
                venueEditButton.Text = "SỬA";
                tagEditButton.Text = "SỬA";
                currentFile.Text = "TÀI LIỆU HIỆN TẠI";
                tagNameBox.Text = "Kiểm tra";

                font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);

                name.Text = "NGƯỜI THỰC HIỆN";
                label1.Text = "ĐƯỢC GIAO BỞI";
                label2.Text = "TIẾN TRÌNH ĐÃ CHIA SẺ";
                label3.Text = "KHÁCH HÀNG";
                label4.Text = "kHU VỰC LÀM VIỆC";
                label5.Text = "THẺ";
                label15.Text = "TRẠNG THÁI";
                fontLarger = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

                cancelButton.Text = "HỦY";
                saveButton.Text = "LƯU";
                fontSmaller = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);


                customButton25.Font = font;
                customButton24.Font = font;
                customButton23.Font = font;
                customButton16.Font = font;
                customButton15.Font = font;
                customButton21.Font = font;
                label6.Font = font;
                label7.Font = font;
                label8.Font = font;
                label9.Font = font;
                label10.Font = font;
                label11.Font = font;
                label12.Font = font;
                authorizeLabel.Font = font;
                uploadButton.Font = font;
                label19.Font = font;
                label16.Font = font;
                label18.Font = font;
                label17.Font = font;
                editReceiverButton.Font = font;
                venueEditButton.Font = font;
                tagEditButton.Font = font;
                currentFile.Font = font;
                //larger
                name.Font = fontLarger;
                label1.Font = fontLarger;
                label2.Font = fontLarger;
                label3.Font = fontLarger;
                label4.Font = fontLarger;
                label5.Font = fontLarger;
                label15.Font = fontLarger;
                //smaller
                cancelButton.Font = fontSmaller;
                saveButton.Font = fontSmaller;
            }
            else
            {
                Session.Instance.Language = "en";
                customButton25.Text = "WORK";
                customButton24.Text = "STATISTIC";
                customButton23.Text = "REPORT";
                customButton16.Text = "ACCOUNTING MANAGEMENT";
                customButton15.Text = "APARTMENT RESIDENT";
                customButton21.Text = "RESIDENT SERVICE";
                label6.Text = "TASK NAME";
                label7.Text = "DESCRIPTION";
                label8.Text = "ATTACHES FILES";
                label9.Text = "START";
                label10.Text = "DEADLINE";
                label11.Text = "PROCESS";
                label12.Text = "PRIORITY";
                authorizeLabel.Text = "AUTHORIZE BY";
                uploadButton.Text = "BROWSER";
                label19.Text = "HIGHLIGHT";
                label16.Text = "PUBLIC ACCESS";
                label18.Text = "COMPANY";
                label17.Text = "DEPARTMENT";
                editReceiverButton.Text = "EDIT";
                venueEditButton.Text = "EDIT";
                tagEditButton.Text = "EDIT";
                currentFile.Text = "CURRENT FILE";
                tagNameBox.Text = "Checking";
                font = new Font("Copperplate Gothic Bold", 10);

                name.Text = "IMPLEMENTOR";
                label1.Text = "ASSIGNED BY";
                label2.Text = "SHARED PROCESS";
                label3.Text = "CUSTOMER";
                label4.Text = "WORKPLACE";
                label5.Text = "TAGS";
                label15.Text = "STATUS";
                fontLarger = new Font("Copperplate Gothic Bold", 12);

                cancelButton.Text = "CANCEL";
                saveButton.Text = "SAVE";
                fontSmaller = new Font("Copperplate Gothic Bold", 9);

                customButton25.Font = font;
                customButton24.Font = font;
                customButton23.Font = font;
                customButton16.Font = font;
                customButton15.Font = font;
                customButton21.Font = font;
                label6.Font = font;
                label7.Font = font;
                label8.Font = font;
                label9.Font = font;
                label10.Font = font;
                label11.Font = font;
                label12.Font = font;
                authorizeLabel.Font = font;
                uploadButton.Font = font;
                label19.Font = font;
                label16.Font = font;
                label18.Font = font;
                label17.Font = font;
                editReceiverButton.Font = font;
                venueEditButton.Font = font;
                tagEditButton.Font = font;
                currentFile.Font = font;
                //larger
                name.Font = fontLarger;
                label1.Font = fontLarger;
                label2.Font = fontLarger;
                label3.Font = fontLarger;
                label4.Font = fontLarger;
                label5.Font = fontLarger;
                label15.Font = fontLarger;
                //smaller
                cancelButton.Font = fontSmaller;
                saveButton.Font = fontSmaller;
            }
        }

        private void ShowDepartmentForm_DepartmentSelected(string department)
        {
            sharedDepartment = department;
            selectDepartment.Text = department;
            sharedProcess.Text = department;
            CanHoService canHoService = new CanHoService();
            string? customerID = canHoService.findApartment(venueID).MaCuDan;
            if (customerID != null)
            {
                customerLabel.Text = customerID;
            }
        }

        private void departmentMode_CheckedChanged(object sender, EventArgs e)
        {
            if (departmentMode.Checked)
            {
                A_ShowDepartment showDepartmentForm = new A_ShowDepartment();
                showDepartmentForm.DepartmentSelected += ShowDepartmentForm_DepartmentSelected;
                showDepartmentForm.ShowDialog();
            }
            if (taskMode.Checked)
            {
                taskMode.Checked = false;
            }
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

        private void customButton16_Click(object sender, EventArgs e)
        {
            C_AccountManagement managements = new C_AccountManagement();
            managements.ShowDialog();
        }

        private void customButton15_Click(object sender, EventArgs e)
        {
            CM_Resident_sDetail cM = new CM_Resident_sDetail();
            cM.ShowDialog();
        }

        private void label24_Click(object sender, EventArgs e)
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

        private void label20_Click(object sender, EventArgs e)
        {
            G_ForgotPassword g_ForgotPassword = new G_ForgotPassword();
            g_ForgotPassword.ShowDialog();
        }

        private void label13_Click_1(object sender, EventArgs e)
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

        private void customButton25_Click(object sender, EventArgs e)
        {
            C_AllTaskList c_AllTaskList = new C_AllTaskList();
            c_AllTaskList.ShowDialog();
        }

        private void customButton2_Click_1(object sender, EventArgs e)
        {

        }
        public void showToast(string type, string message)
        {
            ToastForm show = new ToastForm(type, message);
            show.Show();
        }

        private void taskMode_CheckedChanged(object sender, EventArgs e)
        {
            if (departmentMode.Checked)
            {
                departmentMode.Checked = false;
            }
            sharedProcess.Text = "";
            selectDepartment.Text = "";
        }
    }
}
