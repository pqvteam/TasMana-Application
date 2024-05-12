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
using Python.Runtime;
using System.Diagnostics;
using IronPython.Runtime.Operations;

namespace UIs
{
    public partial class G_Login : Form
    {
        public G_Login()
        {
            InitializeComponent();
            this.AcceptButton = button_Login;
        }

        private void faceLogin()
        {
            var psi = new ProcessStartInfo();
            psi.FileName = "\"C:\\Users\\ASUS\\AppData\\Local\\Programs\\Python\\Python312\\python.exe\"";
            var script = "\"D:\\FaceDetect\\03_face_recognition.py\"";
            psi.Arguments = $"\"{script}";
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
            var errors = "";
            var result = "";
            using (var process = Process.Start(psi))
            {
                errors = process.StandardError.ReadToEnd();
                result = process.StandardOutput.ReadToEnd();
            }
            if (result != "")
            {
                DanhNhapService service = new DanhNhapService();
                CeoService ceoService = new CeoService();
                QuanLyService quanLyService = new QuanLyService();
                Session.Instance.UserName = result;
                NhanSuService nhanSuService = new NhanSuService();
                result = result.Trim();
                NhanSu member = nhanSuService.findMember(result.strip());
                Session.Instance.UserName = result;
                Session.Instance.Name = member.HoVaTen;
                Session.Instance.Avatar = member.AnhDaiDien;
                if (ceoService.getCeo(result) != null)
                {
                    Session.Instance.laCEO = true;
                }
                else if (quanLyService.findManager(result) != null)
                {
                    Session.Instance.laQuanLi = true;
                }
                else if (service.laTruongNhom(result))
                {
                    Session.Instance.laTruongNhom = true;
                }
                if (service.daNghiViec(result))
                {
                    Session.Instance.daNghiViec = true;
                }
                SplashScreeen splashScreen = new SplashScreeen();
                splashScreen.ShowDialog();
                C_AllTaskList all = new C_AllTaskList();
                all.ShowDialog();
            }
            else
            {
                MessageBox.Show(errors);
            }
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
                showToast("SUCCESS", "Save password successfully");
            }
            //

            // Session lưu các thông tin quan trọng của tài khoản
            if (result == "Đăng nhập thành công")
            {

                showToast("SUCCESS", "Login successfuly");
                NhanSu member = nhanSuService.findMember(userID);
                Session.Instance.UserName = box_username.Text;
                Session.Instance.Name = member.HoVaTen;
                Session.Instance.Avatar = member.AnhDaiDien;
                if (service.getEmailAccount(userID) != "Could not find this employee's email! Check your login code again!")
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
            else
            {
                showToast("ERROR", "Login Failed!");
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
                box_password.PasswordChar = '*';
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void showToast(string type, string message)
        {
            ToastForm show = new ToastForm(type, message);
            show.ShowDialog();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            faceLogin();
        }
    }
}
