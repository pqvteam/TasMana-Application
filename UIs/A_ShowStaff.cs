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
    public partial class A_ShowStaff : Form
    {
        NhanVienService nhanVienService = new NhanVienService();
        NhanSuService nhanSuService = new NhanSuService();

        private string selectedStaffId;

        public event Action<string> StaffSelected;

        private void membersGrid_RowContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedStaffId = membersGrid.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedStaffId))
            {
                StaffSelected?.Invoke(selectedStaffId);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a member first.");
            }
        }

        public A_ShowStaff()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void A_ShowStaff_Load(object sender, EventArgs e)
        {
            membersGrid.Columns.Add("Avatar", "Avatar");
            membersGrid.Columns.Add("ID", "ID");
            membersGrid.Columns.Add("Name", "Name");
            membersGrid.Columns.Add("Team", "Team ID");
            membersGrid.Columns.Add("Leader", "Is leader");
            List<NhanVien> members = nhanVienService.getAllStaffOfDepartments("VS");
            foreach (NhanVien member in members)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(membersGrid);
                row.Cells[0].Value = "";
                row.Cells[1].Value = member.MaThanhVien;
                row.Cells[2].Value = nhanSuService.findMember(member.MaThanhVien).HoVaTen;
                row.Cells[3].Value = member.MaNhom;
                row.Cells[4].Value = member.LaTruongNhom == true ? "Yes" : "No";

                membersGrid.Rows.Add(row);
            }
        }

        private void hrButton_Click(object sender, EventArgs e)
        {
            membersGrid.Rows.Clear();
            List<NhanVien> members = nhanVienService.getAllStaffOfDepartments("VS");
            foreach (NhanVien member in members)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(membersGrid);
                row.Cells[0].Value = "";
                row.Cells[1].Value = member.MaThanhVien;
                row.Cells[2].Value = nhanSuService.findMember(member.MaThanhVien).HoVaTen;
                row.Cells[3].Value = member.MaNhom;
                row.Cells[4].Value = member.LaTruongNhom == true ? "Yes" : "No";
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
            List<NhanVien> members = nhanVienService.getAllStaffOfDepartments("AN");
            foreach (NhanVien member in members)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(membersGrid);
                row.Cells[0].Value = "";
                row.Cells[1].Value = member.MaThanhVien;
                row.Cells[2].Value = nhanSuService.findMember(member.MaThanhVien).HoVaTen;
                row.Cells[3].Value = member.MaNhom;
                row.Cells[4].Value = member.LaTruongNhom == true ? "Yes" : "No";
                membersGrid.Rows.Add(row);
            }
        }

        private void maButton_Click(object sender, EventArgs e)
        {
            membersGrid.Rows.Clear();
            List<NhanVien> members = nhanVienService.getAllStaffOfDepartments("KT");
            foreach (NhanVien member in members)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(membersGrid);
                row.Cells[0].Value = "";
                row.Cells[1].Value = member.MaThanhVien;
                row.Cells[2].Value = nhanSuService.findMember(member.MaThanhVien).HoVaTen;
                row.Cells[3].Value = member.MaNhom;
                row.Cells[4].Value = member.LaTruongNhom == true ? "Yes" : "No";
                membersGrid.Rows.Add(row);
            }
        }

        private void coButton_Click(object sender, EventArgs e)
        {
            membersGrid.Rows.Clear();
            List<NhanVien> members = nhanVienService.getAllStaffOfDepartments("XD");
            foreach (NhanVien member in members)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(membersGrid);
                row.Cells[0].Value = "";
                row.Cells[1].Value = member.MaThanhVien;
                row.Cells[2].Value = nhanSuService.findMember(member.MaThanhVien).HoVaTen;
                row.Cells[3].Value = member.MaNhom;
                row.Cells[4].Value = member.LaTruongNhom == true ? "Yes" : "No";
                membersGrid.Rows.Add(row);
            }
        }

        private void fiButton_Click(object sender, EventArgs e)
        {
            membersGrid.Rows.Clear();
            List<NhanVien> members = nhanVienService.getAllStaffOfDepartments("TC");
            foreach (NhanVien member in members)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells[0].Value = "";
                row.Cells[1].Value = member.MaThanhVien;
                row.Cells[2].Value = nhanSuService.findMember(member.MaThanhVien).HoVaTen;
                row.Cells[3].Value = member.MaNhom;
                row.Cells[4].Value = member.LaTruongNhom == true ? "Yes" : "No";
                membersGrid.Rows.Add(row);
            }
        }

        private void saButton_Click(object sender, EventArgs e)
        {
            membersGrid.Rows.Clear();
            List<NhanVien> members = nhanVienService.getAllStaffOfDepartments("VS");
            foreach (NhanVien member in members)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(membersGrid);
                row.Cells[0].Value = "";
                row.Cells[1].Value = member.MaThanhVien;
                row.Cells[2].Value = nhanSuService.findMember(member.MaThanhVien).HoVaTen;
                row.Cells[3].Value = member.MaNhom;
                row.Cells[4].Value = member.LaTruongNhom == true ? "Yes" : "No";
                membersGrid.Rows.Add(row);
            }
        }
    }
}
