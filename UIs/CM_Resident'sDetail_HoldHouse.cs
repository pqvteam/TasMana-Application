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
    public partial class CM_Resident_sDetail : Form
    {
        public CM_Resident_sDetail()
        {
            InitializeComponent();
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

<<<<<<< HEAD
        private void CM_Resident_sDetail_Load(object sender, EventArgs e)
        {
            changelanguage();
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
                customButton10.Text = "DỊCH VỤ CƯ DÂN";
                label39.Text = "THÔNG TIN";
                label38.Text = "ĐỔI MẬT KHẨU";
                label37.Text = "ĐĂNG XUẤT";
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
                label9.Text = "NGÀY CHUYỂN CĂN HỘ";
                label11.Text = "NGÀY CHUYỂN VÀO";
                label13.Text = "NGÀY CHUYỂN ĐI";
                label15.Text = "THÔNG TIN LƯU TRÚ";
                label17.Text = "SỐ LIỆU ĐIỆN NƯỚC VÀO NGÀY BÀN GIAO CĂN HỘ";
                label19.Text = "DỮ LIỆU ĐIỆN, NƯỚC PHÁT SINH HÀNG THÁNG";
                label21.Text = "PHÍ DỊCH VỤ QUẢN LÝ HÀNG THÁNG";
                label23.Text = "PHÍ DỊCH VỤ KHÁC";
                label25.Text = "DỮ LIỆU XE ĐĂNG KÝ GIỮ XE TẠI NHÀ";
                label27.Text = "SỐ ĐIỆN THOẠI NGƯỜI THÂN";
                label29.Text = "NGÀY CHUYỂN NHƯỢNG CHO CHỦ MỚI";
                label31.Text = "THÔNG TIN CHỦ HỘ MỚI";
                label33.Text = "TÌNH TRẠNG CÔNG NỢ";
                label36.Text = "DỮ LIỆU NUÔI THÚ CƯNG";
                fontLarger = new Font("Microsoft Sans Serif", 11, FontStyle.Bold);

                label6.Text = "CHI TIẾT CƯ DÂN";
                label6.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Bold);
            }
            else
            {
                customButton7.Text = "WORK";
                customButton8.Text = "STATISTIC";
                customButton9.Text = "REPORT";
                customButton17.Text = "ACCOUNT MANAGEMENT";
                customButton18.Text = "DEPARTMENT RESIDENT";
                customButton10.Text = "RESIDENT SERVICE";
                label39.Text = "INFORMATION";
                label38.Text = "CHANGE PASSWORD";
                label37.Text = "SIGN OUT";
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
                label9.Text = "TRANSFER APARTMENT DATE";
                label11.Text = "MOVING DATE";
                label13.Text = "LEAVING DATE";
                label15.Text = "ACCOMMODATION INFORMATION";
                label17.Text = "ELECTRICITY AND WATER DATA ON THE HANDOVER DATE OF THE APARTMENT";
                label19.Text = "ELECTRICITY AND WATER DATA ARISING MONTHLY";
                label21.Text = "MONTHLY MANAGEMENT SERVICE FEE";
                label23.Text = "OTHER SERVICE FEES";
                label25.Text = "VEHICLE DATA FOR PARKING REGISTRATION AT HOME";
                label27.Text = "TELEPHONE NUMBERS OF RELATIVES";
                label29.Text = "TRANSFER DATE TO NEW OWNER";
                label31.Text = "NEW HOUSEHOLDERS INFORMATION";
                label33.Text = "DEBT STATUS";
                label36.Text = "PET KEEPING DATA";

                fontLarger = new Font("Copperplate Gothic Bold", 10);

                label6.Text = "RESIDENT'S DETAILS";
                label6.Font = new Font("Copperplate Gothic Bold", 18);
            }
            customButton7.Font = font;
            customButton8.Font = font;
            customButton9.Font = font;
            customButton17.Font = font;
            customButton18.Font = font;
            customButton10.Font = font;
            label39.Font = font;
            label38.Font = font;
            label37.Font = font;
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
            label15.Font = fontLarger;
            label17.Font = fontLarger;
            label19.Font = fontLarger;
            label21.Font = fontLarger;
            label23.Font = fontLarger;
            label25.Font = fontLarger;
            label27.Font = fontLarger;
            label29.Font = fontLarger;
            label31.Font = fontLarger;
            label33.Font = fontLarger;
            label36.Font = fontLarger;
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
                customButton10.Text = "DỊCH VỤ CƯ DÂN";
                label39.Text = "THÔNG TIN";
                label38.Text = "ĐỔI MẬT KHẨU";
                label37.Text = "ĐĂNG XUẤT";
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
                label9.Text = "NGÀY CHUYỂN CĂN HỘ";
                label11.Text = "NGÀY CHUYỂN VÀO";
                label13.Text = "NGÀY CHUYỂN ĐI";
                label15.Text = "THÔNG TIN LƯU TRÚ";
                label17.Text = "SỐ LIỆU ĐIỆN NƯỚC VÀO NGÀY BÀN GIAO CĂN HỘ";
                label19.Text = "DỮ LIỆU ĐIỆN, NƯỚC PHÁT SINH HÀNG THÁNG";
                label21.Text = "PHÍ DỊCH VỤ QUẢN LÝ HÀNG THÁNG";
                label23.Text = "PHÍ DỊCH VỤ KHÁC";
                label25.Text = "DỮ LIỆU XE ĐĂNG KÝ GIỮ XE TẠI NHÀ";
                label27.Text = "SỐ ĐIỆN THOẠI NGƯỜI THÂN";
                label29.Text = "NGÀY CHUYỂN NHƯỢNG CHO CHỦ MỚI";
                label31.Text = "THÔNG TIN CHỦ HỘ MỚI";
                label33.Text = "TÌNH TRẠNG CÔNG NỢ";
                label36.Text = "DỮ LIỆU NUÔI THÚ CƯNG";
                fontLarger = new Font("Microsoft Sans Serif", 11, FontStyle.Bold);

                label6.Text = "CHI TIẾT CƯ DÂN";
                label6.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Bold);
            }
            else
            {
                Session.Instance.Language = "en";
                customButton7.Text = "WORK";
                customButton8.Text = "STATISTIC";
                customButton9.Text = "REPORT";
                customButton17.Text = "ACCOUNT MANAGEMENT";
                customButton18.Text = "DEPARTMENT RESIDENT";
                customButton10.Text = "RESIDENT SERVICE";
                label39.Text = "INFORMATION";
                label38.Text = "CHANGE PASSWORD";
                label37.Text = "SIGN OUT";
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
                label9.Text = "TRANSFER APARTMENT DATE";
                label11.Text = "MOVING DATE";
                label13.Text = "LEAVING DATE";
                label15.Text = "ACCOMMODATION INFORMATION";
                label17.Text = "ELECTRICITY AND WATER DATA ON THE HANDOVER DATE OF THE APARTMENT";
                label19.Text = "ELECTRICITY AND WATER DATA ARISING MONTHLY";
                label21.Text = "MONTHLY MANAGEMENT SERVICE FEE";
                label23.Text = "OTHER SERVICE FEES";
                label25.Text = "VEHICLE DATA FOR PARKING REGISTRATION AT HOME";
                label27.Text = "TELEPHONE NUMBERS OF RELATIVES";
                label29.Text = "TRANSFER DATE TO NEW OWNER";
                label31.Text = "NEW HOUSEHOLDERS INFORMATION";
                label33.Text = "DEBT STATUS";
                label36.Text = "PET KEEPING DATA";

                fontLarger = new Font("Copperplate Gothic Bold", 10);

                label6.Text = "RESIDENT'S DETAILS";
                label6.Font = new Font("Copperplate Gothic Bold", 18);
            }
            customButton7.Font = font;
            customButton8.Font = font;
            customButton9.Font = font;
            customButton17.Font = font;
            customButton18.Font = font;
            customButton10.Font = font;
            label39.Font = font;
            label38.Font = font;
            label37.Font = font;
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
            label15.Font = fontLarger;
            label17.Font = fontLarger;
            label19.Font = fontLarger;
            label21.Font = fontLarger;
            label23.Font = fontLarger;
            label25.Font = fontLarger;
            label27.Font = fontLarger;
            label29.Font = fontLarger;
            label31.Font = fontLarger;
            label33.Font = fontLarger;
            label36.Font = fontLarger;
=======
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

        private void label39_Click(object sender, EventArgs e)
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

        private void label38_Click(object sender, EventArgs e)
        {
            G_ForgotPassword g_ForgotPassword = new G_ForgotPassword();
            g_ForgotPassword.ShowDialog();
        }

        private void label37_Click(object sender, EventArgs e)
        {
            List<Form> formsToClose = new List<Form>();

            foreach (Form form in Application.OpenForms)
            {
                if (form != this) // Assuming "this" refers to the main form
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

        private void customButton5_Click(object sender, EventArgs e)
        {
            CM_Resident_sDetail_Commercial cM = new CM_Resident_sDetail_Commercial();
            cM.ShowDialog();
>>>>>>> fa274daeb82a1a0e0f013863fbd5e1cb4684ba3f
        }
    }
}
