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
    public partial class C_AllTaskList : Form
    {
        GiaoViecService giaoViecService = new GiaoViecService();
        public C_AllTaskList()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void rjTextBox2__TextChanged(object sender, EventArgs e)
        {
        }

        private void customDateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void C_AllTaskList_Load(object sender, EventArgs e)
        {

            membersGrid.Columns.Add("MaGiaoViec", "MaGiaoViec");
            membersGrid.Columns.Add("TenCongViec", "TenCongViec");
            membersGrid.Columns.Add("MoTaCongViec", "MoTaCongViec");
            membersGrid.Columns.Add("NgayGiao", "NgayGiao");
            List<GiaoViec> members = giaoViecService.getAll();
            foreach (GiaoViec member in members)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(membersGrid);
                row.Cells[0].Value = member.MaGiaoViec;
                row.Cells[1].Value = member.TenCongViec;
                row.Cells[2].Value = member.MoTaCongViec;
                row.Cells[3].Value = member.NgayGiao;
                membersGrid.Rows.Add(row);
            }
        }

        private void hrButton_Click(object sender, EventArgs e)
        {
            membersGrid.Rows.Clear();
            List<GiaoViec> members = giaoViecService.getTaskOfDeparment("DV");
            foreach (GiaoViec member in members)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(membersGrid);
                row.Cells[0].Value = member.MaGiaoViec;
                row.Cells[1].Value = member.TenCongViec;
                row.Cells[2].Value = member.MoTaCongViec;
                row.Cells[3].Value = member.NgayGiao;
                membersGrid.Rows.Add(row);
            }
        }

        private void seButton_Click(object sender, EventArgs e)
        {
            membersGrid.Rows.Clear();
            List<GiaoViec> members = giaoViecService.getTaskOfDeparment("AN");
            foreach (GiaoViec member in members)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(membersGrid);
                row.Cells[0].Value = member.MaGiaoViec;
                row.Cells[1].Value = member.TenCongViec;
                row.Cells[2].Value = member.MoTaCongViec;
                row.Cells[3].Value = member.NgayGiao;
                membersGrid.Rows.Add(row);
            }
        }

        private void customButton18_Click(object sender, EventArgs e)
        {
            membersGrid.Rows.Clear();
            List<GiaoViec> members = giaoViecService.getAll();
            foreach (GiaoViec member in members)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(membersGrid);
                row.Cells[0].Value = member.MaGiaoViec;
                row.Cells[1].Value = member.TenCongViec;
                row.Cells[2].Value = member.MoTaCongViec;
                row.Cells[3].Value = member.NgayGiao;
                membersGrid.Rows.Add(row);
            }
        }

        private void maButton_Click(object sender, EventArgs e)
        {
            membersGrid.Rows.Clear();
            List<GiaoViec> members = giaoViecService.getTaskOfDeparment("KT");
            foreach (GiaoViec member in members)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(membersGrid);
                row.Cells[0].Value = member.MaGiaoViec;
                row.Cells[1].Value = member.TenCongViec;
                row.Cells[2].Value = member.MoTaCongViec;
                row.Cells[3].Value = member.NgayGiao;
                membersGrid.Rows.Add(row);
            }
        }

        private void coButton_Click(object sender, EventArgs e)
        {
            membersGrid.Rows.Clear();
            List<GiaoViec> members = giaoViecService.getTaskOfDeparment("XD");
            foreach (GiaoViec member in members)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(membersGrid);
                row.Cells[0].Value = member.MaGiaoViec;
                row.Cells[1].Value = member.TenCongViec;
                row.Cells[2].Value = member.MoTaCongViec;
                row.Cells[3].Value = member.NgayGiao;
                membersGrid.Rows.Add(row);
            }
        }

        private void fiButton_Click(object sender, EventArgs e)
        {
            membersGrid.Rows.Clear();
            List<GiaoViec> members = giaoViecService.getTaskOfDeparment("TC");
            foreach (GiaoViec member in members)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(membersGrid);
                row.Cells[0].Value = member.MaGiaoViec;
                row.Cells[1].Value = member.TenCongViec;
                row.Cells[2].Value = member.MoTaCongViec;
                row.Cells[3].Value = member.NgayGiao;
                membersGrid.Rows.Add(row);
            }
        }

        private void saButton_Click(object sender, EventArgs e)
        {
            membersGrid.Rows.Clear();
            List<GiaoViec> members = giaoViecService.getTaskOfDeparment("VS");
            foreach (GiaoViec member in members)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(membersGrid);
                row.Cells[0].Value = member.MaGiaoViec;
                row.Cells[1].Value = member.TenCongViec;
                row.Cells[2].Value = member.MoTaCongViec;
                row.Cells[3].Value = member.NgayGiao;
                membersGrid.Rows.Add(row);
            }
        }
    }
}
