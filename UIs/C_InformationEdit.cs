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
    public partial class C_InformationEdit : Form
    {
        string managerID = "GD-001";
        public C_InformationEdit()
        {
            InitializeComponent();
        }

        private void C_InformationEdit_Load(object sender, EventArgs e)
        {
            displayCEOData();
        }

        private void displayCEOData()
        {
            NhanSuService currentEmployee = new NhanSuService();
            NhanSu ns = currentEmployee.findMember(managerID);
            UserName.Text = ns.HoVaTen.ToString();
            UserName1.Text = ns.HoVaTen.ToString();
            UserID.Text = ns.MaThanhVien.ToString();
            Gender.Text = ns.GioiTinh.ToString();
            Birth.Text = ns.NamSinh.ToString();
            Add.Text = ns.DiaChi.ToString();
            CID.Text = ns.Cccd.ToString();
            Email.Text = ns.Email.ToString();
            Number.Text = ns.Sdt.ToString();
        }

        private void SUBMIT_Click(object sender, EventArgs e)
        {
            NhanSuService nhanSuService = new NhanSuService();
            NhanSu ns = nhanSuService.findMember(managerID);
            bool isSuccess = nhanSuService.updateInformation(managerID, UserName.Text, Number.Text, Birth.Value.ToString("yyyyMMdd"), CID.Text, Email.Text, Add.Text, Gender.Text);
            if (isSuccess)
            {
                MessageBox.Show("Successfully");
                this.Close();
            }
        }
    }
}
