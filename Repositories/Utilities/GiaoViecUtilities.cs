using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Utilities
{
    public class GiaoViecUtilities
    {
        public static string createAssignTaskID(string maNguoiGiao)
        {
            TasManaContext tasManaContext = new TasManaContext();
            string connectionString = tasManaContext.GetConnectionString();
            string maGiaoViecMoi = "";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT TOP 1 maGiaoViec FROM GiaoViec WHERE maGiaoViec LIKE @MaNguoiGiao + '.%' ORDER BY maGiaoViec DESC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaNguoiGiao", maNguoiGiao);

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        string maGiaoViec = result.ToString();
                        int index = maGiaoViec.LastIndexOf('.');
                        int number = int.Parse(maGiaoViec.Substring(index + 1)) + 1;
                        maGiaoViecMoi = $"{maNguoiGiao}.{number:D3}";
                    }
                    else
                    {
                        maGiaoViecMoi = $"{maNguoiGiao}.001";
                    }
                }
            }

            return maGiaoViecMoi;
        }
    }
}
