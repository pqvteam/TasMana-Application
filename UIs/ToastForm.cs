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
    public partial class ToastForm : Form
    {
        int toastX, toastY;
        public ToastForm(string type, string message)
        {
            InitializeComponent();
            lbType.Text = type;
            lbMessage.Text = message;
            switch (type)
            {
                case "SUCCESS":
                    panel1.BackColor = Color.ForestGreen;
                    pictureBox1.Image = Properties.Resources.accept__1_;
                    break;
                case "ERROR":
                    panel1.BackColor= Color.FromArgb(227,50,45);
                    pictureBox1.Image= Properties.Resources.multiply__1_;
                    break;
                case "INFOR":
                    panel1.BackColor = Color.FromArgb(18,136,191);
                    pictureBox1.Image = Properties.Resources.info__1_;
                    break;
                case "WARNING":
                    panel1.BackColor = Color.FromArgb(245,171,35);
                    pictureBox1.Image = Properties.Resources.warning__1_;
                    break;
            }    
        }

        private void ToastForm_Load(object sender, EventArgs e)
        {
            Position();
        }

        private void Position()
        {
            int ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            toastX = ScreenWidth - this.Width - 10;
            toastY = ScreenHeight - this.Height + 70;

            this.Location = new Point(toastX, toastY);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toastY -= 10;
            this.Location = new Point(toastX, toastY);
            if (toastY <= 900)
            {
                timer1.Stop();
            }
        }
        int y = 100;
        private void timer2_Tick(object sender, EventArgs e)
        {
            y--;
            if(y<=0)
            {
                toastY += 1;
                this.Location = new Point(toastX, toastY += 10);
                if(toastY>750)
                {
                    timer2.Stop();
                    y = 100;
                    this.Close();
                }
            }    
        }
    }
}
