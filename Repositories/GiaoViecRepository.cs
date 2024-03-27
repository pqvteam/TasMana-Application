using Azure.Messaging;
using Microsoft.Data.SqlClient;
using Repositories.Entities;
using Repositories.Utilities;
using System;
using System.Collections.Generic;

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
            // Mở kết nối đến cơ sở dữ liệu
            DatabaseConnection.Instance.OpenConnection();

            SqlConnection conn = DatabaseConnection.Instance.GetConnection();
            // Assign Task
            string departmentQuery = $"EXEC taoViec N'{description}', '{day}', '{deadline}', N'{status}', '{file}', '{id}', '{receiverID}', {mode}, N'{name}', {isCEO}, '{CEOID}', '{venue}'";
            using (SqlCommand cmd = new SqlCommand(departmentQuery, conn))
            {
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0) return true;
            }
            DatabaseConnection.Instance.CloseConnection();
            return false;
        }
    }
}
