using Microsoft.Data.SqlClient;
using Repositories.Entities;
using Repositories.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CEORepository
    {
        static TasManaContext tasManaContext = new TasManaContext();
        TasManaContext db = new TasManaContext();
        private static string connectionString = tasManaContext.GetConnectionString();
        public Ceo? Find(string ID)
        {
            return db.Ceos.FirstOrDefault(x => x.MaThanhVien == ID);
        }

        public bool AppointManager(string staffID, string CEOID)
        {
            bool success = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("uyQuyen", conn))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@maThanhVien", staffID);
                        command.Parameters.AddWithValue("@maCEO", CEOID);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            success = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return success;
        }

        public bool DeposeManager(string staffID, string CEOID)
        {
            bool success = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("truatQuyen", conn))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@maThanhVien", staffID);
                        command.Parameters.AddWithValue("@maCEO", CEOID);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            success = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return success;
        }
    }
}
