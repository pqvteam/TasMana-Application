using Microsoft.Data.SqlClient;
using Repositories.Entities;
using Repositories.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp.PixelFormats;
using System.IO;
using System.Drawing;

namespace Repositories
{
    public class NhanSuRepository
    {

        TasManaContext tasManaContext = new TasManaContext();
        static TasManaContext context = new TasManaContext();
        private static string connectionString = context.GetConnectionString();
        public NhanSu? findMember(string ID)
        {
            return tasManaContext.NhanSus.FirstOrDefault(x => x.MaThanhVien == ID);
        }

        public List<NhanSu> getAllMembersOfDepartment(string departmentID)
        {
            return tasManaContext.NhanSus.Where(x => x.MaThanhVien.Contains(departmentID)).ToList();
        }

        public List<NhanSu> getAllMembers()
        {
            return tasManaContext.NhanSus.ToList();
        }

        public List<NhanSu> getAllStaffs()
        {
            return tasManaContext.NhanSus.Where(x => x.LaQuanLi == false && !x.MaThanhVien.StartsWith("GD")).ToList();
        }

        public bool EditInformation(string ID, string newUserName, string newNumber, string newBirth, string newCID, string newEmail, string newAddress, string newGender)
        {
            bool success = false; // Initialize success flag
            try
            {
                // Open connection
                DatabaseConnection.Instance.OpenConnection();
                SqlConnection conn = DatabaseConnection.Instance.GetConnection();

                // Using the existing connection from DatabaseConnection
                using (conn)
                {
                    // Corrected query with parameter names matching
                    string queryEdit = "UPDATE NhanSu SET hoVaTen = @UserName, SDT = @Number, namSinh = @Birth, CCCD = @CID, email = @Email, diaChi = @Address, gioiTinh = @Gender WHERE maThanhVien = '" + ID + "'";

                    using (SqlCommand command = new SqlCommand(queryEdit, conn))
                    {
                        // Set parameter values
                        command.Parameters.AddWithValue("@UserName", newUserName);
                        command.Parameters.AddWithValue("@Number", newNumber);
                        command.Parameters.AddWithValue("@Birth", newBirth);
                        command.Parameters.AddWithValue("@CID", newCID);
                        command.Parameters.AddWithValue("@Email", newEmail);
                        command.Parameters.AddWithValue("@Address", newAddress);
                        command.Parameters.AddWithValue("@Gender", newGender);

                        // Execute query
                        int rowsAffected = command.ExecuteNonQuery();
                        success = rowsAffected > 0; // Set success flag based on rows affected
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception (log, display message, etc.)
            }
            finally
            {
                DatabaseConnection.Instance.CloseConnection();
            }

            return success; // Return whether the operation was successful
        }

        public void insertAvatar(byte[] image, string userID)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {

                conn.Open();

                using (SqlCommand command = new SqlCommand("UPDATE NhanSu SET anhDaiDien = @image WHERE maThanhVien = @userID", conn))
                {
                    command.Parameters.AddWithValue("@image", image);
                    command.Parameters.AddWithValue("@userID", userID);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        public byte[] convertImageToByte(Image<Rgba32> img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.SaveAsPng(ms);
                return ms.ToArray();
            }
        }

        public Image<Rgba32> convertByteToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.Load<Rgba32>(ms);
            }
        }
    }
}
