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
    public class NhanViecRepository
    {
        public string getImplementor(string ID)
        {
            try
            {
                DatabaseConnection.Instance.OpenConnection();
                SqlConnection conn = DatabaseConnection.Instance.GetConnection();

                string sqlCommand = "SELECT maThanhVien FROM NhanViec WHERE maGiaoViec = @ID";
                SqlCommand command = new SqlCommand(sqlCommand, conn);
                command.Parameters.AddWithValue("@ID", ID);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return $"{reader["maThanhVien"]}";
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
    }
}
