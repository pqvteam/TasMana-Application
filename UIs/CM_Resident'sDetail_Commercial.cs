﻿using Services;
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
    public partial class CM_Resident_sDetail_Commercial : Form
    {
        public CM_Resident_sDetail_Commercial()
        {
            InitializeComponent();
        }

        private void CM_Resident_sDetail_Commercial_Load(object sender, EventArgs e)
        {
            changelanguage();
            languageSelect.SelectedItem = Session.Instance.Language == "en" ? "ENGLISH" : "VIETNAMESE";

            CuDanService service = new CuDanService();
            List<string> list = service.getCuDanCommercialIDs();
            foreach (string id in list)
            {
                IDBox.Items.Add(id);
            }
        }

        private void customButton13_Click(object sender, EventArgs e)
        {
            if (Session.Instance.UserName.Contains("GD") || Session.Instance.laQuanLi)
            {
                M_Information information = new M_Information();
                information.ShowDialog();
            }
            else
            {
                E_Information information = new E_Information();
                information.ShowDialog();
            }
        }

        private void customButton14_Click(object sender, EventArgs e)
        {
            if (tableLayoutPanel3.Visible == false)
            {
                tableLayoutPanel3.Visible = true;
            }
            else
            {
                tableLayoutPanel3.Visible = false;
            }
        }

        private void changelanguage()
        {
            Font font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            Font fontLarger = new Font("Copperplate Gothic Bold", 11);
            if (Session.Instance.Language == "vi")
            {
                customButton7.Text = "CÔNG VIỆC";
                customButton8.Text = "THỐNG KÊ";
                customButton9.Text = "BÁO CÁO";
                customButton17.Text = "QUẢN LÝ TÀI KHOẢN";
                customButton18.Text = "CƯ DÂN VÀ CĂN HỘ";
                label32.Text = "THÔNG TIN";
                label31.Text = "ĐỔI MẬT KHẨU";
                label30.Text = "ĐĂNG XUẤT";
                customButton_ApartmentList.Text = "DANH SÁCH CĂN HỘ";
                customButton2.Text = "CHỦ HỘ";
                customButton3.Text = "ĐƯỢC ỦY QUYỀN";
                customButton4.Text = "KHÁCH THUÊ";
                customButton5.Text = "KHÁCH THUÊ KHU THƯƠNG MẠI";
                customButton1.Text = "MÃ CĂN HỘ";
                customButton15.Text = "TÊN CƯ DÂN";
                customButton19.Text = "NGÀY SINH";
                customButton20.Text = "QUỐC TỊCH";
                customButton21.Text = "SỐ ĐIỆN THOẠI";
                font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);

                label7.Text = "SỐ THẺ TẠM TRÚ";
                label9.Text = "NGÀY CHUYỂN VÀO";
                label11.Text = "NGÀY CHUYỂN ĐI";
                label13.Text = "THÔNG TIN LƯU TRÚ";
                label6.Text = "THÔNG TIN QUẢN LÝ/ NHÂN VIÊN PHỤ TRÁCH CỦA ĐƠN VỊ/ CÁ NHÂN ĐANG THUÊ KHU THƯƠNG MẠI";
                label15.Text = "DỮ LIỆU ĐIỆN, NƯỚC PHÁT SINH HÀNG THÁNG";
                label17.Text = "PHÍ DỊCH VỤ QUẢN LÝ HÀNG THÁNG";
                label19.Text = "PHÍ DỊCH VỤ KHÁC";
                label21.Text = "DỮ LIỆU XE ĐĂNG KÝ GIỮ XE TẠI NHÀ";
                label23.Text = "SỐ ĐIỆN THOẠI NGƯỜI THÂN";
                label25.Text = "TÌNH TRẠNG CÔNG NỢ";
                label27.Text = "DỮ LIỆU NUÔI THÚ CƯNG";
                fontLarger = new Font("Microsoft Sans Serif", 11, FontStyle.Bold);

                label29.Text = "CHI TIẾT CƯ DÂN";
                label29.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Bold);
            }
            else
            {
                customButton7.Text = "WORK";
                customButton8.Text = "STATISTIC";
                customButton9.Text = "REPORT";
                customButton17.Text = "ACCOUNT MANAGEMENT";
                customButton18.Text = "DEPARTMENT RESIDENT";
                label32.Text = "INFORMATION";
                label31.Text = "CHANGE PASSWORD";
                label30.Text = "SIGN OUT";
                customButton_ApartmentList.Text = "APARTMENT LIST";
                customButton2.Text = "HOLDHOUSE";
                customButton3.Text = "AUTHORIZED";
                customButton4.Text = "TENANT/STAFF OF";
                customButton5.Text = "COMMERCIAL";
                customButton1.Text = "APARTMENT ID";
                customButton15.Text = "RESIDENT'S NAME";
                customButton19.Text = "BIRTHDAY";
                customButton20.Text = "NATIONALITY";
                customButton21.Text = "PHONE";
                font = new Font("Copperplate Gothic Bold", 10);

                label7.Text = "TEMPORARY RESIDENT CARD NUMBER";
                label9.Text = "MOVING DATE";
                label11.Text = "LEAVING DATE";
                label13.Text = "ACCOMMODATION INFORMATION";
                label6.Text = "MANAGEMENT INFORMATION/STAFF IN RESPONSE OF THE UNIT/INDIVIDUAL THAT IS RENTING THE COMMERCIAL AREA";
                label15.Text = "ELECTRICITY AND WATER DATA ARISING MONTHLY";
                label17.Text = "MONTHLY MANAGEMENT SERVICE FEE";
                label19.Text = "OTHER SERVICE FEES";
                label21.Text = "VEHICLE DATA FOR PARKING REGISTRATION AT HOME";
                label23.Text = "TELEPHONE NUMBERS OF RELATIVES";
                label25.Text = "DEBT STATUS";
                label27.Text = "PET KEEPING DATA";
                fontLarger = new Font("Copperplate Gothic Bold", 10);

                label29.Text = "RESIDENT'S DETAILS";
                label29.Font = new Font("Copperplate Gothic Bold", 18);
            }
            customButton7.Font = font;
            customButton8.Font = font;
            customButton9.Font = font;
            customButton17.Font = font;
            customButton18.Font = font;
            label32.Font = font;
            label31.Font = font;
            label30.Font = font;
            customButton_ApartmentList.Font = font;
            customButton2.Font = font;
            customButton3.Font = font;
            customButton4.Font = font;
            customButton5.Font = font;
            customButton1.Font = font;
            customButton15.Font = font;
            customButton19.Font = font;
            customButton20.Font = font;
            customButton21.Font = font;

            label7.Font = fontLarger;
            label9.Font = fontLarger;
            label11.Font = fontLarger;
            label13.Font = fontLarger;
            label6.Font = fontLarger;
            label15.Font = fontLarger;
            label17.Font = fontLarger;
            label19.Font = fontLarger;
            label21.Font = fontLarger;
            label23.Font = fontLarger;
            label25.Font = fontLarger;
            label27.Font = fontLarger;
        }

        private void languageSelect_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            Font font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            Font fontLarger = new Font("Copperplate Gothic Bold", 11);
            if (languageSelect.SelectedItem.ToString() == "VIETNAMESE")
            {
                Session.Instance.Language = "vi";
                customButton7.Text = "CÔNG VIỆC";
                customButton8.Text = "THỐNG KÊ";
                customButton9.Text = "BÁO CÁO";
                customButton17.Text = "QUẢN LÝ TÀI KHOẢN";
                customButton18.Text = "CƯ DÂN VÀ CĂN HỘ";
                label32.Text = "THÔNG TIN";
                label31.Text = "ĐỔI MẬT KHẨU";
                label30.Text = "ĐĂNG XUẤT";
                customButton_ApartmentList.Text = "DANH SÁCH CĂN HỘ";
                customButton2.Text = "CHỦ HỘ";
                customButton3.Text = "ĐƯỢC ỦY QUYỀN";
                customButton4.Text = "KHÁCH THUÊ";
                customButton5.Text = "KHÁCH THUÊ KHU THƯƠNG MẠI";
                customButton1.Text = "MÃ CĂN HỘ";
                customButton15.Text = "TÊN CƯ DÂN";
                customButton19.Text = "NGÀY SINH";
                customButton20.Text = "QUỐC TỊCH";
                customButton21.Text = "SỐ ĐIỆN THOẠI";
                font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);

                label7.Text = "SỐ THẺ TẠM TRÚ";
                label9.Text = "NGÀY CHUYỂN VÀO";
                label11.Text = "NGÀY CHUYỂN ĐI";
                label13.Text = "THÔNG TIN LƯU TRÚ";
                label6.Text = "THÔNG TIN QUẢN LÝ/ NHÂN VIÊN PHỤ TRÁCH CỦA ĐƠN VỊ/ CÁ NHÂN ĐANG THUÊ KHU THƯƠNG MẠI";
                label15.Text = "DỮ LIỆU ĐIỆN, NƯỚC PHÁT SINH HÀNG THÁNG";
                label17.Text = "PHÍ DỊCH VỤ QUẢN LÝ HÀNG THÁNG";
                label19.Text = "PHÍ DỊCH VỤ KHÁC";
                label21.Text = "DỮ LIỆU XE ĐĂNG KÝ GIỮ XE TẠI NHÀ";
                label23.Text = "SỐ ĐIỆN THOẠI NGƯỜI THÂN";
                label25.Text = "TÌNH TRẠNG CÔNG NỢ";
                label27.Text = "DỮ LIỆU NUÔI THÚ CƯNG";
                fontLarger = new Font("Microsoft Sans Serif", 11, FontStyle.Bold);

                label29.Text = "CHI TIẾT CƯ DÂN";
                label29.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Bold);
            }
            else
            {
                Session.Instance.Language = "en";
                customButton7.Text = "WORK";
                customButton8.Text = "STATISTIC";
                customButton9.Text = "REPORT";
                customButton17.Text = "ACCOUNT MANAGEMENT";
                customButton18.Text = "DEPARTMENT RESIDENT";
                label32.Text = "INFORMATION";
                label31.Text = "CHANGE PASSWORD";
                label30.Text = "SIGN OUT";
                customButton_ApartmentList.Text = "APARTMENT LIST";
                customButton2.Text = "HOLDHOUSE";
                customButton3.Text = "AUTHORIZED";
                customButton4.Text = "TENANT/STAFF OF";
                customButton5.Text = "COMMERCIAL";
                customButton1.Text = "APARTMENT ID";
                customButton15.Text = "RESIDENT'S NAME";
                customButton19.Text = "BIRTHDAY";
                customButton20.Text = "NATIONALITY";
                customButton21.Text = "PHONE";
                font = new Font("Copperplate Gothic Bold", 10);

                label7.Text = "TEMPORARY RESIDENT CARD NUMBER";
                label9.Text = "MOVING DATE";
                label11.Text = "LEAVING DATE";
                label13.Text = "ACCOMMODATION INFORMATION";
                label6.Text = "MANAGEMENT INFORMATION/STAFF IN RESPONSE OF THE UNIT/INDIVIDUAL THAT IS RENTING THE COMMERCIAL AREA";
                label15.Text = "ELECTRICITY AND WATER DATA ARISING MONTHLY";
                label17.Text = "MONTHLY MANAGEMENT SERVICE FEE";
                label19.Text = "OTHER SERVICE FEES";
                label21.Text = "VEHICLE DATA FOR PARKING REGISTRATION AT HOME";
                label23.Text = "TELEPHONE NUMBERS OF RELATIVES";
                label25.Text = "DEBT STATUS";
                label27.Text = "PET KEEPING DATA";
                fontLarger = new Font("Copperplate Gothic Bold", 10);

                label29.Text = "RESIDENT'S DETAILS";
                label29.Font = new Font("Copperplate Gothic Bold", 18);
            }
            customButton7.Font = font;
            customButton8.Font = font;
            customButton9.Font = font;
            customButton17.Font = font;
            customButton18.Font = font;
            label32.Font = font;
            label31.Font = font;
            label30.Font = font;
            customButton_ApartmentList.Font = font;
            customButton2.Font = font;
            customButton3.Font = font;
            customButton4.Font = font;
            customButton5.Font = font;
            customButton1.Font = font;
            customButton15.Font = font;
            customButton19.Font = font;
            customButton20.Font = font;
            customButton21.Font = font;

            label7.Font = fontLarger;
            label9.Font = fontLarger;
            label11.Font = fontLarger;
            label13.Font = fontLarger;
            label6.Font = fontLarger;
            label15.Font = fontLarger;
            label17.Font = fontLarger;
            label19.Font = fontLarger;
            label21.Font = fontLarger;
            label23.Font = fontLarger;
            label25.Font = fontLarger;
            label27.Font = fontLarger;
        }
        private void customButton2_Click(object sender, EventArgs e)
        {
            CM_Resident_sDetail cM = new CM_Resident_sDetail();
            this.Hide();
            cM.ShowDialog();
            this.Close();
        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            CM_Resident_sDetail_Authorized cM = new CM_Resident_sDetail_Authorized();
            this.Hide();
            cM.ShowDialog();
            this.Close();
        }

        private void customButton4_Click(object sender, EventArgs e)
        {
            CM_Resident_sDetail_Tenant_StaffOf cM = new CM_Resident_sDetail_Tenant_StaffOf();
            this.Hide();
            cM.ShowDialog();
            this.Close();
        }

        private void customButton7_Click(object sender, EventArgs e)
        {
            C_AllTaskList c_AllTaskList = new C_AllTaskList();
            this.Hide();
            c_AllTaskList.ShowDialog();
            this.Close();
        }

        private void customButton17_Click(object sender, EventArgs e)
        {
            C_AccountManagement c_AccountManagement = new C_AccountManagement();
            this.Hide();
            c_AccountManagement.ShowDialog();
            this.Close();

        }

        private void customButton18_Click(object sender, EventArgs e)
        {
            CM_Resident_sDetail cM = new CM_Resident_sDetail();
            this.Hide();
            cM.ShowDialog();
            this.Close();
        }

        private void label32_Click(object sender, EventArgs e)
        {
            if (Session.Instance.UserName.Contains("GD") || Session.Instance.laQuanLi)
            {
                M_Information information = new M_Information();
                information.ShowDialog();
            }
            else
            {
                E_Information information = new E_Information();
                information.ShowDialog();
            }
        }

        private void label31_Click(object sender, EventArgs e)
        {
            G_ForgotPassword g_ForgotPassword = new G_ForgotPassword();
            g_ForgotPassword.ShowDialog();
        }

        private void label30_Click(object sender, EventArgs e)
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
                form.Close();
            }

            G_Login g_Login = new G_Login();
            g_Login.ShowDialog();
        }

        private void IDBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            CuDanService service = new CuDanService();
            List<string> list = service.getCuDanCommercialInFo(IDBox.SelectedItem.ToString());
            if (list.Count() > 0)
            {
                label1.Text = list[0];
                label4.Text = list[1];
                label5.Text = list[2];
                label3.Text = list[3];
                label2.Text = list[4];

                label8.Text = list[5];
                label10.Text = list[6];
                label12.Text = list[7];
                label14.Text = list[8];
                label20.Text = list[9];
                label22.Text = list[10];
                label24.Text = list[11];
                label26.Text = list[12];
                label28.Text = list[13];
                label33.Text = list[14];
            }
        }

        private void customButton8_Click(object sender, EventArgs e)
        {
            A_Statistic form = new A_Statistic();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void customButton9_Click(object sender, EventArgs e)
        {
            A_Statistic form = new A_Statistic();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
