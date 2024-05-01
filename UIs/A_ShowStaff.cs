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
                showToast("WARNING", "Please select a member first.");
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
            changelanguage();

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
            List<NhanVien> members = nhanVienService.getAllStaffOfDepartments("DV");
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
                row.CreateCells(membersGrid);
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

        private void changelanguage()
        {
            Font font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            Font fontSmaller = new Font("Copperplate Gothic Bold", 9);
            if (Session.Instance.Language == "vi")
            {
                customButton10.Text = "NGƯỜI THỰC HIỆN";
                customButton10.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);

                hrButton.Text = "DỊCH VỤ";   
                seButton.Text = "AN NINH";
                maButton.Text = "BẢO TRÌ";
                coButton.Text = "XÂY DỰNG";
                fiButton.Text = "TÀI CHÍNH";
                saButton.Text = "VỆ SINH";
                cancelButton.Text = "HỦY";
                customButton8.Text = "LƯU";
                fontSmaller = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
            }
            else
            {
                customButton10.Text = "IMPLEMENTOR";
                customButton10.Font = new Font("Copperplate Gothic Bold", 14);

                hrButton.Text = "HR_RS";
                seButton.Text = "SECURITY";
                maButton.Text = "MAINTAINANCE";
                coButton.Text = "CONSTRUCTION";
                fiButton.Text = "FINANCIAL ACOUNTING";
                saButton.Text = "SANTINATION";
                cancelButton.Text = "CANCEL";
                customButton8.Text = "SAVE";
                fontSmaller = new Font("Copperplate Gothic Bold", 9);
            }

            hrButton.Font = fontSmaller;
            seButton.Font = fontSmaller;
            maButton.Font = fontSmaller;
            coButton.Font = fontSmaller;
            fiButton.Font = fontSmaller;
            saButton.Font = fontSmaller;
            cancelButton.Font = fontSmaller;
            customButton8.Font = fontSmaller;
        }
        public void showToast(string type, string message)
        {
            ToastForm show = new ToastForm(type, message);
            show.Show();
        }
    }
}
