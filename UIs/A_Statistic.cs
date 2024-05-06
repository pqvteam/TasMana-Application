using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using Microsoft.Data.SqlClient;
using Repositories.Entities;
using Repositories.Utilities;
using Services;
using UIs.CustomComponent;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Diagnostics;
using OfficeOpenXml.Drawing.Chart;
using System.IO;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.IO.Packaging;
using Org.BouncyCastle.Crypto.Tls;

namespace UIs
{
    public partial class A_Statistic : Form
    {
        NhanSuService nhanSuService = new NhanSuService();
        CanHoService canHoService = new CanHoService();
        CuDanService cuDanService = new CuDanService();

        public A_Statistic()
        {
            InitializeComponent();
        }

        private void A_Statistic_Load(object sender, EventArgs e)
        {
            changelanguage();
            languageSelect.SelectedItem = Session.Instance.Language == "en" ? "ENGLISH" : "VIETNAMESE";

            membersGrid.Columns.Add("ID", "ID");
            membersGrid.Columns.Add("Name", "Name");
            membersGrid.Columns.Add("Task quantity", "Task quantity");
            List<NhanSu> staffs = nhanSuService.getAllStaffs();
            List<CanHo> apartments = canHoService.getAllApartments();

            if (typeBox.SelectedItem != null) { }

            foreach (CanHo apartment in apartments)
            {
                apartmentBox.Items.Add(apartment.MaCh);
            }
            renderSearchBox();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void renderSearchBox()
        {
            bool isValidNumberOfCompletedTasks =
                dayButton.Checked
                || monthButton.Checked
                || quarterButton.Checked
                || yearButton.Checked;

            timeBox.Visible = isValidNumberOfCompletedTasks;
            timePanelBox.Visible = isValidNumberOfCompletedTasks;
            glassPicture.Visible = isValidNumberOfCompletedTasks;
        }

        private void performSearch()
        {
            membersGrid.Rows.Clear();
            string selectedCompleteRate =
                taskCompeleteRateBox.SelectedItem != null
                    ? taskCompeleteRateBox.SelectedItem.ToString()
                    : "";
            if (selectedCompleteRate == "DISQUALIFIED")
            {
                selectedCompleteRate =
                    "tinhTrangCongViec like N'%canceled%' or tinhTrangCongViec like N'%postponed%' or tinhTrangCongViec like N'%chưa hoàn thành%'";
            }
            else if (selectedCompleteRate == "INTIME" || selectedCompleteRate == "EARLY")
            {
                selectedCompleteRate = "dungHan = 1";
            }
            else if (selectedCompleteRate == "LATE")
            {
                selectedCompleteRate = "dungHan = 0";
            }

            try
            {
                DatabaseConnection.Instance.OpenConnection();

                SqlConnection conn = DatabaseConnection.Instance.GetConnection();

                bool isValidCompletedRate = !string.IsNullOrEmpty(selectedCompleteRate);
                bool isValidNumberOfCompletedTasks =
                    dayButton.Checked
                    || monthButton.Checked
                    || quarterButton.Checked
                    || yearButton.Checked;

                timeBox.Visible = isValidNumberOfCompletedTasks;
                timePanelBox.Visible = isValidNumberOfCompletedTasks;
                glassPicture.Visible = isValidNumberOfCompletedTasks;

                membersGrid.Rows.Clear();

                string sql = $"";
                string timeType = "day";
                string timeSort = "";
                if (dayButton.Checked)
                {
                    timeType = "Day(";
                }
                else if (monthButton.Checked)
                {
                    timeType = "Month(";
                }
                else if (yearButton.Checked)
                {
                    timeType = "Year(";
                }
                else if (quarterButton.Checked)
                {
                    timeType = "datediff(q,";
                }
                timeSort = timeBox.Text;
                if (typeBox.SelectedItem != null && typeBox.SelectedItem.ToString() == "STAFF")
                {
                    if (isValidCompletedRate && !isValidNumberOfCompletedTasks)
                    {
                        sql =
                            $"SELECT TOP 10 NhanSu.maThanhVien, NhanSu.hoVaTen, COUNT(NhanSu.maThanhVien) AS SoLuongCongViecHoanThanh FROM NhanSu INNER JOIN NhanViec ON NhanSu.maThanhVien = NhanViec.maThanhVien INNER JOIN GiaoViec ON NhanViec.maGiaoViec = GiaoViec.maGiaoViec WHERE {selectedCompleteRate} GROUP BY NhanSu.maThanhVien, NhanSu.hoVaTen ORDER BY COUNT(NhanSu.maThanhVien) DESC;";
                    }
                    else if (!isValidCompletedRate && isValidNumberOfCompletedTasks)
                    {
                        sql =
                            $"SELECT TOP 10 NhanSu.maThanhVien, NhanSu.hoVaTen, COUNT(NhanSu.maThanhVien) AS SoLuongCongViecHoanThanh FROM NhanSu INNER JOIN NhanViec ON NhanSu.maThanhVien = NhanViec.maThanhVien INNER JOIN GiaoViec ON NhanViec.maGiaoViec = GiaoViec.maGiaoViec WHERE {timeType}GiaoViec.hanHoanThanh) = '{timeSort}' GROUP BY NhanSu.maThanhVien, NhanSu.hoVaTen ORDER BY COUNT(NhanSu.maThanhVien) DESC;";
                    }
                    else if (isValidCompletedRate && isValidNumberOfCompletedTasks)
                    {
                        sql =
                            $"SELECT TOP 10 NhanSu.maThanhVien, NhanSu.hoVaTen, COUNT(NhanSu.maThanhVien) AS SoLuongCongViecHoanThanh FROM NhanSu INNER JOIN NhanViec ON NhanSu.maThanhVien = NhanViec.maThanhVien INNER JOIN GiaoViec ON NhanViec.maGiaoViec = GiaoViec.maGiaoViec WHERE {timeType}GiaoViec.hanHoanThanh) = '{timeSort}' AND {selectedCompleteRate} GROUP BY NhanSu.maThanhVien, NhanSu.hoVaTen ORDER BY COUNT(NhanSu.maThanhVien) DESC;";
                    }
                }
                else if (
                    typeBox.SelectedItem != null
                    && typeBox.SelectedItem.ToString() == "DEPARTMENT"
                )
                {
                    if (isValidCompletedRate && !isValidNumberOfCompletedTasks)
                    {
                        sql =
                            $"SELECT TOP 10 PhongBan.maPB, PhongBan.tenPB, COUNT(NhanSu.maThanhVien) AS SoLuongCongViecHoanThanh FROM NhanSu INNER JOIN NhanViec ON NhanSu.maThanhVien = NhanViec.maThanhVien INNER JOIN GiaoViec ON NhanViec.maGiaoViec = GiaoViec.maGiaoViec INNER JOIN NhanVien on NhanSu.maThanhVien = NhanVien.maThanhVien INNER JOIN PhongBan ON PhongBan.maPB = NhanVien.maPB WHERE {selectedCompleteRate} GROUP BY PhongBan.maPB, PhongBan.tenPB ORDER BY COUNT(NhanSu.maThanhVien) DESC;";
                    }
                    else if (!isValidCompletedRate && isValidNumberOfCompletedTasks)
                    {
                        sql =
                            $"SELECT TOP 10 PhongBan.maPB, PhongBan.tenPB, COUNT(NhanSu.maThanhVien) AS SoLuongCongViecHoanThanh FROM NhanSu INNER JOIN NhanViec ON NhanSu.maThanhVien = NhanViec.maThanhVien INNER JOIN GiaoViec ON NhanViec.maGiaoViec = GiaoViec.maGiaoViec INNER JOIN NhanVien on NhanSu.maThanhVien = NhanVien.maThanhVien INNER JOIN PhongBan ON PhongBan.maPB = NhanVien.maPB WHERE {timeType}GiaoViec.hanHoanThanh) = '{timeSort}' GROUP BY PhongBan.maPB, PhongBan.tenPB ORDER BY COUNT(NhanSu.maThanhVien) DESC;";
                    }
                    else if (isValidCompletedRate && isValidNumberOfCompletedTasks)
                    {
                        sql =
                            $"SELECT TOP 10 PhongBan.maPB, PhongBan.tenPB, COUNT(NhanSu.maThanhVien) AS SoLuongCongViecHoanThanh FROM NhanSu INNER JOIN NhanViec ON NhanSu.maThanhVien = NhanViec.maThanhVien INNER JOIN GiaoViec ON NhanViec.maGiaoViec = GiaoViec.maGiaoViec INNER JOIN NhanVien on NhanSu.maThanhVien = NhanVien.maThanhVien INNER JOIN PhongBan ON PhongBan.maPB = NhanVien.maPB WHERE {timeType}GiaoViec.hanHoanThanh) = '{timeSort}' AND {selectedCompleteRate} GROUP BY PhongBan.maPB, PhongBan.tenPB ORDER BY COUNT(NhanSu.maThanhVien) DESC;";
                    }
                }

                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string ID =
                                    typeBox.SelectedItem.ToString() == "STAFF"
                                        ? reader.GetString(reader.GetOrdinal("maThanhVien"))
                                        : reader.GetString(reader.GetOrdinal("maPB"));
                                string name =
                                    typeBox.SelectedItem.ToString() == "STAFF"
                                        ? reader.GetString(reader.GetOrdinal("hoVaTen"))
                                        : reader.GetString(reader.GetOrdinal("tenPB"));
                                int quantity = reader.GetInt32("SoLuongCongViecHoanThanh");

                                int rowIndex = membersGrid.Rows.Add(ID, name, quantity);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy kết quả nào.");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                string logFilePath = "error.log"; // Đường dẫn tới tệp tin log, bạn có thể thay đổi đường dẫn này
                using (StreamWriter writer = new StreamWriter(logFilePath, true))
                {
                    writer.WriteLine($"Error occurred at {DateTime.Now}: {e.Message}");
                    writer.WriteLine($"Stack trace: {e.StackTrace}");
                    writer.WriteLine("----------------------------------------------");
                }
            }
            finally
            {
                DatabaseConnection.Instance.CloseConnection();
            }
        }

        private void taskCompeleteRateBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            performSearch();
        }

        private void numberOfCompletedTasksBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            performSearch();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            performSearch();
        }

        private void billLabel_Click(object sender, EventArgs e) { }

        private void apartmentBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            int ELECTRICITY_BILL = 500000;
            int WATER_BILL = 40000;
            string selectedApartment =
                apartmentBox.SelectedItem != null ? apartmentBox.SelectedItem.ToString() : "";
            string nationality = "";
            CanHo apartment = canHoService.findApartment(selectedApartment);
            if (apartment != null)
            {
                enwContent.Text = (ELECTRICITY_BILL + WATER_BILL).ToString() + " VND";
                eContent.Text = ELECTRICITY_BILL.ToString() + " VND";
                wContent.Text = WATER_BILL.ToString() + " VND";
                dContent.Text = "0 VND";
                mContent.Text = apartment.PhiQl.ToString() + " VND";
                oContent.Text = "0 VND";
                sContent.Text =
                    apartment.MaCuDan != null ? "CURRENTLY USING" : "HAVE NOT BEEN USED";
                if (apartment.MaCuDan != null)
                {
                    nationality = cuDanService.getResident(apartment.MaCuDan).QuocTich;
                }
                nContent.Text = nationality;
            }
            DatabaseConnection.Instance.OpenConnection();
            SqlConnection conn = DatabaseConnection.Instance.GetConnection();
            string sql =
                $"SELECT maThanhVien, tenCongViec FROM NhanViec n INNER JOIN KhuVucLamViec k on n.MaGiaoViec = k.MaGiaoViec INNER JOIN GiaoViec g on n.MaGiaoViec = g.MaGiaoViec WHERE maCH = '{apartment.MaCh}'";
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        string text = "";
                        while (reader.Read())
                        {
                            text +=
                                reader.GetString(reader.GetOrdinal("maThanhVien"))
                                + " - "
                                + reader.GetString(reader.GetOrdinal("tenCongViec"))
                                + $"\n";
                        }
                        sContent.Text = text;
                    }
                }
            }
        }

        private void rankByBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            performSearch();
        }

        private void typeBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            performSearch();
        }

        private void dayButton_CheckedChanged(object sender, EventArgs e)
        {
            renderSearchBox();
        }

        private void monthButton_CheckedChanged(object sender, EventArgs e)
        {
            renderSearchBox();
        }

        private void quarterButton_CheckedChanged(object sender, EventArgs e)
        {
            renderSearchBox();
        }

        private void yearButton_CheckedChanged(object sender, EventArgs e)
        {
            renderSearchBox();
        }

        private void changelanguage()
        {
            Font font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            Font fontLarger = new Font("Copperplate Gothic Bold", 12);
            Font fontSmaller = new Font("Copperplate Gothic Bold", 9);
            if (Session.Instance.Language == "vi")
            {
                customButton15.Text = "CÔNG VIỆC";
                customButton14.Text = "THỐNG KÊ";
                customButton13.Text = "BÁO CÁO";
                customButton11.Text = "QUẢN LÝ TÀI KHOẢN";
                customButton10.Text = "CƯ DÂN VÀ CĂN HỘ";
                typeLabel.Text = "LOẠI";
                taskCompleteRate.Text = "TÌNH TRẠNG HOÀN THÀNH CÔNG VIỆC";
                label9.Text = "MỐC THỜI GIAN";
                billLabel.Text = "HÓA ĐƠN ĐIỆN, NƯỚC";
                label5.Text = "HÓA ĐƠN ĐIỆN";
                label11.Text = "HÓA ĐƠN NƯỚC";
                label2.Text = "CÔNG NỢ";
                managementLabel.Text = "PHÍ QUẢN LÝ";
                label3.Text = "CÁC PHÍ KHÁC";
                apartmentStatusLabel.Text = "TÌNH TRẠNG CĂN HỘ";
                label4.Text = "QUỐC TỊCH";
                label7.Text = "NHÂN VIÊN";
                font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);

                filterLabel.Text = "NHÂN VIÊN VÀ BỘ PHẬN";
                label6.Text = "kẾT QUẢ";
                dayButton.Text = "NGÀY";
                monthButton.Text = "THÁNG";
                quarterButton.Text = "QUÝ";
                yearButton.Text = "NĂM";
                label1.Text = "CƯ DÂN VÀ CĂN HỘ";
                label12.Text = "CHI TIẾT";
                fontLarger = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

                label10.Text = "(NHẬP SỐ SAU KHI KIỂM TRA, ĐỊNH DẠNG: dd, MM, qq, yyyy)";
                customButton4.Text = "XUẤT KHẨU SANG EXCEL";
                cancelButton.Text = "HỦY";
                fontSmaller = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
            }
            else
            {
                customButton15.Text = "WORK";
                customButton14.Text = "STATISTIC";
                customButton13.Text = "REPORT";
                customButton11.Text = "ACCOUNTING MANAGEMENT";
                customButton10.Text = "APARTMENT RESIDENT";
                typeLabel.Text = "TYPE";
                taskCompleteRate.Text = "TASK COMPLETED STATUS";
                label9.Text = "TIMELINE";
                billLabel.Text = "ELECTRICITY AND WATER BILL";
                label5.Text = "ELECTRICITY BILL";
                label11.Text = "WATER BILL";
                label2.Text = "DEBT";
                managementLabel.Text = "MANAGEMENT BILL";
                label3.Text = "OTHER FEES";
                apartmentStatusLabel.Text = "APARTMENT STATUS";
                label4.Text = "NATIONALITY";
                label7.Text = "STAFF";
                font = new Font("Copperplate Gothic Bold", 10);

                filterLabel.Text = "STAFF AND DEPARTMENT";
                label6.Text = "RESULT";
                dayButton.Text = "DAY";
                monthButton.Text = "MONTH";
                quarterButton.Text = "QUARTER";
                yearButton.Text = "YEAR";
                label1.Text = "RESIDENT AND APARTMENT";
                label12.Text = "DETAIL";
                fontLarger = new Font("Copperplate Gothic Bold", 12);

                label10.Text = "(ENTER NUMBER AFTER CHECK, FORMAT: dd, MM, qq, yyyy)";
                customButton4.Text = "EXPORT TO EXCEL";
                cancelButton.Text = "CANCEL";
                fontSmaller = new Font("Copperplate Gothic Bold", 9);
            }
            customButton15.Font = font;
            customButton14.Font = font;
            customButton13.Font = font;
            customButton11.Font = font;
            customButton10.Font = font;
            typeLabel.Font = font;
            taskCompleteRate.Font = font;
            label9.Font = font;
            billLabel.Font = font;
            label5.Font = font;
            label11.Font = font;
            label2.Font = font;
            managementLabel.Font = font;
            label3.Font = font;
            apartmentStatusLabel.Font = font;
            label4.Font = font;
            label7.Font = font;


            filterLabel.Font = fontLarger;
            label6.Font = fontLarger;
            dayButton.Font = fontLarger;
            monthButton.Font = fontLarger;
            quarterButton.Font = fontLarger;
            yearButton.Font = fontLarger;
            label1.Font = fontLarger;
            label12.Font = fontLarger;


            label10.Font = fontSmaller;
            customButton4.Font = fontSmaller;
            cancelButton.Font = fontSmaller;

        }

        private void customComboBox2_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            Font font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            Font fontLarger = new Font("Copperplate Gothic Bold", 12);
            Font fontSmaller = new Font("Copperplate Gothic Bold", 9);
            if (customComboBox2.SelectedItem.ToString() == "VIETNAMESE")
            {
                Session.Instance.Language = "vi";
                customButton15.Text = "CÔNG VIỆC";
                customButton14.Text = "THỐNG KÊ";
                customButton13.Text = "BÁO CÁO";
                customButton11.Text = "QUẢN LÝ TÀI KHOẢN";
                customButton10.Text = "CƯ DÂN VÀ CĂN HỘ";
                typeLabel.Text = "LOẠI";
                taskCompleteRate.Text = "TÌNH TRẠNG HOÀN THÀNH CÔNG VIỆC";
                label9.Text = "MỐC THỜI GIAN";
                billLabel.Text = "HÓA ĐƠN ĐIỆN, NƯỚC";
                label5.Text = "HÓA ĐƠN ĐIỆN";
                label11.Text = "HÓA ĐƠN NƯỚC";
                label2.Text = "CÔNG NỢ";
                managementLabel.Text = "PHÍ QUẢN LÝ";
                label3.Text = "CÁC PHÍ KHÁC";
                apartmentStatusLabel.Text = "TÌNH TRẠNG CĂN HỘ";
                label4.Text = "QUỐC TỊCH";
                label7.Text = "NHÂN VIÊN";
                font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);

                filterLabel.Text = "NHÂN VIÊN VÀ BỘ PHẬN";
                label6.Text = "kẾT QUẢ";
                dayButton.Text = "NGÀY";
                monthButton.Text = "THÁNG";
                quarterButton.Text = "QUÝ";
                yearButton.Text = "NĂM";
                label1.Text = "CƯ DÂN VÀ CĂN HỘ";
                label12.Text = "CHI TIẾT";
                fontLarger = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

                label10.Text = "(NHẬP SỐ SAU KHI KIỂM TRA, ĐỊNH DẠNG: dd, MM, qq, yyyy)";
                customButton4.Text = "XUẤT KHẨU SANG EXCEL";
                cancelButton.Text = "HỦY";
                fontSmaller = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
            }
            else
            {
                Session.Instance.Language = "en";
                customButton15.Text = "WORK";
                customButton14.Text = "STATISTIC";
                customButton13.Text = "REPORT";
                customButton11.Text = "ACCOUNTING MANAGEMENT";
                customButton10.Text = "APARTMENT RESIDENT";
                typeLabel.Text = "TYPE";
                taskCompleteRate.Text = "TASK COMPLETED STATUS";
                label9.Text = "TIMELINE";
                billLabel.Text = "ELECTRICITY AND WATER BILL";
                label5.Text = "ELECTRICITY BILL";
                label11.Text = "WATER BILL";
                label2.Text = "DEBT";
                managementLabel.Text = "MANAGEMENT BILL";
                label3.Text = "OTHER FEES";
                apartmentStatusLabel.Text = "APARTMENT STATUS";
                label4.Text = "NATIONALITY";
                label7.Text = "STAFF";
                font = new Font("Copperplate Gothic Bold", 10);

                filterLabel.Text = "STAFF AND DEPARTMENT";
                label6.Text = "RESULT";
                dayButton.Text = "DAY";
                monthButton.Text = "MONTH";
                quarterButton.Text = "QUARTER";
                yearButton.Text = "YEAR";
                label1.Text = "RESIDENT AND APARTMENT";
                label12.Text = "DETAIL";
                fontLarger = new Font("Copperplate Gothic Bold", 12);

                label10.Text = "(ENTER NUMBER AFTER CHECK, FORMAT: dd, MM, qq, yyyy)";
                customButton4.Text = "EXPORT TO EXCEL";
                cancelButton.Text = "CANCEL";
                fontSmaller = new Font("Copperplate Gothic Bold", 9);
            }
            customButton15.Font = font;
            customButton14.Font = font;
            customButton13.Font = font;
            customButton11.Font = font;
            customButton10.Font = font;
            typeLabel.Font = font;
            taskCompleteRate.Font = font;
            label9.Font = font;
            billLabel.Font = font;
            label5.Font = font;
            label11.Font = font;
            label2.Font = font;
            managementLabel.Font = font;
            label3.Font = font;
            apartmentStatusLabel.Font = font;
            label4.Font = font;
            label7.Font = font;


            filterLabel.Font = fontLarger;
            label6.Font = fontLarger;
            dayButton.Font = fontLarger;
            monthButton.Font = fontLarger;
            quarterButton.Font = fontLarger;
            yearButton.Font = fontLarger;
            label1.Font = fontLarger;
            label12.Font = fontLarger;


            label10.Font = fontSmaller;
            customButton4.Font = fontSmaller;
            cancelButton.Font = fontSmaller;
        }

        private void customButton4_Click(object sender, EventArgs e)
        {

            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                // Tạo worksheet và đặt tiêu đề
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("PieChart");
                ExcelWorksheet chartSheet = excelPackage.Workbook.Worksheets.Add("ColunmChart");

                // Merge các ô để tạo tiêu đề
                worksheet.Cells["A1:C1"].Merge = true;
                string heading = "Top 5 nhân viên làm việc tốt nhất ";
                // Đặt tiêu đề "Top 5 nhân viên làm việc tốt nhất"
                

                // Kết nối với cơ sở dữ liệu và truy vấn dữ liệu
                DatabaseConnection.Instance.OpenConnection();
                SqlConnection conn = DatabaseConnection.Instance.GetConnection();
                string timeType = "YEAR(";
                string timeSort = "";
                if (dayButton.Checked)
                {
                    timeType = "Day(";
                    heading += "ngày";
                }
                else if (monthButton.Checked)
                {
                    timeType = "Month(";
                    heading += "tháng";

                }
                else if (yearButton.Checked)
                {
                    timeType = "Year(";
                    heading += "năm";

                }
                else if (quarterButton.Checked)
                {
                    timeType = "datepart(q,";
                    heading += "quý";

                }
                timeSort = timeBox.Text;
                string sql = "";
                string querytong = "";
                if (timeSort == "")
                {

                    sql =
                   "SELECT NhanSu.hoVaTen, COUNT(*) AS SoLuongCongViecHoanThanh " +
                   "FROM NhanSu " +
                   "INNER JOIN NhanViec ON NhanSu.maThanhVien = NhanViec.maThanhVien " +
                   "INNER JOIN GiaoViec ON NhanViec.maGiaoViec = GiaoViec.maGiaoViec " +
                   $"WHERE {timeType}GiaoViec.hanHoanThanh) = {timeType}GETDATE()) AND YEAR(GiaoViec.hanHoanThanh) = YEAR(GETDATE()) AND tinhTrangCongViec LIKE N'Đã hoàn thành' " +
                   "GROUP BY NhanSu.hoVaTen " +
                   "ORDER BY COUNT(*) DESC";

                    querytong = "SELECT COUNT(*) AS TongCongViecHoanThanh " +
                        "FROM NhanSu " +
                        "INNER JOIN NhanViec ON NhanSu.maThanhVien = NhanViec.maThanhVien " +
                        "INNER JOIN GiaoViec ON NhanViec.maGiaoViec = GiaoViec.maGiaoViec " +
                        $"WHERE {timeType}GiaoViec.hanHoanThanh) = {timeType}GETDATE()) AND YEAR(GiaoViec.hanHoanThanh) = YEAR(GETDATE()) AND tinhTrangCongViec LIKE N'Đã hoàn thành'";


                }
                else
                {
                    sql =
                    "SELECT NhanSu.hoVaTen, COUNT(*) AS SoLuongCongViecHoanThanh " +
                    "FROM NhanSu " +
                    "INNER JOIN NhanViec ON NhanSu.maThanhVien = NhanViec.maThanhVien " +
                    "INNER JOIN GiaoViec ON NhanViec.maGiaoViec = GiaoViec.maGiaoViec " +
                    $"WHERE {timeType}GiaoViec.hanHoanThanh) = '{timeSort}' AND YEAR(GiaoViec.hanHoanThanh) = YEAR(GETDATE()) AND tinhTrangCongViec LIKE N'Đã hoàn thành' " +
                    "GROUP BY NhanSu.hoVaTen " +
                    "ORDER BY COUNT(*) DESC";

                    querytong = "SELECT COUNT(*) AS TongCongViecHoanThanh " +
                        "FROM NhanSu " +
                        "INNER JOIN NhanViec ON NhanSu.maThanhVien = NhanViec.maThanhVien " +
                        "INNER JOIN GiaoViec ON NhanViec.maGiaoViec = GiaoViec.maGiaoViec " +
                        $"WHERE {timeType}GiaoViec.hanHoanThanh) = '{timeSort}' AND YEAR(GiaoViec.hanHoanThanh) = YEAR(GETDATE()) AND tinhTrangCongViec LIKE N'Đã hoàn thành'";

                    heading +=" "+timeSort;

                }

                worksheet.Cells["A1"].Value = heading;

                worksheet.Cells["A1"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                MessageBox.Show(querytong);
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                // Tính tổng số lượng công việc của cả công ty
                SqlCommand command1 = new SqlCommand(querytong, conn);
                int tongCongViec = Convert.ToInt32(command1.ExecuteScalar());
                if (tongCongViec > 0)
                {
                    // Thêm dữ liệu vào tệp Excel
                    int row = 2; // Dòng bắt đầu của dữ liệu
                    worksheet.Cells[row, 1].Value = "Nhân viên";
                    worksheet.Cells[row, 2].Value = "Số lượng công việc hoàn thành";
                    worksheet.Cells[row, 3].Value = "Tỷ lệ (%)";
                    row++;
                    foreach (DataRow dataRow in dataTable.Rows)
                    {
                        worksheet.Cells[row, 1].Value = dataRow["hoVaTen"].ToString();
                        worksheet.Cells[row, 2].Value = Convert.ToInt32(dataRow["SoLuongCongViecHoanThanh"]);
                        double tyLe = Convert.ToDouble(dataRow["SoLuongCongViecHoanThanh"]) / tongCongViec * 100;
                        worksheet.Cells[row, 3].Value = tyLe;
                        row++;
                    }

                    // Vẽ biểu đồ tròn
                    var pieChart = worksheet.Drawings.AddChart("PieChart", OfficeOpenXml.Drawing.Chart.eChartType.Pie);
                    pieChart.SetPosition(0, 6, 6, 9);
                    pieChart.SetSize(600, 400);
                    pieChart.Series.Add(worksheet.Cells[$"C2:C{row - 1}"], worksheet.Cells[$"A2:A{row - 1}"]);
                }

                chartSheet.Cells["A1:C1"].Merge = true;
                chartSheet.Cells["A1"].Value = "Thống kê công việc đúng hạn và trễ hạn trong năm";
                chartSheet.Cells["A1"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                // Thêm dữ liệu vào sheet "Biểu đồ"
                chartSheet.Cells["A2"].Value = "Tháng";
                chartSheet.Cells["B2"].Value = "Công việc hoàn thành";
                chartSheet.Cells["C2"].Value = "Công việc trễ hạn";

                // Thực hiện truy vấn để lấy dữ liệu về số lượng công việc hoàn thành và trễ hạn theo tháng trong năm
                string monthlySQL =
                    "SELECT MONTH(GiaoViec.hanHoanThanh) AS Thang, " +
                    "SUM(CASE WHEN dungHan = 1 THEN 1 ELSE 0 END) AS CongViecHoanThanh, " +
                    "SUM(CASE WHEN dungHan = 0 THEN 1 ELSE 0 END) AS CongViecTreHan " +
                    "FROM GiaoViec " +
                    "WHERE YEAR(GiaoViec.hanHoanThanh) = YEAR(GETDATE()) " +
                    "GROUP BY MONTH(GiaoViec.hanHoanThanh) " +
                    "ORDER BY MONTH(GiaoViec.hanHoanThanh)";

                SqlCommand monthlyCommand = new SqlCommand(monthlySQL, conn);
                SqlDataAdapter monthlyAdapter = new SqlDataAdapter(monthlyCommand);
                DataTable monthlyDataTable = new DataTable();
                monthlyAdapter.Fill(monthlyDataTable);

                // Thêm dữ liệu vào sheet "Biểu đồ"
                int monthRow = 3; // Dòng bắt đầu của dữ liệu
                foreach (DataRow monthlyDataRow in monthlyDataTable.Rows)
                {
                    int month = Convert.ToInt32(monthlyDataRow["Thang"]);
                    int completedTasks = Convert.ToInt32(monthlyDataRow["CongViecHoanThanh"]);
                    int delayedTasks = Convert.ToInt32(monthlyDataRow["CongViecTreHan"]);

                    chartSheet.Cells[monthRow, 1].Value = month;
                    chartSheet.Cells[monthRow, 2].Value = completedTasks;
                    chartSheet.Cells[monthRow, 3].Value = delayedTasks;

                    monthRow++;
                }

                // Vẽ biểu đồ cột kép
                var columnChart = chartSheet.Drawings.AddChart("ColumnChart", OfficeOpenXml.Drawing.Chart.eChartType.ColumnClustered);
                columnChart.SetPosition(0, 0, 6, 0);
                columnChart.SetSize(800, 400);
                columnChart.Series.Add(chartSheet.Cells[$"B3:B{monthRow - 1}"], chartSheet.Cells[$"A3:A{monthRow - 1}"]);
                columnChart.Series.Add(chartSheet.Cells[$"C3:C{monthRow - 1}"], chartSheet.Cells[$"A3:A{monthRow - 1}"]);

                // Lưu tệp Excel vào một MemoryStream
                MemoryStream stream = new MemoryStream();
                excelPackage.SaveAs(stream);

                // Tạo một tên tạm thời cho file
                string tempFileName = Path.GetTempFileName();
                string excelFileName = Path.ChangeExtension(tempFileName, ".xlsx");

                // Ghi MemoryStream ra file Excel tạm thời
                using (FileStream file = new FileStream(excelFileName, FileMode.Create, FileAccess.Write))
                {
                    stream.WriteTo(file);
                }

                // Mở file Excel bằng Microsoft Excel
                // Sử dụng đường dẫn đầy đủ của Microsoft Excel
                string excelPath = GetExcelPath();

                // Kiểm tra xem tệp thực thi Excel có tồn tại không
                if (File.Exists(excelPath))
                {
                    // Mở file Excel bằng Microsoft Excel
                    System.Diagnostics.Process.Start(excelPath, excelFileName);
                }
                else
                {
                    MessageBox.Show("Không thể tìm thấy Microsoft Excel trên máy tính của bạn.");
                }

                // Đóng kết nối cơ sở dữ liệu
                DatabaseConnection.Instance.CloseConnection();
            }


        }

        private string GetExcelPath()
        {
            // Đường dẫn Registry của ứng dụng Excel
            const string excelPathKey = @"Software\Microsoft\Windows\CurrentVersion\App Paths\excel.exe";

            // Đọc đường dẫn từ Registry
            using (Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(excelPathKey))
            {
                if (key != null)
                {
                    Object o = key.GetValue("");
                    if (o != null)
                    {
                        return o.ToString();
                    }
                }
            }

            return null;

        }

        private void timeBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
