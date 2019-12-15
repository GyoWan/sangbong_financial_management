using sangbong_financial_management.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sangbong_financial_management.SFM.Common.Database
{
    public class SFMDatabaseSetting
    {
        private const int TIME_OUT = 30;

        public SqlConnection SqlConnection()
        {
            SqlConnection sqlConnection;
            string server = Settings.Default.server;
            string uid = Settings.Default.userId;
            string pwd = Settings.Default.userPw;
            string databaseName = Settings.Default.databaseName;

            sqlConnection = new SqlConnection($"server={server};uid ={uid};pwd ={pwd};database={databaseName}");

            return sqlConnection;
        }

        public bool DatabaseConnection(string server, string userId, string userPw, string databaseName)
        {
            using (SqlConnection sqlConnection = new SqlConnection($"server={server};uid ={userId};pwd ={userPw};database={databaseName}"))
            {
                try
                {
                    sqlConnection.Open();
                    if (sqlConnection.State.Equals(ConnectionState.Closed))
                        return false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }

                Settings.Default.server = server;
                Settings.Default.userId = userId;
                Settings.Default.userPw = userPw;
                Settings.Default.databaseName = databaseName;
                Settings.Default.Save();

                return true;
            }

        }

        public DataTable ReadQuery(string query)
        {
            using (var connection = SqlConnection())
            {
                using (var sqlCommand = new SqlCommand(query, connection) { CommandTimeout = TIME_OUT })
                using (var adapter = new SqlDataAdapter(sqlCommand))
                {
                    var dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }


        public void ExecuteQuery(string query)
        {
            using (var connection = SqlConnection())
            {
                connection.Open();
                using (var command = new SqlCommand(query, connection) { CommandTimeout = TIME_OUT })
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public SqlParameter[] ExecuteStoredProcedure(
            string storedProcedureName,
            IEnumerable<SqlParameter> inputParameters,
            params SqlParameter[] outputParameters)
        {
            using (var connection = SqlConnection())
            {
                connection.Open();
                using (var command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    foreach (var parameter in inputParameters)
                    {
                        command.Parameters.Add(parameter);
                    }
                    foreach (var parameter in outputParameters)
                    {
                        command.Parameters.Add(parameter);
                    }
                    command.ExecuteNonQuery();
                    return outputParameters;
                }
            }
        }
    }
}
