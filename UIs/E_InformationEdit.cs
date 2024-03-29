﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Repositories.Entities;
using Repositories.Utilities;
using Services;

namespace UIs
{
    public partial class E_InformationEdit : Form
    {
        string connectionString = @"Data Source=LAPTOP-BQI9C1O9;Initial Catalog=TasMana;Integrated Security=True";
        string managerID = "DV-102";
        public E_InformationEdit()
        {
            InitializeComponent();
        }

        private void E_InformationEdit_Load(object sender, EventArgs e)
        {
            displayEmployeeData();
        }

        private void displayEmployeeData()
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

        private void SUBMIT_Click(object sender, EventArgs e)
        {
            NhanSuService currentEmployee = new NhanSuService();
            NhanSu ns = currentEmployee.findMember(managerID);
            InformationEditUtilities.editInformation(ns.HoVaTen, ns.Sdt, ns.NamSinh, ns.Cccd, ns.Email, ns.DiaChi, ns.GioiTinh);
            MessageBox.Show("Edit successfully");
            E_Information newForm = new E_Information();
            newForm.Show();
            this.Hide();
        }
    }
}
