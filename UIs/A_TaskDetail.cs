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
    public partial class A_TaskDetail : Form
    {
        private string currentID;
        GiaoViecService giaoViecService = new GiaoViecService();
        public A_TaskDetail()
        {
            InitializeComponent();
        }

        public A_TaskDetail(string ID)
        {
            this.currentID = ID;
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void A_TaskDetail_Load(object sender, EventArgs e)
        {
            changelanguage();
            customComboBox2.SelectedItem = Session.Instance.Language == "en" ? "ENGLISH" : "VIETNAMESE";

            List<GiaoViec> tasks = giaoViecService.getAll();
            foreach (GiaoViec task in tasks)
            {
                taskIDBox.Items.Add(task.MaGiaoViec);
            }
            taskIDBox.SelectedItem = currentID;
        }

        private void taskIDBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (taskIDBox.SelectedIndex != -1)
            {
                GiaoViec task = giaoViecService.findAssignedTask(taskIDBox.SelectedItem.ToString());
                nameContent.Text = task.TenCongViec;
                idContent.Text = task.MaGiaoViec;
                statusContent.Text = task.TinhTrangCongViec;
                descriptionContent.Text = task.MoTaCongViec;
                startContent.Text = task.NgayGiao.ToString("dd/MM/yyyy");
                endContent.Text = task.HanHoanThanh.ToString("dd/MM/yyyy");
                publicToContent.Text = task.CheDo == true ? "All" : task.PhongBanChoPhep != null ? task.PhongBanChoPhep : "No";
                intimeContent.Text = (task.DungHan == false || task.DungHan == null) ? "False" : "True";
                assignByContent.Text = task.MaGiaoViec.Split('.')[0];
            }
        }

        private void intimeContent_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void changelanguage()
        {
            Font font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            Font fontLarger = new Font("Copperplate Gothic Bold", 14);
            Font fontSmaller = new Font("Copperplate Gothic Bold", 10);
            if (Session.Instance.Language == "vi")
            {
                workButton.Text = "CÔNG VIỆC";
                statisticButton.Text = "THỐNG KÊ";
                reportButton.Text = "BÁO CÁO";
                accountManagementButton.Text = "QUẢN LÝ TÀI KHOẢN";
                apartmentResidentButton.Text = "CƯ DÂN CĂN HỘ";
                typeLabel.Text = "CÔNG VIỆC HIỆN TẠI";
                fontSmaller = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);

                filterLabel.Text = "CÔNG VIỆC";
                label7.Text = "CHI TIẾT";
                fontLarger = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);

                nameLabel.Text = "TÊN";
                idLabel.Text = "MÃ";
                statusLabel.Text = "TÌNH TRẠNG";
                descriptionLabel.Text = "MÔ TẢ";
                startLabel.Text = "BẮT ĐẦU";
                endLabel.Text = "KẾT THÚC";
                publicToLabel.Text = "CÔNG KHAI VỚI";
                intimeLabel.Text = "ĐÚNG HẠN";
                assignByLabel.Text = "ĐƯỢC GIAO BỞI";
                font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            }
            else
            {
                workButton.Text = "WORK";
                statisticButton.Text = "STATISTIC";
                reportButton.Text = "REPORT";
                accountManagementButton.Text = "ACCOUNT MANANGEMENT";
                apartmentResidentButton.Text = "APARTMENT RESIDENT";
                typeLabel.Text = "CURRENT TASK";
                fontSmaller = new Font("Copperplate Gothic Bold", 10);

                filterLabel.Text = "TASK";
                label7.Text = "DETAIL";
                fontLarger = new Font("Copperplate Gothic Bold", 14);

                nameLabel.Text = "NAME";
                idLabel.Text = "ID";
                statusLabel.Text = "STATUS";
                descriptionLabel.Text = "DESCRIPTION";
                startLabel.Text = "START";
                endLabel.Text = "END";
                publicToLabel.Text = "PUBLIC TO";
                intimeLabel.Text = "INTIME";
                assignByLabel.Text = "ASSIGN BY";
                font = new Font("Copperplate Gothic Bold", 12);
            }
            workButton.Font = fontSmaller;
            statisticButton.Font = fontSmaller;
            reportButton.Font = fontSmaller;
            accountManagementButton.Font = fontSmaller;
            apartmentResidentButton.Font = fontSmaller;
            typeLabel.Font = fontSmaller;

            filterLabel.Font = fontLarger;
            label7.Font = fontLarger;

            nameLabel.Font = font;
            idLabel.Font = font;
            statusLabel.Font = font;
            descriptionLabel.Font = font;
            startLabel.Font = font;
            endLabel.Font = font;
            publicToLabel.Font = font;
            intimeLabel.Font = font;
            assignByLabel.Font = font;

        }

        private void customComboBox2_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            Font font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            Font fontLarger = new Font("Copperplate Gothic Bold", 12);
            Font fontSmaller = new Font("Copperplate Gothic Bold", 9);
            if (customComboBox2.SelectedItem.ToString() == "VIETNAMESE")
            {
                Session.Instance.Language = "vi";
                workButton.Text = "CÔNG VIỆC";
                statisticButton.Text = "THỐNG KÊ";
                reportButton.Text = "BÁO CÁO";
                accountManagementButton.Text = "QUẢN LÝ TÀI KHOẢN";
                apartmentResidentButton.Text = "CƯ DÂN CĂN HỘ";
                typeLabel.Text = "CÔNG VIỆC HIỆN TẠI";
                fontSmaller = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);

                filterLabel.Text = "CÔNG VIỆC";
                label7.Text = "CHI TIẾT";
                fontLarger = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);

                nameLabel.Text = "TÊN";
                idLabel.Text = "MÃ";
                statusLabel.Text = "TÌNH TRẠNG";
                descriptionLabel.Text = "MÔ TẢ";
                startLabel.Text = "BẮT ĐẦU";
                endLabel.Text = "KẾT THÚC";
                publicToLabel.Text = "CÔNG KHAI VỚI";
                intimeLabel.Text = "ĐÚNG HẠN";
                assignByLabel.Text = "ĐƯỢC GIAO BỞI";
                font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            }
            else
            {
                Session.Instance.Language = "en";
                workButton.Text = "WORK";
                statisticButton.Text = "STATISTIC";
                reportButton.Text = "REPORT";
                accountManagementButton.Text = "ACCOUNT MANANGEMENT";
                apartmentResidentButton.Text = "APARTMENT RESIDENT";
                typeLabel.Text = "CURRENT TASK";
                fontSmaller = new Font("Copperplate Gothic Bold", 10);

                filterLabel.Text = "TASK";
                label7.Text = "DETAIL";
                fontLarger = new Font("Copperplate Gothic Bold", 14);

                nameLabel.Text = "NAME";
                idLabel.Text = "ID";
                statusLabel.Text = "STATUS";
                descriptionLabel.Text = "DESCRIPTION";
                startLabel.Text = "START";
                endLabel.Text = "END";
                publicToLabel.Text = "PUBLIC TO";
                intimeLabel.Text = "INTIME";
                assignByLabel.Text = "ASSIGN BY";
                font = new Font("Copperplate Gothic Bold", 12);
            }
            workButton.Font = fontSmaller;
            statisticButton.Font = fontSmaller;
            reportButton.Font = fontSmaller;
            accountManagementButton.Font = fontSmaller;
            apartmentResidentButton.Font = fontSmaller;
            typeLabel.Font = fontSmaller;

            filterLabel.Font = fontLarger;
            label7.Font = fontLarger;

            nameLabel.Font = font;
            idLabel.Font = font;
            statusLabel.Font = font;
            descriptionLabel.Font = font;
            startLabel.Font = font;
            endLabel.Font = font;
            publicToLabel.Font = font;
            intimeLabel.Font = font;
            assignByLabel.Font = font;
        }
    }
}
