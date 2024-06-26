﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf.parser.clipper;
using Services;
using static System.Net.WebRequestMethods;

namespace UIs
{
    public partial class G_ForgotPassword : Form
    {
        DanhNhapService service = new DanhNhapService();
        bool exitForm = true;
        public G_ForgotPassword()
        {
            InitializeComponent();
        }

        private void button_SendCode_Click(object sender, EventArgs e)
        {
            string username = box_username.Text;
            string result = service.sendConfirmCode(username);
            if (result == "The confirmation code has been sent to your email")
            {
                showToast("SUCCESS", result);
                panel_forgotPassword.Visible = false;
                panel_verify.Visible = true;
            }
            else
            {
                showToast("ERROR", result);
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

        private void box_NumericCode_Enter(object sender, EventArgs e)
        {
            if (box_NumericCode.Text == "Verification code")
            {
                box_NumericCode.Text = "";
            }
        }

        private void box_NumericCode_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(box_NumericCode.Text))
            {
                box_NumericCode.Text = "Verification code";
            }
        }

        private void button_VerifyCode_Click(object sender, EventArgs e)
        {
            string username = box_username.Text;
            string code = box_NumericCode.Text;
            string result = service.confirmCode(username, code);
            MessageBox.Show("Mật khẩu của bạn là: " + result);
            if(result != "Incorect OTP!")
            {
                panel_verify.Visible = false;
                panel_resetPassword.Visible = true;
            }
        }


        private void label_back_Click(object sender, EventArgs e)
        {
            exitForm = false;
            this.Close();
            G_Login loginInterface = new G_Login();
            loginInterface.Show();

        }

        private void box_newPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(box_newPassword.Text))
            {
                box_newPassword.Text = "New password";
                box_newPassword.PasswordChar = '\0';
            }
        }

        private void box_newPassword_Enter(object sender, EventArgs e)
        {
            if (box_newPassword.Text == "New password")
            {
                box_newPassword.Text = "";
            }
        }

        private void box_confirmPassword_Enter(object sender, EventArgs e)
        {
            if (box_confirmPassword.Text == "Confirm password")
            {
                box_confirmPassword.Text = "";
            }
        }

        private void box_confirmPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(box_confirmPassword.Text))
            {
                box_confirmPassword.Text = "Confirm password";
                box_confirmPassword.PasswordChar = '\0';
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (box_newPassword.Text == box_confirmPassword.Text)
            {
                bool result = service.savePassword(box_username.Text, box_newPassword.Text);
                if (result)
                {
                    showToast("SUCCESS", "Change password successfully");
                    this.Close();
                }
                else
                {
                    showToast("ERROR", "An error occurred");
                }
            }
            else
            {
                showToast("SUCCESS", "Password and confirmation do not match");
            }

        }

        private void label_resendCode_Click(object sender, EventArgs e)
        {
            string username = box_username.Text;
            string result = service.sendConfirmCode(username);
            if (result == "The confirmation code has been sent to your email")
            {
                showToast("SUCCESS", result);
            }
            else
            {
                showToast("ERROR", result);
            }
        }

        private void box_newPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (box_newPassword.Text != "New password")
            {
                box_newPassword.PasswordChar = '*';
            }
        }

        private void box_confirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (box_confirmPassword.Text != "Confirm password")
            {
                box_confirmPassword.PasswordChar = '*';
            }
        }

        private void customButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_back2_Click(object sender, EventArgs e)
        {
            panel_verify.Visible = false;
            panel_forgotPassword.Visible = true;
        }

        private void button_back3_Click(object sender, EventArgs e)
        {
            panel_resetPassword.Visible = false;
            panel_verify.Visible = true;
        }
        public void showToast(string type, string message)
        {
            ToastForm show = new ToastForm(type, message);
            show.Show();
        }

    }
}
