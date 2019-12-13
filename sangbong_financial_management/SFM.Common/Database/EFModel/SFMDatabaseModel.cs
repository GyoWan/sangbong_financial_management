namespace sangbong_financial_management.SFM.Common.Database.EFModel
{
    using sangbong_financial_management.Properties;
    using sangbong_financial_management.SFM.Common.Database.Entity;
    using System;
    using System.Data;
    using System.Data.Entity;
    using System.Data.SqlClient;

    public partial class SFMDatabaseModel : DbContext
    {
        public SFMDatabaseModel()
            : base("name=SFMDataBaseModel")
        {
        }

        public virtual DbSet<SFM_POSITION> SFM_POSITION { get; set; }
        public virtual DbSet<SFM_USER_INFO> SFM_USER_INFO { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SFM_POSITION>()
                .HasOptional(e => e.SFM_POSITION1)
                .WithRequired(e => e.SFM_POSITION2);
        }

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
    }
}
