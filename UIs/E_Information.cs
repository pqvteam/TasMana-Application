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
            changelanguage();
            languageSelect.SelectedItem = Session.Instance.Language == "en" ? "ENGLISH" : "VIETNAMESE";
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

        private void changelanguage()
        {
            Font font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            Font fontLarger = new Font("Copperplate Gothic Bold", 18);
            Font fontSmaller = new Font("Copperplate Gothic Bold", 10);
            if (Session.Instance.Language == "vi")
            {
                customButton7.Text = "CÔNG VIỆC";
                customButton8.Text = "THỐNG KÊ";
                customButton9.Text = "BÁO CÁO";
                customButton17.Text = "QUẢN LÝ TÀI KHOẢN";
                customButton18.Text = "CƯ DÂN VÀ CĂN HỘ";
                label15.Text = "THÔNG TIN";
                label2.Text = "ĐỔI MẬT KHẨU";
                label1.Text = "ĐĂNG XUẤT";
                fontSmaller = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);

                label8.Text = "HỌ VÀ TÊN";
                label9.Text = "GIỚI TÍNH";
                label10.Text = "NGÀY SINH";
                label11.Text = "ĐỊA CHỈ";
                label13.Text = "CĂN CƯỚC CÔNG DÂN ";
                label14.Text = "SỐ ĐIỆN THOẠI";
                label3.Text = "BỘ PHẬN";
                label4.Text = "NHÓM";
                label5.Text = "VỊ TRÍ";
                label6.Text = "NGÀY BẮT ĐẦU";
                font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);

                EDIT.Text = "CHỈNH SỬA";
                label7.Text = "CHI TIẾT THÔNG TIN CÁ NHÂN";
                heading.Text = "NHÂN VIÊN";
                fontLarger = new Font("Microsoft Sans Serif", 18, FontStyle.Bold);

            }
            else
            {
                customButton7.Text = "WORK";
                customButton8.Text = "STATISTIC";
                customButton9.Text = "REPORT";
                customButton17.Text = "ACCOUNTING MANAGEMENT";
                customButton18.Text = "APARTMENT RESIDENT";
                label15.Text = "INFORMATION";
                label2.Text = "CHANGE PASSWORD";
                label1.Text = "SIGN OUT";
                fontSmaller = new Font("Copperplate Gothic Bold", 10);

                label8.Text = "NAME";
                label9.Text = "GENDER";
                label10.Text = "BIRTHDAY";
                label11.Text = "ADDRESS";
                label13.Text = "CITIZEN ID";
                label14.Text = "MOBILE";
                label3.Text = "DEPARTMENT";
                label4.Text = "GROUP";
                label5.Text = "POSITION";
                label6.Text = "START DATE";
                font = new Font("Copperplate Gothic Bold", 14);

                EDIT.Text = "EDIT";
                label7.Text = "PROFILE DETAILS";
                heading.Text = "EMPLOYEE";
                fontLarger = new Font("Copperplate Gothic Bold", 18);

            }
            customButton7.Font = fontSmaller;
            customButton8.Font = fontSmaller;
            customButton9.Font = fontSmaller;
            customButton17.Font = fontSmaller;
            customButton18.Font = fontSmaller;
            label3.Font = fontSmaller;
            label2.Font = fontSmaller;
            label1.Font = fontSmaller;

            label8.Font = font;
            label9.Font = font;
            label10.Font = font;
            label11.Font = font;
            label13.Font = font;
            label14.Font = font;

            EDIT.Font = fontLarger;
            label7.Font = fontLarger;
            heading.Font = fontLarger;
        }

        private void languageSelect_OnSelectedIndexChanged(object sender, EventArgs e)
        {

            Font font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            Font fontLarger = new Font("Copperplate Gothic Bold", 18);
            Font fontSmaller = new Font("Copperplate Gothic Bold", 10);
            if (languageSelect.SelectedItem.ToString() == "VIETNAMESE")
            {
                Session.Instance.Language = "vi";
                customButton7.Text = "CÔNG VIỆC";
                customButton8.Text = "THỐNG KÊ";
                customButton9.Text = "BÁO CÁO";
                customButton17.Text = "QUẢN LÝ TÀI KHOẢN";
                customButton18.Text = "CƯ DÂN VÀ CĂN HỘ";
                label3.Text = "THÔNG TIN";
                label2.Text = "ĐỔI MẬT KHẨU";
                label1.Text = "ĐĂNG XUẤT";
                fontSmaller = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);

                label8.Text = "HỌ VÀ TÊN";
                label9.Text = "GIỚI TÍNH";
                label10.Text = "NGÀY SINH";
                label11.Text = "ĐỊA CHỈ";
                label13.Text = "CCCD";
                label14.Text = "SỐ ĐIỆN THOẠI";
                label3.Text = "BỘ PHẬN";
                label4.Text = "NHÓM";
                label5.Text = "VỊ TRÍ";
                label6.Text = "NGÀY BẮT ĐẦU";
                font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);

                EDIT.Text = "CHỈNH SỬA";
                label7.Text = "CHI TIẾT THÔNG TIN CÁ NHÂN";
                heading.Text = "NHÂN VIÊN";
                fontLarger = new Font("Microsoft Sans Serif", 18, FontStyle.Bold);

            }
            else
            {
                Session.Instance.Language = "en";
                customButton7.Text = "WORK";
                customButton8.Text = "STATISTIC";
                customButton9.Text = "REPORT";
                customButton17.Text = "ACCOUNTING MANAGEMENT";
                customButton18.Text = "APARTMENT RESIDENT";
                label3.Text = "INFORMATION";
                label2.Text = "CHANGE PASSWORD";
                label1.Text = "SIGN OUT";
                fontSmaller = new Font("Copperplate Gothic Bold", 10);

                label8.Text = "NAME";
                label9.Text = "GENDER";
                label10.Text = "BIRTHDAY";
                label11.Text = "ADDRESS";
                label13.Text = "CITIZEN ID";
                label14.Text = "MOBILE";
                label3.Text = "DEPARTMENT";
                label4.Text = "GROUP";
                label5.Text = "POSITION";
                label6.Text = "START DATE";
                font = new Font("Copperplate Gothic Bold", 14);

                EDIT.Text = "EDIT";
                label7.Text = "PROFILE DETAILS";
                heading.Text = "EMPLOYEE";
                fontLarger = new Font("Copperplate Gothic Bold", 18);
            }
            customButton7.Font = fontSmaller;
            customButton8.Font = fontSmaller;
            customButton9.Font = fontSmaller;
            customButton17.Font = fontSmaller;
            customButton18.Font = fontSmaller;
            label3.Font = fontSmaller;
            label2.Font = fontSmaller;
            label1.Font = fontSmaller;

            label8.Font = font;
            label9.Font = font;
            label10.Font = font;
            label11.Font = font;
            label13.Font = font;
            label14.Font = font;

            EDIT.Font = fontLarger;
            label7.Font = fontLarger;
            heading.Font = fontLarger;
        }

        private void customButton7_Click(object sender, EventArgs e)
        {
            C_AllTaskList c_AllTaskList = new C_AllTaskList();
            c_AllTaskList.ShowDialog();
        }

        private void customButton17_Click(object sender, EventArgs e)
        {
            C_AccountManagement c_AccountManagement = new C_AccountManagement();
            c_AccountManagement.ShowDialog();
        }

        private void customButton18_Click(object sender, EventArgs e)
        {
            CM_Resident_sDetail cM = new CM_Resident_sDetail();
            cM.ShowDialog();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            G_ForgotPassword g_ForgotPassword = new G_ForgotPassword();
            g_ForgotPassword.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            List<Form> formsToClose = new List<Form>();

            foreach (Form form in Application.OpenForms)
            {
                if (form != this) 
                {
                    formsToClose.Add(form);
                }
            }

            foreach (Form form in formsToClose)
            {
                form.Hide();
            }

            G_Login g_Login = new G_Login();
            g_Login.Show();
            foreach (Form form in formsToClose)
            {
                form.Close();
            }
        }
        public void showToast(string type, string message)
        {
            ToastForm show = new ToastForm(type, message);
            show.Show();
        }
    }
}
