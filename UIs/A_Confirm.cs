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
                messageText.ForeColor = Color.Green;
                confirmButton.BackColor = Color.Green;
                confirmButton.Text = "Ok";
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void messageText_Click(object sender, EventArgs e)
        {


        }
    }
}
