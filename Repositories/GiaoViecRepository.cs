using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Formats.Tar;
using System.Reflection.PortableExecutable;
using Azure.Messaging;
using iTextSharp.text.pdf;
using Microsoft.Data.SqlClient;
using Repositories.Entities;
using Repositories.Utilities;

namespace Repositories
{
    public class GiaoViecRepository
    {
        // We interact with DB here
        static TasManaContext tasManaContext = new TasManaContext();
        TasManaContext db = new TasManaContext();
        private static string connectionString = tasManaContext.GetConnectionString();

        public GiaoViec? Get(string assignTaskID)
        {
            // Access DB
            return db.GiaoViecs.FirstOrDefault(x => x.MaGiaoViec.Equals(assignTaskID));
        }

        public List<GiaoViec> getAllTaskOfDepartment(string departmentID)
        {
            return db.GiaoViecs.Where(x => x.MaGiaoViec.Contains(departmentID)).ToList();
        }

        //public List<GiaoViec> getAllTaskOfStaff(string staffID)
        //{
        //    return db.GiaoViecs.Where(x => x.MaGiaoViec.Contains(staffID)).ToList();
        //}

        public List<GiaoViec> GetAll()
        {
            return db.GiaoViecs.ToList();
        }

        public void DownLoadFile(string id)
        {
            byte[] dbbyte;

            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand(
                    "SELECT dinhKemFile FROM GiaoViec WHERE maGiaoViec = @MaGiaoViec",
                    sqlcon
                );
                sqlcmd.Parameters.AddWithValue("@MaGiaoViec", id);
                dbbyte = (byte[])sqlcmd.ExecuteScalar();
            }

            if (dbbyte != null)
            {
                string filepath = $"D:\\Task_{id}_File.pdf";
                File.WriteAllBytes(filepath, dbbyte);
                Process.Start("explorer", filepath);
            }
        }

        public bool IsPdfValid(string id)
        {
            try
            {
                byte[] dbbyte;

                using (SqlConnection sqlcon = new SqlConnection(connectionString))
                {
                    sqlcon.Open();
                    SqlCommand sqlcmd = new SqlCommand(
                        "SELECT dinhKemFile FROM GiaoViec WHERE maGiaoViec = @MaGiaoViec",
                        sqlcon
                    );
                    sqlcmd.Parameters.AddWithValue("@MaGiaoViec", id);
                    dbbyte = (byte[])sqlcmd.ExecuteScalar();
                }

                using (MemoryStream stream = new MemoryStream(dbbyte))
                {
                    PdfReader reader = new PdfReader(stream);
                    return reader.NumberOfPages > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi kiểm tra tính hợp lệ của tệp PDF: " + ex.Message);
                return false;
            }
        }

        public bool Create(
            string description,
            string day,
            string deadline,
            string status,
            string file,
            string id,
            int mode,
            string name,
            string venue,
            string receiverID,
            int isCEO,
            string CEOID,
            string authorizedBy
        )
        {
            DatabaseConnection.Instance.OpenConnection();

            SqlConnection conn = DatabaseConnection.Instance.GetConnection();
            bool isSuccess = false;
            string filetype;
            string filename;
            filetype = file.Substring(
                Convert.ToInt32(file.LastIndexOf(".")) + 1,
                file.Length - (Convert.ToInt32(file.LastIndexOf(".")) + 1)
            );
            if (filetype.ToUpper() != "PDF")
            {
                return false;
            }
            byte[] FileBytes = null;

            try
            {
                // Open file to read using file path
                FileStream FS = new FileStream(
                    file,
                    System.IO.FileMode.Open,
                    System.IO.FileAccess.Read
                );

                // Add filestream to binary reader
                BinaryReader BR = new BinaryReader(FS);

                // get total byte length of the file
                long allbytes = new FileInfo(file).Length;

                // read entire file into buffer
                FileBytes = BR.ReadBytes((Int32)allbytes);

                // close all instances
                FS.Close();
                FS.Dispose();
                BR.Close();
            }
            catch (Exception ex)
            {
                return false;
            }

            // Assign Task
            string departmentQuery =
                $"EXEC taoViec N'{description}', '{day}', '{deadline}', N'{status}', '{FileBytes}', '{id}', '{receiverID}', {mode}, N'{name}', {isCEO}, '{CEOID}', '{venue}', '{authorizedBy}'";
            using (SqlCommand cmd = new SqlCommand(departmentQuery, conn))
            {
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                    isSuccess = true;
            }

            SqlCommand sqlcmd = new SqlCommand(
                "update GiaoViec set dinhKemFile = @FB where maGiaoViec = @ID",
                conn
            );
            sqlcmd.Parameters.AddWithValue("@FB", FileBytes);
            sqlcmd.Parameters.AddWithValue("@ID", id);
            sqlcmd.ExecuteNonQuery();
            DatabaseConnection.Instance.CloseConnection();
            return isSuccess;
        }

        public void UpdateProcess(string id, string status)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {

                conn.Open();

                using (SqlCommand command = new SqlCommand("UPDATE GiaoViec SET tinhTrangCongViec = @status WHERE maGiaoViec = @id", conn))
                {
                    command.Parameters.AddWithValue("@status", status);
                    command.Parameters.AddWithValue("@id", id);
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

        public bool Update(
            string description,
            string day,
            string deadline,
            string status,
            string file,
            string id,
            int mode,
            string name,
            string venue,
            string receiverID,
            int isCEO,
            string CEOID,
            string authorizedBy
        )
        {
            DatabaseConnection.Instance.OpenConnection();
            byte[] FileBytes = null;
            SqlConnection conn = DatabaseConnection.Instance.GetConnection();
            bool isSuccess = false;
            string departmentQuery = "";
            // Update Task
            if (file != "")
            {
                departmentQuery =
                    $"EXEC capNhatViec N'{description}', '{day}', '{deadline}', N'{status}', '{FileBytes}', '{id}', '{receiverID}', {mode}, N'{name}', {isCEO}, '{CEOID}', '{venue}', '{authorizedBy}'";
            }
            else
            {
                departmentQuery =
                    $"EXEC capNhatViecKhongFile N'{description}', '{day}', '{deadline}', N'{status}', '{FileBytes}', '{id}', '{receiverID}', {mode}, N'{name}', {isCEO}, '{CEOID}', '{venue}', '{authorizedBy}'";
            }
            using (SqlCommand cmd = new SqlCommand(departmentQuery, conn))
            {
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                    isSuccess = true;
            }
            if (file != "")
            {
                string filetype;
                string filename;

                filetype = file.Substring(
                    Convert.ToInt32(file.LastIndexOf(".")) + 1,
                    file.Length - (Convert.ToInt32(file.LastIndexOf(".")) + 1)
                );
                if (filetype.ToUpper() != "PDF")
                {
                    return false;
                }

                try
                {
                    // Open file to read using file path
                    FileStream FS = new FileStream(
                        file,
                        System.IO.FileMode.Open,
                        System.IO.FileAccess.Read
                    );

                    // Add filestream to binary reader
                    BinaryReader BR = new BinaryReader(FS);

                    // get total byte length of the file
                    long allbytes = new FileInfo(file).Length;

                    // read entire file into buffer
                    FileBytes = BR.ReadBytes((Int32)allbytes);

                    // close all instances
                    FS.Close();
                    FS.Dispose();
                    BR.Close();
                }
                catch (Exception ex)
                {
                    return false;
                }
                SqlCommand sqlcmd = new SqlCommand(
                    "update GiaoViec set dinhKemFile = @FB where maGiaoViec = @ID",
                    conn
                );
                sqlcmd.Parameters.AddWithValue("@FB", FileBytes);
                sqlcmd.Parameters.AddWithValue("@ID", id);
                sqlcmd.ExecuteNonQuery();
                DatabaseConnection.Instance.CloseConnection();
            }
            return isSuccess;
        }
    }
}
