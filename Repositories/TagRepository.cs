using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class TagRepository
    {
        static TasManaContext tasManaContext = new TasManaContext();
        private static string connectionString = tasManaContext.GetConnectionString();

        public List<(string tenTag, string maGiaoViec, string moTa)> GetAllTags()
        {
            List<(string tenTag, string maGiaoViec, string moTa)> tags = new List<(string, string, string)>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT tenTag, maGiaoViec, moTa FROM Tag " +
                               "GROUP BY tenTag, maGiaoViec, moTa";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string tenTag = reader["tenTag"].ToString();
                            string maGiaoViec = reader["maGiaoViec"].ToString();
                            string moTa = reader["moTa"].ToString();
                            tags.Add((tenTag, maGiaoViec, moTa));
                        }
                    }
                }
            }

            return tags;
        }

        public List<(string tenTag, string maGiaoViec, string moTa)> GetTagsByMaGiaoViec(string maGiaoViec)
        {
            List<(string tenTag, string maGiaoViec, string moTa)> tags = new List<(string, string, string)>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT tenTag, maGiaoViec, moTa FROM Tag " +
                               "WHERE maGiaoViec = @maGiaoViec";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@maGiaoViec", maGiaoViec);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string tenTag = reader["tenTag"].ToString();
                            string maGiaoViecResult = reader["maGiaoViec"].ToString();
                            string moTa = reader["moTa"].ToString();
                            tags.Add((tenTag, maGiaoViecResult, moTa));
                        }
                    }
                }
            }

            return tags;
        }

        public bool Create(string name, string description)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sqlCommand =
                        "INSERT INTO tag (tenTag, moTa) VALUES (@name, @description)";
                    SqlCommand command = new SqlCommand(sqlCommand, conn);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@description", description);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool Add(string name, string ID, string description = "")
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("themTag", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@tenTag", name);
                    cmd.Parameters.AddWithValue("@maGiaoViec", ID);
                    cmd.Parameters.AddWithValue("@moTa", description);

                    SqlParameter returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
                    returnParameter.Direction = ParameterDirection.ReturnValue;

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    int returnValue = (int)returnParameter.Value;
                    if (returnValue == -1)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }
    }
}
