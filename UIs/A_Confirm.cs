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
    public partial class A_Confirm : Form
    {
        private string message;
        private string type = "danger";
        public event EventHandler ConfirmClicked;

        public A_Confirm()
        {
            InitializeComponent();
        }

        public A_Confirm(string message, string type)
        {
            this.message = message;
            this.type = type;
            InitializeComponent();
        }

        private void customPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.ConfirmClicked?.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        private void A_Confirm_Load(object sender, EventArgs e)
        {
            if (this.message != "")
            {
                messageText.Text = this.message;
            }

            if (this.type == "danger")
            {
                messageText.ForeColor = Color.Red;
                confirmButton.BackColor = Color.Red;
            }
            else if (this.type == "warning")
            {
                messageText.ForeColor = Color.Yellow;
                confirmButton.BackColor = Color.Green;
            }
            else if (this.type == "infor")
            {
                messageText.ForeColor = Color.Blue;
                confirmButton.BackColor = Color.Green;
                confirmButton.Text = "I see";
            }
            else if (this.type == "confirm")
            {
                messageText.ForeColor = Color.GreenYellow;
                confirmButton.BackColor = Color.Green;
                confirmButton.Text = "Ok";
            }
            changelanguage();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void messageText_Click(object sender, EventArgs e)
        {


        }

        private void changelanguage()
        {
            Font font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            Font fontSmaller = new Font("Copperplate Gothic Bold", 9);
            if (Session.Instance.Language == "vi")
            {
                messageText.Text = "BẠN CÓ CHẮC CHẮN XÓA TÀI KHOẢN NÀY?";
                font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
                cancelButton.Text = "HỦY";
                confirmButton.Text = "TIẾP TỤC";
                fontSmaller = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);

            }
            else
            {
                messageText.Text = "ARE YOU SURE TO DELETE THIS ACCOUNT?";
                font = new Font("Copperplate Gothic Bold", 14);
                cancelButton.Text = "CANCEL";
                confirmButton.Text = "CONTINUE";
                fontSmaller = new Font("Copperplate Gothic Bold", 9);
            }
            messageText.Font = font;
            cancelButton.Font = fontSmaller;
            confirmButton.Font = fontSmaller;
        }
    }
}
