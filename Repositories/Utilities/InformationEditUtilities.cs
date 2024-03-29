using Microsoft.Data.SqlClient;
using System;

namespace Repositories.Utilities
{
    public class InformationEditUtilities
    {
        public static void editInformation(string newUserName, string newNumber, DateOnly newBirth, string newCID, string newEmail, string newAddress, string newGender)
        {
            TasManaContext tasManaContext = new TasManaContext();
            string connectionString = tasManaContext.GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryEdit = "UPDATE NhanSu SET hoVaTen = @UserName, SDT = @Number, namSinh = @Birth, CCCD = @CID, email = @Email, diaChi = @address, gioiTinh = @gender WHERE maThanhVien = 'DV-102'";

                using (SqlCommand command = new SqlCommand(queryEdit, connection))
                {
                    command.Parameters.AddWithValue("@HoVaTen", newUserName);
                    command.Parameters.AddWithValue("@Sdt", newNumber);
                    command.Parameters.AddWithValue("@NamSinh", newBirth);
                    command.Parameters.AddWithValue("@Cccd", newCID);
                    command.Parameters.AddWithValue("@Email", newEmail);
                    command.Parameters.AddWithValue("@DiaChi", newAddress);
                    command.Parameters.AddWithValue("@GioiTinh", newGender);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
