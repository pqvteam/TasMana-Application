using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Repositories.Entities;

namespace Repositories
{
    public class NhanViecRepository
    {
        static TasManaContext tasManaContext = new TasManaContext();
        TasManaContext db = new TasManaContext();
        private static string connectionString = tasManaContext.GetConnectionString();

        public List<Nhom> GetAll()
        {
            return db.Nhoms.ToList();
        }

        public bool Create(string name, string IDs, string ID)
        {
            bool success = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("taoNhom", conn))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        if (string.IsNullOrEmpty(name))
                        {
                            using (
                                SqlCommand getNewGroupIDCommand = new SqlCommand(
                                    "SELECT dbo.taoMaNhom()",
                                    conn
                                )
                            )
                            {
                                string newGroupID = (string)getNewGroupIDCommand.ExecuteScalar();
                                using (
                                    SqlCommand getNewGroupNameCommand = new SqlCommand(
                                        "SELECT dbo.taoTenNhom(@MaNhom)",
                                        conn
                                    )
                                )
                                {
                                    getNewGroupNameCommand.Parameters.AddWithValue(
                                        "@MaNhom",
                                        newGroupID
                                    );
                                    name = (string)getNewGroupNameCommand.ExecuteScalar();
                                }
                            }
                        }

                        command.Parameters.AddWithValue("@tenNhom", name);
                        command.Parameters.AddWithValue("@danhSachMaNV", IDs);
                        command.Parameters.AddWithValue("@maTruongNhom", ID);

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

        public bool Appoint(string staffID, string ID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("uyQuyenTruongNhom", conn))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@maThanhVien", staffID);
                        command.Parameters.AddWithValue("@maNguoiGiao", ID);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                            return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return false;
        }

        public bool Depose(string staffID, string ID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("truatQuyenTruongNhom", conn))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@maThanhVien", staffID);
                        command.Parameters.AddWithValue("@maNguoiGiao", ID);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                            return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return false;
        }
    }
}
