using Repositories.Entities;
using Services;
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
    public partial class A_TaskDetail : Form
    {
        private string currentID;
        GiaoViecService giaoViecService = new GiaoViecService();
        public A_TaskDetail()
        {
            InitializeComponent();
        }

        public A_TaskDetail(string ID)
        {
            this.currentID = ID;
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void A_TaskDetail_Load(object sender, EventArgs e)
        {
            List<GiaoViec> tasks = giaoViecService.getAll();
            foreach (GiaoViec task in tasks)
            {
                taskIDBox.Items.Add(task.MaGiaoViec);
            }
            taskIDBox.SelectedItem = currentID;
        }

        private void taskIDBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (taskIDBox.SelectedIndex != -1)
            {
                GiaoViec task = giaoViecService.findAssignedTask(taskIDBox.SelectedItem.ToString());
                nameContent.Text = task.TenCongViec;
                idContent.Text = task.MaGiaoViec;
                statusContent.Text = task.TinhTrangCongViec;
                descriptionContent.Text = task.MoTaCongViec;
                startContent.Text = task.NgayGiao.ToString("dd/MM/yyyy");
                endContent.Text = task.HanHoanThanh.ToString("dd/MM/yyyy");
                publicToContent.Text = task.CheDo == true ? "All" : task.PhongBanChoPhep != null ? task.PhongBanChoPhep : "No";
                intimeContent.Text = (task.DungHan == false || task.DungHan == null) ? "False" : "True";
                assignByContent.Text = task.MaGiaoViec.Split('.')[0];
            }
        }

        private void intimeContent_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
