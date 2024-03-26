using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Utilities
{
    public class DatabaseConnection
    {
        static TasManaContext tasManaContext = new TasManaContext();

           // The link to database
        private static string connectionString = tasManaContext.GetConnectionString();

            // Database instance
        private static SqlConnection connection;

            // (Singleton)
        private static readonly Lazy<DatabaseConnection> instance = new Lazy<DatabaseConnection>(() => new DatabaseConnection());

        public static DatabaseConnection Instance => instance.Value;
        private DatabaseConnection()
            {
                connection = new SqlConnection(connectionString);
            }

        public void OpenConnection()
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
            }

        public void CloseConnection()
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                }
            }

        public SqlConnection GetConnection()
        {
            return connection;
        }
    }
}
