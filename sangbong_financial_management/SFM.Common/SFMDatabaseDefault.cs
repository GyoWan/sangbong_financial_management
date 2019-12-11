using System;
using System.Data;
using System.Data.SqlClient;
using sangbong_financial_management.Properties;

namespace sangbong_financial_management.SFM.Common
{
    public class SFMDatabaseDefault
    {
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
    }
}
