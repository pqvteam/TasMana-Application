using Microsoft.Data.SqlClient;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class QuanLyRepository
    {
        static TasManaContext tasManaContext = new TasManaContext();
        TasManaContext db = new TasManaContext();
        private static string connectionString = tasManaContext.GetConnectionString();
        public QuanLi? getManager(string departmentID)
        {
            TasManaContext db = new TasManaContext();
            return db.QuanLis.FirstOrDefault(x => x.MaThanhVien.IndexOf(departmentID) != -1);
        }

        public List<QuanLi>? getAllManager(string departmentID)
        {
            TasManaContext db = new TasManaContext();
            return db.QuanLis.Where(x => x.MaThanhVien.IndexOf(departmentID) != -1).ToList();
        }
        public bool DeactiveStaff(string staffID, string Manager)
        {
            bool success = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("voHieuTaiKhoan", conn))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@maNguoiThucHien", Manager);
                        command.Parameters.AddWithValue("@maNhanVien", staffID);

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
