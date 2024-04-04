using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;

namespace UIs
{
    public partial class G_Login : Form
    {
        public G_Login()
        {
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            DanhNhapService service = new DanhNhapService();
            string userID = box_username.Text;
            string password = box_password.Text;
            string result = service.checkLogin(userID, password);
            if (checkbox_Remember.Checked && service.savePassword(userID, password))
            {
                MessageBox.Show("Đã lưu mật khẩu của bạn");
            }
            else if(checkbox_Remember.Checked && service.savePassword(userID, password)==false)
            {
                MessageBox.Show("Mật khẩu của bạn lưu thất bại");
            }
            MessageBox.Show(result);

            // Session lưu các thông tin quan trọng của tài khoản
            if (result == "Đăng nhập thành công")
            {
                Session.Instance.UserName = box_username.Text;
                if (service.getEmailAccount(userID) != "Không tìm thấy mail của nhân viên này! Kiểm tra lại mã đăng nhập!")
                {
                    Session.Instance.Email = box_password.Text;
                }
                if(service.laCEO(userID))
                {
                    Session.Instance.laCEO = true;
                }
                else if (service.laQuanLi(userID))
                {
                    Session.Instance.laQuanLi = true;
                }
                else if (service.laTruongNhom(userID))
                {
                    Session.Instance.laTruongNhom = true;
                }
                if (service.daNghiViec(userID))
                {
                    Session.Instance.daNghiViec = true;
                }
            }
        }

        private void box_username_Enter(object sender, EventArgs e)
        {
            if (box_username.Text == "User ID")
            {
                box_username.Text = "";
            }
        }

        private void box_username_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(box_username.Text))
            {
                box_username.Text = "User ID";
            }
        }

        private void box_password_Enter(object sender, EventArgs e)
        {
            if (box_password.Text == "Password")
            {
                box_password.Text = "";
            }
        }

        private void box_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (box_password.Text != "Password")
            {
                box_password.PasswordChar = '*';
            }
        }

        private void box_password_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(box_password.Text))
            {
                box_password.Text = "Password";
            }
        }

        private void label_forgotPassword_Click(object sender, EventArgs e)
        {
            G_ForgotPassword forgotPassword = new G_ForgotPassword();
            this.Hide();
            forgotPassword.Show();
        }

        private void customButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
