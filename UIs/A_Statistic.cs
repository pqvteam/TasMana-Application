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
using Microsoft.Data.SqlClient;
using Repositories.Entities;
using Repositories.Utilities;
using Services;

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
    }
}
