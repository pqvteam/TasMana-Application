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
        NhanVienService employee = new NhanVienService();

        public E_Information()
        {
            InitializeComponent();
        }

        private void E_Information_Load(object sender, EventArgs e)
        {
            displayEmployeeData();
            if (IsValidImageData(Session.Instance.Avatar))
            {
                currentAvatarSmall.Image = convertByteToImage(Session.Instance.Avatar);
            }
        }

        private void displayEmployeeData()
        {
            // UserID
            string managerID = Session.Instance.UserName;

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
            if (ns.AnhDaiDien != null && IsValidImageData(ns.AnhDaiDien))
            {
                avatarBox.Image = convertByteToImage(ns.AnhDaiDien);
            }

            if (employee.checkLeader(ns.MaThanhVien))
            {
                Position.Text = "Trưởng nhóm";
            }
            else
            {
                Position.Text = "Thành viên";
            }

            NhanVien nv = employee.get(managerID);

            if (!Session.Instance.laQuanLi && !Session.Instance.laCEO)
            {
                PhongBanService currentDepartment = new PhongBanService();
                PhongBan pb = currentDepartment.getDepartment(nv.MaPb);

                Department.Text = pb.TenPb.ToString();

                NhomService groupService = new NhomService();
                Nhom? group = groupService.findGroup(nv.MaNhom);


                if (group != null)
                {
                    Group.Text = group?.TenNhom.ToString();
                }
                else
                {
                    Group.Text = "";
                }
            }
        }

        private bool IsValidImageData(byte[] imageData)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    Image.FromStream(ms);
                }
                return true; // Image data is valid
            }
            catch (Exception)
            {
                return false; // Image data is not valid
            }
        }

        private void EDIT_Click(object sender, EventArgs e)
        {
            E_InformationEdit newForm = new E_InformationEdit();
            newForm.ShowDialog();
            displayEmployeeData();
        }

        public Image convertByteToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        private void customButton22_Click_1(object sender, EventArgs e)
        {
            if (tableLayoutPanel1.Visible == false)
            {
                tableLayoutPanel1.Visible = true;
            }
            else
            {
                tableLayoutPanel1.Visible = false;
            }
        }
    }
}
