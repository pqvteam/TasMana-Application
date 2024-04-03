﻿using System;
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
    public partial class M_Information : Form
    {
        string managerID = "DV-101";
        public M_Information()
        {
            InitializeComponent();
        }

        private void M_Information_Load(object sender, EventArgs e)
        {
            displayManagerData();
        }

        private void displayManagerData()
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

        private void EDIT_Click(object sender, EventArgs e)
        {
            M_InformationEdit newForm = new M_InformationEdit();
            newForm.ShowDialog();
            displayManagerData();
        }
    }
}
