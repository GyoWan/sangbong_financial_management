using System;
using MetroFramework.Forms;
using sangbong_financial_management.SFM.Common.Database;
using sangbong_financial_management.SFM.Common.Database.DAL;
using sangbong_financial_management.SFM.Common.GlobalFunction;
using sangbong_financial_management.Properties;
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
            Application.Exit();
        }

        private void Mbtn_login_set_db_Click(object sender, EventArgs e)
        {
            var databaseSetting = new DatabaseSetting();
            databaseSetting.Show();
        }

        private void Mbtn_login_Click(object sender, EventArgs e)
        {
            SFMDatabaseSetting sfmDatabaseSetting = new SFMDatabaseSetting();

            if (!sfmDatabaseSetting.DatabaseConnection(Settings.Default.server, Settings.Default.userId, Settings.Default.userPw, Settings.Default.databaseName))
            {
                MsgBox.Error("데이터베이스 연결 오류!\n관리자에게 문의 바랍니다.\n관리자 연락처 : (010-4079-6295)");
            }
            else
            {
                var uerExistCheck = sfmUserInfoDal.UserExistCheck(tb_login_id.Text.ToString(), tb_login_pw.Text.ToString());

                if(uerExistCheck == 1)
                {
                    var main = new Main();
                    main.Show();
                    this.Close();
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

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= Login_FormClosed;
            if (Application.OpenForms.Count == 0) Application.ExitThread();
            else if (Application.OpenForms.Count == 1)
            {
                if (Application.OpenForms[0].Name == "Login") Application.ExitThread();
            }
            else Application.OpenForms[0].FormClosed += Login_FormClosed;
        }
    }
}
