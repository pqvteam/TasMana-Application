using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Repositories.Entities;

namespace Repositories
{
    public class NhanVienRepository
    {
        private TasManaContext db = new TasManaContext();
        static TasManaContext tasManaContext = new TasManaContext();
        private static string connectionString = tasManaContext.GetConnectionString();

        public NhanVien? get(string ID)
        {
            return db.NhanViens.Find(ID);
        }

        public List<NhanVien> getAll()
        {
            return db.NhanViens.ToList();
        }

        public List<NhanVien> getAllStaffOfDepartment(string departmentID)
        {
            return db.NhanViens.Where(x => x.MaThanhVien.Contains(departmentID)).ToList();
        }

        public List<NhanVien> getAllNoGroup()
        {
            return db.NhanViens.Where(x => x.MaNhom == null && x.LaQuanLi == false).ToList();
        }

        public NhanVien? findLeaderOfGroup(string groupID)
        {
            return db.NhanViens.FirstOrDefault(x => x.MaNhom == groupID && x.LaTruongNhom == true);
        }

        public void create(NhanVien nhanVien)
        {
            db.NhanViens.Add(nhanVien);
            db.SaveChanges();
        }

        public void update(NhanVien nhanVien)
        {
            db.NhanViens.Update(nhanVien);
            db.SaveChanges();
        }

        public void delete(string ID)
        {
            var foundStaff = db.NhanViens.FirstOrDefault(x => x.MaThanhVien == ID);
            if (foundStaff != null)
            {
                db.NhanViens.Remove(foundStaff);
                db.SaveChanges();
            }
        }

        public bool checkLeader(string ID)
        {
            return
                db.NhanViens.FirstOrDefault(x => x.MaThanhVien == ID && x.LaTruongNhom == true)
                != null
                ? true
                : false;
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
