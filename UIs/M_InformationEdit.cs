using System;
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
using Services;

namespace UIs
{
    public partial class M_InformationEdit : Form
    {
        NhanSuService nhanSuService = new NhanSuService();
        string managerID = Session.Instance.UserName;
        public M_InformationEdit()
        {
            InitializeComponent();
        }

        private void M_InformationEdit_Load(object sender, EventArgs e)
        {
            displayManagerData();
            if (Session.Instance.UserName.Contains("GD"))
            {
                heading.Text = "CEO";
            }
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

        private void SUBMIT_Click(object sender, EventArgs e)
        {
            NhanSu ns = nhanSuService.findMember(managerID);
            bool isSuccess = nhanSuService.updateInformation(managerID, UserName.Text, Number.Text, Birth.Value.ToString("yyyyMMdd"), CID.Text, Email.Text, Add.Text, Gender.Text);
            if (isSuccess)
            {
                MessageBox.Show("Successfully");
                this.Close();
            }
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

    }
}
