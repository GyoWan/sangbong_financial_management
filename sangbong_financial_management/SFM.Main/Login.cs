using System;
using MetroFramework.Forms;
using sangbong_financial_management.SFM.Common.Database.DAL;
using sangbong_financial_management.SFM.Common.GlobalFunction;
using sangbong_financial_management.Properties;
using sangbong_financial_management.SFM.Common.Database.EFModel;
using System.Data;
using System.Windows.Forms;

namespace sangbong_financial_management.SFM.Main
{
    public partial class Login : MetroForm
    {
        SFMUserInfoDal sfmUserInfoDal = new SFMUserInfoDal();
        public Login()
        {
            InitializeComponent();


        }

        private void Mtbn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Mbtn_login_set_db_Click(object sender, EventArgs e)
        {
            var databaseSetting = new DatabaseSetting();
            databaseSetting.Show();
        }

        private void Mbtn_login_Click(object sender, EventArgs e)
        {
            SFMDatabaseModel sfmDatabaseModel = new SFMDatabaseModel();
            if (!sfmDatabaseModel.DatabaseConnection(Settings.Default.server, Settings.Default.userId, Settings.Default.userPw, Settings.Default.databaseName))
            {
                MsgBox.Error("데이터베이스 연결 오류!\n관리자에게 문의 바랍니다.\n관리자 연락처 : (010-4079-6295)");
            }
            else
            {
                var getUserInfo = sfmUserInfoDal.GetUserInfo(tb_login_id.Text.ToString(), tb_login_pw.Text.ToString());

                if(getUserInfo == 1)
                {
                    var main = new Main();
                    main.Show();
                }
                else
                {
                    MsgBox.Error("존재하지 않는 아이디 입니다.");
                }

            }
        }

        private void Tb_login_pw_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Mbtn_login_Click(null, null);
            }
        }
    }
}
