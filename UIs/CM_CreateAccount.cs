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
    public partial class CM_CreateAccount : Form
    {
        private PhongBanService phongBanSer = new PhongBanService();
        public CM_CreateAccount()
        {
            InitializeComponent();
        }

        private void CM_CreateAccount_Load(object sender, EventArgs e)
        {
            changelanguage();

            if (Session.Instance.UserName.Contains("GD"))
            {
                loadAllDepartment();
                deparmentsBox.SelectedIndex = -1;
            }
            if (Session.Instance.laQuanLi && !Session.Instance.UserName.Contains("GD"))
            {
                loadAllDepartment();
                if (Session.Instance.laQuanLi)
                {
                    loadAllDepartment();
                    // Tìm phòng ban có mã PB giống với ID của session
                    foreach (PhongBan department in deparmentsBox.Items)
                    {
                        if (Session.Instance.UserName.Contains(department.MaPb))
                        {
                            deparmentsBox.SelectedItem = department;
                            deparmentsBox.Enabled = false;
                            break;
                        }
                    }
                }
            }
        }

        private void departmentsBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void loadAllDepartment()
        {

            List<PhongBan> listDepartment = phongBanSer.getAllDepartment();
            deparmentsBox.DataSource = listDepartment;
            deparmentsBox.DisplayMember = "tenPB";
            // Đặt lại selectedIndex của ComboBox về -1 để không có mục nào được chọn
        }

        private void customButton10_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void customButton7_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void customDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void customButton14_Click(object sender, EventArgs e)
        {
            MailService sendMailSer = new MailService();
            string password = "123456";
            PhongBan phongBan = (PhongBan)deparmentsBox.SelectedItem;
            string type = typeBox.SelectedItem?.ToString();
            string citizenID = citizenIDBox.Text;
            string email = emailBox.Text;
            string passport = passPortBox.Text;
            string userName = userNameBox.Text;
            string gender = genderBox.Text;
            string mobile = mobileBox.Text;
            string date = birthdateBox.Value.ToString("yyyyMMdd");
            string address = addressBox.Text;
            string currentDate = DateTime.Now.ToString("yyyyMMdd");
            NhanSuService nhanSuSer = new NhanSuService();

            if (typeBox.SelectedIndex == -1)
            {
                showToast("WARNING", "Please select employee type");
                typeBox.Focus();
                return;
            }

            if (deparmentsBox.SelectedIndex == -1)
            {
                showToast("WARNING", "Please select department");
                deparmentsBox.Focus();
                return;
            }

            // Kiểm tra CMND
            if (!IsValidCitizenID(citizenID))
            {
                showToast("WARNING", "Please enter the correct ID card format.");
                citizenIDBox.Focus();
                return;
            }

            // Kiểm tra định dạng email
            if (!IsValidEmail(email))
            {
                showToast("WARNING", "Please enter the correct email format.");
                emailBox.Focus();
                return;
            }

            if (passport.Length <= 0)
            {
                showToast("WARNING", "Please enter your nationality");
                passPortBox.Focus();
                return;
            }

            if (userName.Length <= 0)
            {
                showToast("WARNING", "Please enter the user name");
                userNameBox.Focus();
                return;
            }

            // Kiểm tra giới tính
            if (gender.Length <= 0)
            {
                showToast("WARNING", "Please enter the gender");
                genderBox.Focus();
                return;
            }

            // Kiểm tra số điện thoại
            if (!IsValidPhoneNumber(mobile))
            {
                showToast("WARNING", "Please enter the correct phone number format.");
                mobileBox.Focus();
                return;
            }

            // Kiểm tra ngày sinh
            if (date.Length <= 0)
            {
                showToast("WARNING", "Please enter the correct date format.");
                birthdateBox.Focus();
                return;
            }

            // Chuyển đổi ngày nhập vào thành kiểu DateTime
            if (!DateTime.TryParse(date, out DateTime inputDate))
            {
                showToast("WARNING", "Please enter the correct date");
                birthdateBox.Focus();
                return;
            }

            DateTime currentDate2 = DateTime.Now;


            // So sánh ngày nhập vào với ngày hiện tại
            if (inputDate <= currentDate2)
            {
                // Ngày nhập vào không lớn hơn ngày hiện tại
                showToast("WARNING", "Please enter a date later than the current date");
                birthdateBox.Focus();
                return;
            }


            if (address.Length <= 0)
            {
                showToast("WARNING", "Please enter the address");
                addressBox.Focus();
                return;
            }

            string ID = nhanSuSer.createIDEmployee(phongBan.MaPb);

            // Thực hiện tạo tài khoản
            bool isSucc = nhanSuSer.createEmployee(ID, password, userName, mobile, date, citizenID, email, phongBan.MaPb, gender, address, currentDate, type, passport);

            if (isSucc)
            {
                showToast("SUCCESS", "Create account successfully");
                string content = $"Vui lòng không chia sẻ tài khoản nhân viên tới bất kì ai\nMã nhân viên: {ID}\nMật khẩu mặc định: 123456\nSau khi đăng nhập lần đầu, nhân viên vui lòng đổi mật khẩu mặc định.";
                sendMailSer.sendMail("Thông tin tài khoản nhân viên", content, email);
                showToast("INFO", "Employee information has been sent to gmail");
                // Xóa nội dung của các TextBox
                citizenIDBox.Clear();
                emailBox.Clear();
                passPortBox.Clear();
                userNameBox.Clear();
                mobileBox.Clear();
                addressBox.Clear();
                genderBox.Clear();
                // Xóa selectedIndex của ComboBox
                deparmentsBox.SelectedIndex = -1;
                typeBox.SelectedIndex = -1;

            }
            else
            {
                showToast("ERROR", "Create failed");
            }
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        // Phương thức kiểm tra định dạng số điện thoại
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Định dạng số điện thoại có thể được kiểm tra bằng biểu thức chính quy
            // Ở đây, chúng ta sẽ chỉ kiểm tra xem số điện thoại có chứa ít nhất 10 chữ số hay không
            return phoneNumber.Length >= 10;
        }

        // Phương thức kiểm tra định dạng CMND
        private bool IsValidCitizenID(string citizenID)
        {
            // Định dạng CMND có thể được kiểm tra bằng biểu thức chính quy
            // Ở đây, chúng ta sẽ chỉ kiểm tra xem CMND có chứa đúng 9 hoặc 12 chữ số hay không
            return citizenID.Length == 9 || citizenID.Length == 12;
        }

        private void changelanguage()
        {
            Font font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            Font fontSmaller = new Font("Copperplate Gothic Bold", 9);
            if (Session.Instance.Language == "vi")
            {
                customButton10.Text = "TẠO TÀI KHOẢN";
                customButton10.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);

                label2.Text = "LOẠI TÀI KHOẢN";
                label1.Text = "PHÒNG BAN";
                label3.Text = "CCCD";
                label5.Text = "HỘ CHIẾU";
                label6.Text = "TÊN NGƯỜI DÙNG";
                label7.Text = "GIỚI TÍNH";
                label8.Text = "SỐ ĐIỆN THOẠI";
                label9.Text = "NGÀY SINH";
                label10.Text = "ĐỊA CHỈ";
                font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);

                cancelButton.Text = "HỦY";
                customButton14.Text = "TẠO";
                fontSmaller = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
            }
            else
            {
                customButton10.Text = "CREATE ACCOUNT";
                customButton10.Font = new Font("Copperplate Gothic Bold", 14);

                label2.Text = "TYPE ACCOUNT";
                label1.Text = "DEPARTMENT";
                label3.Text = "CITIZEN ID";
                label5.Text = "PASSPORT";
                label6.Text = "USERNAME";
                label7.Text = "GENDER";
                label8.Text = "MOBILE";
                label9.Text = "BIRTH DATE";
                label10.Text = "ADDRESS";
                font = new Font("Copperplate Gothic Bold", 10);

                cancelButton.Text = "CANCEL";
                customButton14.Text = "CREATE";
                fontSmaller = new Font("Copperplate Gothic Bold", 9);
            }

            label2.Font = font;
            label1.Font = font;
            label3.Font = font;
            label5.Font = font;
            label6.Font = font;
            label7.Font = font;
            label8.Font = font;
            label9.Font = font;
            label10.Font = font;

            cancelButton.Font = fontSmaller;
            customButton14.Font = fontSmaller;

        }
        public void showToast(string type, string message)
        {
            ToastForm show = new ToastForm(type, message);
            show.Show();
        }

    }
}
