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
using UIs.CustomComponent;

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
            changelanguage();

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
            showToast("SUCCESS", "Update successfully");

            this.Close();
        }
        public void showToast(string type, string message)
        {
            ToastForm show = new ToastForm(type, message);
            show.Show();
        }

        private void changelanguage()
        {
            Font font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            Font fontSmaller = new Font("Copperplate Gothic Bold", 10);
            if (Session.Instance.Language == "vi")
            {
                label1.Text = "CẬP NHẬT TIẾN ĐỘ";
                label1.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);

                idLabel.Text = "TRẠNG THÁI";
                label3.Text = "NGÀY";
                cancelButton.Text = "HỦY";
                confirmButton.Text = "LƯU";
                fontSmaller = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);

                customButton2.Text = "ĐÃ HOÀN THÀNH";
                customButton3.Text = "CHƯA THỰC HIỆN/CHƯA BẮT ĐẦU";
                customButton5.Text = "ĐANG TIẾN HÀNH";
                customButton6.Text = "ĐỔI LỊCH KHÁCH HÀNG";
                font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            }
            else
            {
                label1.Text = "UPDATE PROCESS";
                label1.Font = new Font("Copperplate Gothic Bold", 14);

                idLabel.Text = "STATUS";
                label3.Text = "DATE";
                cancelButton.Text = "CANCEL";
                confirmButton.Text = "SAVE";
                fontSmaller = new Font("Copperplate Gothic Bold", 10);

                customButton2.Text = "COMPLETED";
                customButton3.Text = "UNEXECUTED/NOT YET STARTED";
                customButton5.Text = "PROCESSING";
                customButton6.Text = "CUSTOMER RESCHEDULE";
                font = new Font("Copperplate Gothic Bold", 12);
            }
            idLabel.Font = fontSmaller;
            label3.Font = fontSmaller;
            cancelButton.Font = fontSmaller;
            confirmButton.Font = fontSmaller;

            customButton2.Font = font;
            customButton3.Font = font;
            customButton5.Font = font;
            customButton6.Font = font;
        }
    }

}
