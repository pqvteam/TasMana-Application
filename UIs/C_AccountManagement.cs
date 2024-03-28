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
    public partial class C_AccountManagement : Form
    {
        NhanSuService nhanSuService = new NhanSuService();
        public C_AccountManagement()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void C_AccountManagement_Load(object sender, EventArgs e)
        {
            // Tạo các cột cho DataGridView
            membersGrid.Columns.Add("ID", "ID");
            membersGrid.Columns.Add("Name", "Name");
            membersGrid.Columns.Add("Department", "Department");
            membersGrid.Columns.Add("Startdate", "Start Date");
            membersGrid.Columns.Add("Enddate", "Is Still Member");

            // Lấy danh sách thành viên
            List<NhanSu> members = nhanSuService.getAllMembers();

            // Đổ dữ liệu vào DataGridView
            foreach (var member in members)
            {
                membersGrid.Rows.Add(member.MaThanhVien, member.HoVaTen, member.Email, member.NgayBatDau, member.NghiViec);
            }
        }

        private void customComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void customPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
