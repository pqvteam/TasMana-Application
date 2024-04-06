using Azure.Messaging;
using Microsoft.Data.SqlClient;
using Repositories.Entities;
using Repositories.Utilities;
using System;
using System.Collections.Generic;
using System.Formats.Tar;

namespace Repositories
{
    public class GiaoViecRepository
    {
        // We interact with DB here
        TasManaContext db = new TasManaContext();


        public GiaoViec? Get(string assignTaskID)
        {
            // Access DB
            return db.GiaoViecs.FirstOrDefault(x => x.MaGiaoViec.Equals(assignTaskID));
        }

        public List<GiaoViec> getAllTaskOfDepartment(string departmentID)
        {
            return db.GiaoViecs.Where(x => x.MaGiaoViec.Contains(departmentID)).ToList();
        }

        public List<GiaoViec> GetAll() { 
            return db.GiaoViecs.ToList();
        }

        public bool Create(string description, string day, string deadline, string status, string file, string id, int mode, string name, string venue, string receiverID, int isCEO, string CEOID)
        {
            DatabaseConnection.Instance.OpenConnection();

            SqlConnection conn = DatabaseConnection.Instance.GetConnection();
            bool isSuccess = false;
            string filetype;
            string filename;
            filetype = file.Substring(Convert.ToInt32(file.LastIndexOf(".")) + 1, file.Length - (Convert.ToInt32(file.LastIndexOf(".")) + 1));
            if (filetype.ToUpper() != "PDF")
            {
                return false;
            }
            byte[] FileBytes = null;

            try
            {
                // Open file to read using file path
                FileStream FS = new FileStream(file, System.IO.FileMode.Open, System.IO.FileAccess.Read);

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
            string departmentQuery = $"EXEC taoViec N'{description}', '{day}', '{deadline}', N'{status}', '{FileBytes}', '{id}', '{receiverID}', {mode}, N'{name}', {isCEO}, '{CEOID}', '{venue}'";
            using (SqlCommand cmd = new SqlCommand(departmentQuery, conn))
            {
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0) isSuccess = true;
            }

            SqlCommand sqlcmd = new SqlCommand("update GiaoViec set dinhKemFile = @FB where maGiaoViec = @ID", conn);
            sqlcmd.Parameters.AddWithValue("@FB", FileBytes);
            sqlcmd.Parameters.AddWithValue("@ID", id);
            sqlcmd.ExecuteNonQuery();
            DatabaseConnection.Instance.CloseConnection();
            return isSuccess;
        }
    }
}
