using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Repositories.Entities;
using Repositories.Utilities;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Repositories
{
    public class DangNhapRepository
    {
        static TasManaContext tasManaContext = new TasManaContext();
        TasManaContext db = new TasManaContext();
        private static string connectionString = tasManaContext.GetConnectionString();
        string maXacNhan = "";
        //Login Function

        public string check(string username, string password)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                string sqlCommand =
                    $"DECLARE @response NVARCHAR(30);"
                    + $"EXEC @response = dangNhap @maThanhVien = '{username}', @matKhau = '{password}';SELECT @response AS Response;";
                SqlCommand command = new SqlCommand(sqlCommand, conn);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string result = $"{reader["Response"]}";
                    return $"{reader["Response"]}";
                }
                return "Lỗi kết nối!";
            }
            catch (Exception ex)
            {
                return "Lỗi kết nối!!";
            }
            finally
            {
                conn.Close();
            }
        }

        public bool savePassword(string username, string password)
        {
            try
            {
                DatabaseConnection.Instance.OpenConnection();
                SqlConnection conn = DatabaseConnection.Instance.GetConnection();

                //string sqlCommand = $"select * from LuuMatKhau where userID='{username}'";
                string sqlCommand = $"select * from NhanSu where maThanhVien='{username}'";
                SqlCommand command = new SqlCommand(sqlCommand, conn);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    reader.Close();
                    string sqlCommand1 =
                        //$"update LuuMatKhau set matkhau = '{password}' where userID='{username}'";
                    $"update NhanSu set matKhau = '{password}' where maThanhVien='{username}'";
                    SqlCommand command1 = new SqlCommand(sqlCommand1, conn);
                    int reader1 = command1.ExecuteNonQuery();
                    if (reader1 > 0)
                    {
                        return true;
                    }
                }
                else
                {
                    reader.Close();
                    string sqlCommand1 =
                        //$"insert into LuuMatKhau(userID,matkhau) values('{username}','{password}')";
                    $"insert into NhanSu(maThanhVien,matKhau) values('{username}','{password}')";
                    SqlCommand command1 = new SqlCommand(sqlCommand1, conn);
                    int reader1 = command1.ExecuteNonQuery();
                    if (reader1 > 0)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                DatabaseConnection.Instance.CloseConnection();
            }
        }

        public string getEmail(string username)
        {
            try
            {
                DatabaseConnection.Instance.OpenConnection();
                SqlConnection conn = DatabaseConnection.Instance.GetConnection();

                string sqlCommand = $"select email from NhanSu where maThanhVien='{username}'";
                SqlCommand command = new SqlCommand(sqlCommand, conn);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return $"{reader["email"]}";
                }
                return "Nhân viên này không tồn tại";
            }
            catch (Exception ex)
            {
                return "Lỗi kết nối dữ liệu";
            }
            finally
            {
                DatabaseConnection.Instance.CloseConnection();
            }
        }

        //Session function
        public string laCEO(string username)
        {
            try
            {
                DatabaseConnection.Instance.OpenConnection();
                SqlConnection conn = DatabaseConnection.Instance.GetConnection();

                string sqlCommand = $"select * from CEO where maThanhVien='{username}'";
                SqlCommand command = new SqlCommand(sqlCommand, conn);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return "1";
                }
                return "0";
            }
            catch (Exception ex)
            {
                return "Lỗi kết nối dữ liệu!";
            }
            finally
            {
                DatabaseConnection.Instance.CloseConnection();
            }
        }


        public string laQuanLi(string username)
        {
            try
            {
                DatabaseConnection.Instance.OpenConnection();
                SqlConnection conn = DatabaseConnection.Instance.GetConnection();

                string sqlCommand = $"select laQuanLi from NhanSu where maThanhVien='{username}'";
                SqlCommand command = new SqlCommand(sqlCommand, conn);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return $"{reader["laQuanLi"]}";
                }
                return "Lỗi kết nối dữ liệu!";
            }
            catch (Exception ex)
            {
                return "Lỗi kết nối dữ liệu!";
            }
            finally
            {
                DatabaseConnection.Instance.CloseConnection();
            }
        }

        public string laTruongNhom(string username)
        {
            try
            {
                DatabaseConnection.Instance.OpenConnection();
                SqlConnection conn = DatabaseConnection.Instance.GetConnection();

                string sqlCommand =
                    $"select NhanVien.laTruongNhom from NhanSu,NhanVien where NhanSu.maThanhVien=NhanVien.maThanhVien and NhanSu.maThanhVien='{username}'";
                SqlCommand command = new SqlCommand(sqlCommand, conn);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return $"{reader["laTruongNhom"]}";
                }
                return "Lỗi kết nối dữ liệu!";
            }
            catch (Exception ex)
            {
                return "Lỗi kết nối dữ liệu!";
            }
            finally
            {
                DatabaseConnection.Instance.CloseConnection();
            }
        }

        public string daNghiViec(string username)
        {
            try
            {
                DatabaseConnection.Instance.OpenConnection();
                SqlConnection conn = DatabaseConnection.Instance.GetConnection();

                string sqlCommand = $"select nghiViec from NhanSu where maThanhVien='{username}'";
                SqlCommand command = new SqlCommand(sqlCommand, conn);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return $"{reader["nghiViec"]}";
                }
                return "Lỗi kết nối dữ liệu!";
            }
            catch (Exception ex)
            {
                return "Lỗi kết nối dữ liệu!";
            }
            finally
            {
                DatabaseConnection.Instance.CloseConnection();
            }
        }

        //ForgotPassword function
        public void saveCode(string username, string code)
        {
            maXacNhan = code;
        }
        ///
        public bool confirmCode(string username, string code)
        {
            if (code.Equals(maXacNhan))
            {
                  return true;
            }
            return false;
        }

        public string getPassword(string username)
        {
            try
            {
                DatabaseConnection.Instance.OpenConnection();
                SqlConnection conn = DatabaseConnection.Instance.GetConnection();

                string sqlCommand = $"select matKhau from NhanSu where maThanhVien='{username}'";
                SqlCommand command = new SqlCommand(sqlCommand, conn);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return $"{reader["matkhau"]}";
                }
                return "Lỗi kết nối dữ liệu!";
            }
            catch (Exception ex)
            {
                return "Lỗi kết nối dữ liệu!!";
            }
            finally
            {
                DatabaseConnection.Instance.CloseConnection();
            }
        }
    }
}
