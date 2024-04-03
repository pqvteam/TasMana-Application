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
            MessageBox.Show(result);
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
            if (box_NumericCode.Text == "Enter Code")
            {
                box_NumericCode.Text = "";
            }
        }

        private void box_NumericCode_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(box_NumericCode.Text))
            {
                box_NumericCode.Text = "Enter Code";
            }
        }

        private void button_ConfirmCode_Click(object sender, EventArgs e)
        {
            string username = box_username.Text;
            string code = box_NumericCode.Text;
            string result = service.confirmCode(username, code);
            MessageBox.Show("Mật khẩu của bạn là: " + result);
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            exitForm = false;
            this.Close();
            G_Login loginInterface = new G_Login();
            loginInterface.Show();
        }

        private void G_ForgotPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (exitForm)
            {
                Application.Exit();
            }
        }
    }
}
