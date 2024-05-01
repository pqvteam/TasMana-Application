using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repositories.Entities;
using Services;

namespace UIs
{
    public partial class A_UpdateProcess : Form
    {
        private string taskID = "";
        private string taskStatus = "";

        public A_UpdateProcess()
        {
            InitializeComponent();
        }

        public A_UpdateProcess(string id, string status)
        {
            this.taskID = id;
            this.taskStatus = status;
            InitializeComponent();
        }

        private void A_UpdateProcess_Load(object sender, EventArgs e)
        {
            statusBox.Text = taskStatus;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void idBox_TextChanged(object sender, EventArgs e)
        {
            statusBox.Text = taskStatus;
        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            taskStatus = "Unexecuted?Not yet started";
            customButton2.BackColor = Color.FromArgb(24, 23, 23);
            customButton3.BackColor = Color.FromArgb(42, 42, 42);
            customButton5.BackColor = Color.FromArgb(24, 23, 23);
            customButton6.BackColor = Color.FromArgb(24, 23, 23);
            customButton7.BackColor = Color.FromArgb(24, 23, 23);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            taskStatus = "Completed";
            customButton2.BackColor = Color.FromArgb(42, 42, 42);
            customButton3.BackColor = Color.FromArgb(24, 23, 23);
            customButton5.BackColor = Color.FromArgb(24, 23, 23);
            customButton6.BackColor = Color.FromArgb(24, 23, 23);
            customButton7.BackColor = Color.FromArgb(24, 23, 23);
        }

        private void customButton5_Click(object sender, EventArgs e)
        {
            taskStatus = "Processing";
            customButton2.BackColor = Color.FromArgb(24, 23, 23);
            customButton3.BackColor = Color.FromArgb(24, 23, 23);
            customButton5.BackColor = Color.FromArgb(42, 42, 42);
            customButton6.BackColor = Color.FromArgb(24, 23, 23);
            customButton7.BackColor = Color.FromArgb(24, 23, 23);

        }

        private void customButton6_Click(object sender, EventArgs e)
        {
            taskStatus = "Customer Reschedule";
            customButton2.BackColor = Color.FromArgb(24, 23, 23);
            customButton3.BackColor = Color.FromArgb(24, 23, 23);
            customButton5.BackColor = Color.FromArgb(24, 23, 23);
            customButton6.BackColor = Color.FromArgb(42, 42, 42);
            customButton7.BackColor = Color.FromArgb(24, 23, 23);
        }

        private void customButton7_Click(object sender, EventArgs e)
        {
            taskStatus = "Uncompleted";
            customButton2.BackColor = Color.FromArgb(24, 23, 23);
            customButton3.BackColor = Color.FromArgb(24, 23, 23);
            customButton5.BackColor = Color.FromArgb(24, 23, 23);
            customButton6.BackColor = Color.FromArgb(24, 23, 23);
            customButton7.BackColor = Color.FromArgb(42, 42, 42);
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            GiaoViecService gv = new GiaoViecService();
            gv.UpdateProcess(taskID, taskStatus, customDateTimePicker1.Value);
            MessageBox.Show("Update successfully");
            this.Close();
        }
    }
}
