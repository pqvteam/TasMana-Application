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
    public partial class A_ShowMember : Form
    {
        NhanSuService nhanSuService = new NhanSuService();

        private string selectedMemberId;

        public event Action<string> MemberSelected;

        private void membersGrid_RowContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedMemberId = membersGrid.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedMemberId))
            {
                MemberSelected?.Invoke(selectedMemberId);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a member first.");
            }
        }

        public A_ShowMember()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void A_ShowMember_Load(object sender, EventArgs e)
        {
            membersGrid.Columns.Add("Avatar", "Avatar");
            membersGrid.Columns.Add("ID", "ID");
            membersGrid.Columns.Add("Name", "Full Name");
            membersGrid.Columns.Add("Manager", "Is manager");
            List<NhanSu> members = nhanSuService.getAllMembersOfDepartment("VS");
            foreach (NhanSu member in members)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(membersGrid);
                row.Cells[0].Value = "";
                row.Cells[1].Value = member.MaThanhVien;
                row.Cells[2].Value = member.HoVaTen;
                row.Cells[3].Value = member.LaQuanLi == true ? "Yes" : "No";

                membersGrid.Rows.Add(row);
            }
        }

        private void hrButton_Click(object sender, EventArgs e)
        {
            membersGrid.Rows.Clear();
            List<NhanSu> members = nhanSuService.getAllMembersOfDepartment("DV");
            foreach (NhanSu member in members)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(membersGrid);
                row.Cells[0].Value = "";
                row.Cells[1].Value = member.MaThanhVien;
                row.Cells[2].Value = member.HoVaTen;
                row.Cells[3].Value = member.LaQuanLi == true ? "Yes" : "No";

                membersGrid.Rows.Add(row);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void seButton_Click(object sender, EventArgs e)
        {
            membersGrid.Rows.Clear();
            List<NhanSu> members = nhanSuService.getAllMembersOfDepartment("AN");
            foreach (NhanSu member in members)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(membersGrid);
                row.Cells[0].Value = "";
                row.Cells[1].Value = member.MaThanhVien;
                row.Cells[2].Value = member.HoVaTen;
                row.Cells[3].Value = member.LaQuanLi == true ? "Yes" : "No";

                membersGrid.Rows.Add(row);
            }
        }

        private void maButton_Click(object sender, EventArgs e)
        {
            membersGrid.Rows.Clear();
            List<NhanSu> members = nhanSuService.getAllMembersOfDepartment("KT");
            foreach (NhanSu member in members)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(membersGrid);
                row.Cells[0].Value = "";
                row.Cells[1].Value = member.MaThanhVien;
                row.Cells[2].Value = member.HoVaTen;
                row.Cells[3].Value = member.LaQuanLi == true ? "Yes" : "No";

                membersGrid.Rows.Add(row);
            }
        }

        private void coButton_Click(object sender, EventArgs e)
        {
            membersGrid.Rows.Clear();
            List<NhanSu> members = nhanSuService.getAllMembersOfDepartment("XD");
            foreach (NhanSu member in members)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(membersGrid);
                row.Cells[0].Value = "";
                row.Cells[1].Value = member.MaThanhVien;
                row.Cells[2].Value = member.HoVaTen;
                row.Cells[3].Value = member.LaQuanLi == true ? "Yes" : "No";

                membersGrid.Rows.Add(row);
            }
        }

        private void fiButton_Click(object sender, EventArgs e)
        {
            membersGrid.Rows.Clear();
            List<NhanSu> members = nhanSuService.getAllMembersOfDepartment("TC");
            foreach (NhanSu member in members)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(membersGrid);
                row.Cells[0].Value = "";
                row.Cells[1].Value = member.MaThanhVien;
                row.Cells[2].Value = member.HoVaTen;
                row.Cells[3].Value = member.LaQuanLi == true ? "Yes" : "No";

                membersGrid.Rows.Add(row);
            }
        }

        private void saButton_Click(object sender, EventArgs e)
        {
            membersGrid.Rows.Clear();
            List<NhanSu> members = nhanSuService.getAllMembersOfDepartment("VS");
            foreach (NhanSu member in members)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(membersGrid);
                row.Cells[0].Value = "";
                row.Cells[1].Value = member.MaThanhVien;
                row.Cells[2].Value = member.HoVaTen;
                row.Cells[3].Value = member.LaQuanLi == true ? "Yes" : "No";
                membersGrid.Rows.Add(row);
            }
        }
    }
}
