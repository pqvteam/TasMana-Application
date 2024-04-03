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
        public string check(string username, string password)
        {
            try
            {
                DatabaseConnection.Instance.OpenConnection();
                SqlConnection conn = DatabaseConnection.Instance.GetConnection();
                string sqlCommand = $"DECLARE @response NVARCHAR(30);" +
                    $"EXEC @response = dangNhap @maThanhVien = '{username}', @matKhau = '{password}';SELECT @response AS Response;";
                SqlCommand command = new SqlCommand(sqlCommand, conn);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return $"{reader["Response"]}";
                }
                return "Lỗi kết nối!!";
            }
            catch (Exception ex)
            {
                return "Lỗi kết nối!!";
            }
            finally { DatabaseConnection.Instance.CloseConnection(); }
        }
        public bool savePassword(string username, string password)
        {
            try
            {
                DatabaseConnection.Instance.OpenConnection();
                SqlConnection conn = DatabaseConnection.Instance.GetConnection();

                string sqlCommand = $"insert into LuuMatKhau(userID,matkhau) values('{username}','{password}')";
                SqlCommand command = new SqlCommand(sqlCommand, conn);
                int reader = command.ExecuteNonQuery();
                if (reader > 0)
                {
                    return true;
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

        public string sendCode(string username)
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
        public bool saveCode(string username, string code)
        {
            try
            {
                DatabaseConnection.Instance.OpenConnection();
                SqlConnection conn = DatabaseConnection.Instance.GetConnection();

                string sqlCommand = $"update LuuMatKhau set maxacnhan='{code}' where userID='{username}'";
                SqlCommand command = new SqlCommand(sqlCommand, conn);
                int reader = command.ExecuteNonQuery();

                if (reader > 0)
                {
                    return true;
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
        public bool confirmCode(string username ,string code)
        {
            try
            {
                DatabaseConnection.Instance.OpenConnection();
                SqlConnection conn = DatabaseConnection.Instance.GetConnection();

                string sqlCommand = $"select maxacnhan from LuuMatKhau where userID='{username}'";
                SqlCommand command = new SqlCommand(sqlCommand, conn);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string maXacNhan = $"{reader["maXacNhan"]}";
                    if(code.Equals(maXacNhan))
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
        public string getPassword(string username)
        {
            try
            {
                DatabaseConnection.Instance.OpenConnection();
                SqlConnection conn = DatabaseConnection.Instance.GetConnection();

                string sqlCommand = $"select matkhau from LuuMatKhau where userID='{username}'";
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
