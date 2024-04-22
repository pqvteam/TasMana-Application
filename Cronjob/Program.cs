using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Net;
using System.Net.Mail;

class Program
{
    private static string connectionString =
        "Data Source=LAPTOP-SM9GFST3\\SQLEXPRESS;Initial Catalog=TasMana;Integrated Security=True;";

    static void Main(string[] args)
    {
        Console.WriteLine("Cron job running...");
        // GetDataFromDanhSachCaHoc();
        remindToCompleteJob();
    }

    public static void remindToCompleteJob()
    {
        string query =
            "SELECT hanHoanThanh, email, tenCongViec, tinhTrangCongViec, GiaoViec.maGiaoViec FROM NhanViec INNER JOIN GiaoViec ON NhanViec.maGiaoViec = GiaoViec.maGiaoViec INNER JOIN NhanSu ON NhanViec.maThanhVien = NhanSu.maThanhVien";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        string subject = "NHẮC NHỞ CÔNG VIỆC CHƯA HOÀN THÀNH";
                        string email = (string)row["email"];
                        string name = (string)row["tenCongViec"];
                        string status = (string)row["tinhTrangCongViec"];
                        string ID = (string)row["maGiaoViec"];
                        string assignerID = ID.Split('.')[0];
                        DateTime day = (DateTime)row["hanHoanThanh"];

                        string assignerEmailQuery =
                            "SELECT email FROM NhanSu WHERE maThanhVien = @assignerID";
                        string assignerEmail = "";
                        using (
                            SqlCommand assignerCommand = new SqlCommand(
                                assignerEmailQuery,
                                connection
                            )
                        )
                        {
                            assignerCommand.Parameters.AddWithValue("@assignerID", assignerID);
                            assignerEmail = (string)assignerCommand.ExecuteScalar();
                        }

                        DateTime nextFiveDay = DateTime.Today.AddDays(5);
                        if (day.Date == nextFiveDay.Date)
                        {
                            string content = "";
                            if (!status.Equals("Completed"))
                            {
                                Console.WriteLine($"5 ngày nữa {email} có deadline");
                                content =
                                    $"Ngày {nextFiveDay.Date} bạn có deadline cho công việc {name}, tình trạng công việc hiện tại của bạn là {status}. Để biết thêm chi tiết, vui lòng đăng nhập app TasMana để xem chi tiết công việc và thực hiện đúng hạn nhé.\nChúc bạn có một ngày vui vẻ!";
                                sendMail(subject, content, email);
                            }
                            else
                            {
                                Console.WriteLine($"5 ngày nữa {email} có deadline");
                                content =
                                    $"Ngày {nextFiveDay.Date} bạn có deadline cho công việc {name}. Để biết thêm chi tiết, vui lòng đăng nhập app TasMana để xem chi tiết công việc và thực hiện đúng hạn nhé.\nChúc bạn có một ngày vui vẻ!";
                                sendMail(subject, content, email);
                            }
                            string assignerSubject =
                                "THÔNG BÁO VỀ CÔNG VIỆC CÁC NHÂN VIÊN CHƯA CẬP NHẬT TIẾN ĐỘ";
                            string assignerContent =
                                $"Ngày {nextFiveDay.Date} công việc {ID} - {name} do bạn giao sẽ đến hạn chót, tuy vậy nhân viên vẫn chưa hoàn thành. Để biết thêm chi tiết, vui lòng đăng nhập app TasMana để xem chi tiết công việc và nhắc nhở nhân viên thực hiện đúng hạn nhé.\nChúc bạn có một ngày vui vẻ!";
                            sendMail(assignerSubject, assignerContent, assignerEmail);
                            Console.WriteLine("Send notification to assigner successfully!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }
    }

    public static void sendMail(string mailSubject, string content, string mailAddress)
    {
        try
        {
            var fromAddress = new MailAddress("thevi16102004@gmail.com");
            var toAddress = new MailAddress(mailAddress);
            const string frompass = "dbfg bnmi ltsl ofyj";
            var subject = mailSubject;
            string body = content;

            var smtp = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, frompass),
                Timeout = 200000
            };

            using (
                var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                }
            )
            {
                smtp.Send(message);
            }
        }
        catch (Exception ex) { }
    }
}
