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
            Session.Instance.UserName = "GD-101";
            Session.Instance.laQuanLi=true;
            if (Session.Instance.UserName.Contains("GD"))
            {
                loadAllDepartment();
                deparmentsBox.SelectedIndex = -1;
            }
            if(Session.Instance.laQuanLi && !Session.Instance.UserName.Contains("GD"))
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

            if (typeBox.SelectedIndex==-1)
            {
                MessageBox.Show("Vui lòng chọn loại nhân viên.");
                typeBox.Focus();
                return;
            }

            if (deparmentsBox.SelectedIndex==-1)
            {
                MessageBox.Show("Vui lòng chọn phòng ban.");
                deparmentsBox.Focus();
                return;
            }

            // Kiểm tra CMND
            if (!IsValidCitizenID(citizenID))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng CMND.");
                citizenIDBox.Focus();
                return;
            }

            // Kiểm tra định dạng email
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng email.");
                emailBox.Focus();
                return;
            }

            if (passport.Length <= 0)
            {
                MessageBox.Show("Vui lòng nhập quốc tịch.");
                passPortBox.Focus();
                return;
            }

            if (userName.Length <= 0)
            {
                MessageBox.Show("Vui lòng nhập họ và tên.");
                userNameBox.Focus();
                return;
            }

            // Kiểm tra giới tính
            if (gender.Length <= 0)
            {
                MessageBox.Show("Vui lòng chọn giới tính.");
                genderBox.Focus();
                return;
            }

            // Kiểm tra số điện thoại
            if (!IsValidPhoneNumber(mobile))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số điện thoại.");
                mobileBox.Focus();
                return;
            }

            // Kiểm tra ngày sinh
            if (date.Length<=0)
            {
                MessageBox.Show("Vui lòng chọn ngày sinh.");
                birthdateBox.Focus();
                return;
            }

            if (address.Length <= 0)
            {
                MessageBox.Show("Vui lòng nhập địa chỉ.");
                addressBox.Focus();
                return;
            }

            // Thực hiện tạo tài khoản
            bool isSucc = nhanSuSer.createEmployee(passport, userName, mobile, date, citizenID, email, phongBan.MaPb, gender, address, currentDate, type, passport);

            if (isSucc)
            {
                MessageBox.Show("Thêm Thành Công");
                // Xóa nội dung của các TextBox
                citizenIDBox.Clear();
                emailBox.Clear();
                passPortBox.Clear();
                userNameBox.Clear();
                mobileBox.Clear();
                addressBox.Clear();

                // Xóa selectedIndex của ComboBox
                deparmentsBox.SelectedIndex = -1;
                typeBox.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Thêm Thất Bại");
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

    }
}
