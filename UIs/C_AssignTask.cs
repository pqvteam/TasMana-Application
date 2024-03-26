using Repositories.Entities;
using Services;
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
    public partial class C_AssignTask : Form
    {
        PhongBanService phongBanService = new PhongBanService();
        QuanLyService quanLyService = new QuanLyService();
        GiaoViecService giaoViecService = new GiaoViecService();
        CanHoService canHoService = new CanHoService();
        NhanSuService nhanSuService = new NhanSuService();
        MailService mailService = new MailService();
        public C_AssignTask()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void C_AssignTask_Load(object sender, EventArgs e)
        {
            List<CanHo> apartments = canHoService.getAllApartments();
            apartmentsBox.Items.Clear();
            foreach (var apartment in apartments)
            {
                apartmentsBox.Items.Add(apartment.MaCh);
            }
        }

        private void receiverTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (receiverTypeBox.SelectedItem != null && receiverTypeBox.SelectedItem.ToString() == "Phòng ban")
            {
                List<PhongBan> departments = phongBanService.getAllDepartment();

                // Delete current value of receiverBox
                receiverBox.Items.Clear();

                // Add department to receiverBox
                foreach (var department in departments)
                {
                    receiverBox.Items.Add(department.MaPb);
                }
            }
        }

        private void receiverBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (receiverBox.SelectedItem != null)
            {
                // Get receiverID
                string receiverID = quanLyService.findManager(receiverBox.SelectedItem.ToString()).MaThanhVien;
            }
        }

        private void assignButton_Click(object sender, EventArgs e)
        {
            QuanLi manager = quanLyService.findManager(receiverBox.SelectedItem.ToString());
            string receiverID = manager.MaThanhVien;
            string CEOID = "GD-001";
            string description = taskDescription.Text;
            string name = taskName.Text;
            string file = taskFile.Text;
            DateTime deadlineDate = taskDeadline.Value.Date; 
            string deadline = deadlineDate.ToString("yyyyMMdd");
            int mode = taskMode.SelectedItem.ToString() == "Có" ? 1 : 0;
            string status = "Chưa hoàn thành";
            string assignID = giaoViecService.getAssignTaskID(CEOID);
            DateTime today = DateTime.Now;
            string day = today.ToString("yyyyMMdd");
            string? apartmentID = apartmentsBox?.SelectedItem?.ToString();
            int isCEO = 1;

            string departmentQuery = $"EXEC taoViec N'{description}', '{day}', '{deadline}', N'{status}', '{file}', '{assignID}', '{receiverID}', {mode}, N'{name}', {isCEO}, '{CEOID}', '{apartmentID}'";
            MessageBox.Show(departmentQuery);
            bool isSuccess = giaoViecService.assignTask(description, day, deadline, status, file, assignID, mode, name, apartmentID, receiverID, isCEO, CEOID);
            if (isSuccess)
            {
                string mailSubject = "THÔNG BÁO NHẬN VIỆC";
                string mailContent = "Nhận việc từ Lê Vĩ";
                string toEmail = "otakuanime285@gmail.com";
                mailService.sendMail(mailSubject, mailContent, toEmail);
            }
        }
}
}
