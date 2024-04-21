using Microsoft.Data.SqlClient;
using Repositories.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class KhuVucLamViecRepository
    {
        public string getVenue(string ID)
        {
            try
            {
                DatabaseConnection.Instance.OpenConnection();
                SqlConnection conn = DatabaseConnection.Instance.GetConnection();

                string sqlCommand = "SELECT maCH FROM KhuVucLamViec WHERE maGiaoViec = @ID";
                SqlCommand command = new SqlCommand(sqlCommand, conn);
                command.Parameters.AddWithValue("@ID", ID);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return $"{reader["maCH"]}";
                }
                return "Khu vực này không tồn tại";
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
