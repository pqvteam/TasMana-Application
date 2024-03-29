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
            CeoService ceoService = new CeoService();
            QuanLyService quanLyService = new QuanLyService();
            membersGrid.Columns.Add("ID", "ID");
            membersGrid.Columns.Add("Name", "Name");
            membersGrid.Columns.Add("Type Account", "Type Account");
            membersGrid.Columns.Add("Department", "Department");
            membersGrid.Columns.Add("Role", "Role");
            membersGrid.Columns.Add("Startdate", "Start Date");

            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Appoint";
            btnColumn.Text = "Appoint";
            btnColumn.Name = "btnAppoint";
            btnColumn.UseColumnTextForButtonValue = true;
            membersGrid.Columns.Add(btnColumn);

            membersGrid.Columns.Add("Fired", "Fired");

            List<NhanSu> members = nhanSuService.getAllMembers();

            foreach (var member in members)
            {
                string role = "Staff";
                if (ceoService.getCeo(member.MaThanhVien) != null)
                {
                    role = "CEO";
                } else if (quanLyService.findManager(member.MaThanhVien) != null)
                {
                    role = "Manager";
                }
                string departmentID = member.MaThanhVien.Split("-")[0];
                membersGrid.Rows.Add(member.MaThanhVien, member.HoVaTen, role, departmentID, role, member.NgayBatDau, member.NghiViec);
            }
        }


        private void customComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void customPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void membersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
