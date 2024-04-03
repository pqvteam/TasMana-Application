using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Repositories.Entities;
using Repositories.Utilities;


namespace Repositories
{
    public class DangNhapRepository
    {
        public string check(string username, string password)
        {
                DatabaseConnection.Instance.OpenConnection();
                SqlConnection conn = DatabaseConnection.Instance.GetConnection();
                string sqlCommand = $"DECLARE @response NVARCHAR(30);" +
                    $"EXEC @response = dangNhap @maThanhVien = '{username}', @matKhau = '{password}';SELECT @response AS Response;";
                SqlCommand command = new SqlCommand(sqlCommand, conn);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string response = $"{reader["Response"]}";
                    //
                    return response;
                }
            DatabaseConnection.Instance.CloseConnection();
            return "Lỗi truy cập dữ liệu1";
            

        }
        public bool save(string username, string password)
        {
            try
            {
                DatabaseConnection.Instance.OpenConnection();
                SqlConnection conn = DatabaseConnection.Instance.GetConnection();

                string sqlCommand = $"insert into LuuMatKhau(userID,matkhau) values('" + username + "','" + password + "')";
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
    }
}
