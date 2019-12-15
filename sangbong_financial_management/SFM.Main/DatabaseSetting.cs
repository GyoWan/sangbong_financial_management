using System;
using MetroFramework.Forms;
using sangbong_financial_management.Properties;
using sangbong_financial_management.SFM.Common.Database;
using sangbong_financial_management.SFM.Common.GlobalFunction;

namespace sangbong_financial_management.SFM.Main
{

    public partial class DatabaseSetting : MetroForm
    {
        SFMDatabaseSetting sfmDatabaseSetting = new SFMDatabaseSetting();
        public DatabaseSetting()
        {
            InitializeComponent();
        }

        private void mbtn_db_setting_test_Click(object sender, EventArgs e)
        {
            string server = tb_db_setting_server_name.Text;
            string userId = tb_db_setting_user_id.Text;
            string userPw = tb_db_setting_user_pw.Text;
            string databaseName = tb_db_setting_db_name.Text;

            if (!sfmDatabaseSetting.DatabaseConnection(server, userId, userPw, databaseName))
            {
                MsgBox.Error("데이터베이스 연결 오류!\n관리자에게 문의 바랍니다.\n관리자 연락처 : (010-4079-6295)");
            }
            else
            {
                MsgBox.Info("데이터베이스 연결 완료.");
            }
        }

        private void DatabaseSetting_Load(object sender, EventArgs e)
        {
            tb_db_setting_server_name.Text = Settings.Default.server;
            tb_db_setting_user_id.Text = Settings.Default.userId;
            tb_db_setting_user_pw.Text = Settings.Default.userPw;
            tb_db_setting_db_name.Text = Settings.Default.databaseName;
        }

        private void mbtn_db_setting_ok_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mbtn_db_setting_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
