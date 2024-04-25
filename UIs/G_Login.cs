using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.IdentityModel.Tokens;
using Repositories.Entities;
using Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UIs
{
    public partial class G_Login : Form
    {
        public G_Login()
        {
            InitializeComponent();
            this.AcceptButton = button_Login;
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            DanhNhapService service = new DanhNhapService();
            CeoService ceoService = new CeoService();
            QuanLyService quanLyService = new QuanLyService();
            string userID = box_username.Text;
            string password = box_password.Text;
            string result = service.checkLogin(userID, password);
            NhanSuService nhanSuService = new NhanSuService();
            //
            ////luu mat khau
            if (checkbox_Remember.Checked)
            {
                // Lưu mật khẩu vào Properties.Settings
                Properties.Settings.Default.Username = userID;
                Properties.Settings.Default.Password = password;
                Properties.Settings.Default.Save();
                MessageBox.Show("Đã lưu mật khẩu của bạn");
            }
            //
            MessageBox.Show(result);

            // Session lưu các thông tin quan trọng của tài khoản
            if (result == "Đăng nhập thành công")
            {

                NhanSu member = nhanSuService.findMember(userID);
                Session.Instance.UserName = box_username.Text;
                Session.Instance.Name = member.HoVaTen;
                Session.Instance.Avatar = member.AnhDaiDien;
                if (service.getEmailAccount(userID) != "Không tìm thấy mail của nhân viên này! Kiểm tra lại mã đăng nhập!")
                {
                    Session.Instance.Email = box_password.Text;
                }
                if (ceoService.getCeo(userID) != null)
                {
                    Session.Instance.laCEO = true;
                }
                else if (quanLyService.findManager(userID) != null)
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
                SplashScreeen splashScreen = new SplashScreeen();
                splashScreen.ShowDialog();
            }
        }

        private void box_username_Enter(object sender, EventArgs e)
        {
            if (box_username.Text == "Username")
            {
                box_username.Text = "";
            }
        }

        private void box_username_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(box_username.Text))
            {
                box_username.Text = "Username";
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
                box_password.PasswordChar = '\0';
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
            Application.Exit();
        }

        private void G_Login_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.Username) &&
                !string.IsNullOrEmpty(Properties.Settings.Default.Password))
            {
                box_username.Text = Properties.Settings.Default.Username;
                box_password.Text = Properties.Settings.Default.Password;
                box_password.PasswordChar = '*';
                //button_Login_Click(sender, e);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
