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
        NhanSuService nhanSuService = new NhanSuService();
        string managerID = "GD-001";
        public C_InformationEdit()
        {
            InitializeComponent();
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
            if (ns.AnhDaiDien != null && IsValidImageData(ns.AnhDaiDien))
            {
                avatarBox.Image = convertByteToImage(ns.AnhDaiDien);
            }
        }

        public Image convertByteToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
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

        // Convert Image to byte array
        private byte[] convertImageToByte(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void SUBMIT_Click(object sender, EventArgs e)
        {
            NhanSu ns = nhanSuService.findMember(managerID);
            bool isSuccess = nhanSuService.updateInformation(managerID, UserName.Text, Number.Text, Birth.Value.ToString("yyyyMMdd"), CID.Text, Email.Text, Add.Text, Gender.Text);
            if (isSuccess)
            {
                showToast("SUCCESS", "Successfully");
                this.Close();
            }
        }

        private void C_InformationEdit_Load(object sender, EventArgs e)
        {
            displayCEOData();
        }

        private void changeAvatarButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files(*.jpg;*.jpeg)|*.jpg;*.jpeg", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    avatarBox.Image = Image.FromFile(ofd.FileName);
                    nhanSuService.insertImage(convertImageToByte(avatarBox.Image), managerID);
                }
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
                label3.Text = "THÔNG TIN";
                label2.Text = "ĐỔI MẬT KHẨU";
                label1.Text = "ĐĂNG XUẤT";
                fontSmaller = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);

                label8.Text = "HỌ VÀ TÊN";
                label9.Text = "GIỚI TÍNH";
                label10.Text = "NGÀY SINH";
                label11.Text = "ĐỊA CHỈ";
                label13.Text = "CĂN CƯỚC CÔNG DÂN ";
                label14.Text = "SỐ ĐIỆN THOẠI";
                font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);

                SUBMIT.Text = "LƯU MỚI";
                label7.Text = "CHI TIẾT THÔNG TIN CÁ NHÂN";
                fontLarger = new Font("Microsoft Sans Serif", 18, FontStyle.Bold);

            }
            else
            {
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
                font = new Font("Copperplate Gothic Bold", 14);

                SUBMIT.Text = "SUBMIT";
                label7.Text = "PROFILE DETAILS";
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

            SUBMIT.Font = fontLarger;
            label7.Font = fontLarger;
        }

        private void languageSelect_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            Font font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            Font fontLarger = new Font("Copperplate Gothic Bold", 12);
            Font fontSmaller = new Font("Copperplate Gothic Bold", 9);
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
                font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);

                SUBMIT.Text = "LƯU MỚI";
                label7.Text = "CHI TIẾT THÔNG TIN CÁ NHÂN";
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
                font = new Font("Copperplate Gothic Bold", 14);

                SUBMIT.Text = "SUBMIT";
                label7.Text = "PROFILE DETAILS";
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

            SUBMIT.Font = fontLarger;
            label7.Font = fontLarger;
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
        public void showToast(string type, string message)
        {
            ToastForm show = new ToastForm(type, message);
            show.Show();
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
