using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using Repositories.Entities;
using Services;

namespace UIs
{
    public partial class E_Information : Form
    {
        public E_Information()
        {
            InitializeComponent();
        }

        private void E_Information_Load(object sender, EventArgs e)
        {
            displayEmployeeData();
        }

        private void displayEmployeeData()
        {
            // UserID
            string managerID = "DV-102";

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
            StartDate.Text = ns.NgayBatDau.ToString();

            if (ns.LaQuanLi)
            {
                Position.Text = "Trưởng nhóm";
            }
            else
            {
                Position.Text = "Thành viên";
            }

            NhanVienService employee = new NhanVienService();
            NhanVien nv = employee.get(managerID);

            PhongBanService currentDepartment = new PhongBanService();
            PhongBan pb = currentDepartment.getDepartment(nv.MaPb);

            Department.Text = pb.TenPb.ToString();

            NhomService groupService = new NhomService();
            Nhom group = groupService.findGroup(nv.MaNhom);

            Group.Text = group.TenNhom.ToString();
        }

        private void EDIT_Click(object sender, EventArgs e)
        {
            E_InformationEdit newForm = new E_InformationEdit();
            newForm.ShowDialog();
            displayEmployeeData();
        }
    }
}
