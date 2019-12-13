namespace sangbong_financial_management.SFM.Main
{
    partial class DatabaseSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_connect_setting = new System.Windows.Forms.GroupBox();
            this.mbtn_db_setting_cancel = new MetroFramework.Controls.MetroButton();
            this.mbtn_db_setting_ok = new MetroFramework.Controls.MetroButton();
            this.mbtn_db_setting_test = new MetroFramework.Controls.MetroButton();
            this.tb_db_setting_db_name = new System.Windows.Forms.TextBox();
            this.tb_db_setting_user_pw = new System.Windows.Forms.TextBox();
            this.tb_db_setting_user_id = new System.Windows.Forms.TextBox();
            this.tb_db_setting_server_name = new System.Windows.Forms.TextBox();
            this.lb_db_setting_user_pw = new System.Windows.Forms.Label();
            this.lb_db_setting_user_id = new System.Windows.Forms.Label();
            this.lb_db_setting_db_name = new System.Windows.Forms.Label();
            this.lb_db_setting_server_name = new System.Windows.Forms.Label();
            this.mp_db_setting_main = new MetroFramework.Controls.MetroPanel();
            this.gb_connect_setting.SuspendLayout();
            this.mp_db_setting_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_connect_setting
            // 
            this.gb_connect_setting.Controls.Add(this.mbtn_db_setting_cancel);
            this.gb_connect_setting.Controls.Add(this.mbtn_db_setting_ok);
            this.gb_connect_setting.Controls.Add(this.mbtn_db_setting_test);
            this.gb_connect_setting.Controls.Add(this.tb_db_setting_db_name);
            this.gb_connect_setting.Controls.Add(this.tb_db_setting_user_pw);
            this.gb_connect_setting.Controls.Add(this.tb_db_setting_user_id);
            this.gb_connect_setting.Controls.Add(this.tb_db_setting_server_name);
            this.gb_connect_setting.Controls.Add(this.lb_db_setting_user_pw);
            this.gb_connect_setting.Controls.Add(this.lb_db_setting_user_id);
            this.gb_connect_setting.Controls.Add(this.lb_db_setting_db_name);
            this.gb_connect_setting.Controls.Add(this.lb_db_setting_server_name);
            this.gb_connect_setting.Location = new System.Drawing.Point(23, 40);
            this.gb_connect_setting.Name = "gb_connect_setting";
            this.gb_connect_setting.Size = new System.Drawing.Size(460, 315);
            this.gb_connect_setting.TabIndex = 0;
            this.gb_connect_setting.TabStop = false;
            this.gb_connect_setting.Text = "접속 설정";
            // 
            // mbtn_db_setting_cancel
            // 
            this.mbtn_db_setting_cancel.Location = new System.Drawing.Point(353, 245);
            this.mbtn_db_setting_cancel.Name = "mbtn_db_setting_cancel";
            this.mbtn_db_setting_cancel.Size = new System.Drawing.Size(71, 38);
            this.mbtn_db_setting_cancel.TabIndex = 10;
            this.mbtn_db_setting_cancel.Text = "닫기";
            this.mbtn_db_setting_cancel.UseSelectable = true;
            this.mbtn_db_setting_cancel.Click += new System.EventHandler(this.mbtn_db_setting_cancel_Click);
            // 
            // mbtn_db_setting_ok
            // 
            this.mbtn_db_setting_ok.Location = new System.Drawing.Point(271, 245);
            this.mbtn_db_setting_ok.Name = "mbtn_db_setting_ok";
            this.mbtn_db_setting_ok.Size = new System.Drawing.Size(71, 38);
            this.mbtn_db_setting_ok.TabIndex = 9;
            this.mbtn_db_setting_ok.Text = "확인";
            this.mbtn_db_setting_ok.UseSelectable = true;
            this.mbtn_db_setting_ok.Click += new System.EventHandler(this.mbtn_db_setting_ok_Click);
            // 
            // mbtn_db_setting_test
            // 
            this.mbtn_db_setting_test.Location = new System.Drawing.Point(35, 245);
            this.mbtn_db_setting_test.Name = "mbtn_db_setting_test";
            this.mbtn_db_setting_test.Size = new System.Drawing.Size(126, 38);
            this.mbtn_db_setting_test.TabIndex = 8;
            this.mbtn_db_setting_test.Text = "연결 테스트";
            this.mbtn_db_setting_test.UseSelectable = true;
            this.mbtn_db_setting_test.Click += new System.EventHandler(this.mbtn_db_setting_test_Click);
            // 
            // tb_db_setting_db_name
            // 
            this.tb_db_setting_db_name.Location = new System.Drawing.Point(185, 95);
            this.tb_db_setting_db_name.Name = "tb_db_setting_db_name";
            this.tb_db_setting_db_name.Size = new System.Drawing.Size(239, 25);
            this.tb_db_setting_db_name.TabIndex = 7;
            // 
            // tb_db_setting_user_pw
            // 
            this.tb_db_setting_user_pw.Location = new System.Drawing.Point(185, 164);
            this.tb_db_setting_user_pw.Name = "tb_db_setting_user_pw";
            this.tb_db_setting_user_pw.PasswordChar = '*';
            this.tb_db_setting_user_pw.Size = new System.Drawing.Size(239, 25);
            this.tb_db_setting_user_pw.TabIndex = 6;
            // 
            // tb_db_setting_user_id
            // 
            this.tb_db_setting_user_id.Location = new System.Drawing.Point(185, 129);
            this.tb_db_setting_user_id.Name = "tb_db_setting_user_id";
            this.tb_db_setting_user_id.Size = new System.Drawing.Size(239, 25);
            this.tb_db_setting_user_id.TabIndex = 5;
            // 
            // tb_db_setting_server_name
            // 
            this.tb_db_setting_server_name.Location = new System.Drawing.Point(185, 62);
            this.tb_db_setting_server_name.Name = "tb_db_setting_server_name";
            this.tb_db_setting_server_name.Size = new System.Drawing.Size(239, 25);
            this.tb_db_setting_server_name.TabIndex = 4;
            // 
            // lb_db_setting_user_pw
            // 
            this.lb_db_setting_user_pw.AutoSize = true;
            this.lb_db_setting_user_pw.Location = new System.Drawing.Point(98, 169);
            this.lb_db_setting_user_pw.Name = "lb_db_setting_user_pw";
            this.lb_db_setting_user_pw.Size = new System.Drawing.Size(81, 15);
            this.lb_db_setting_user_pw.TabIndex = 3;
            this.lb_db_setting_user_pw.Text = "유저 PW : ";
            // 
            // lb_db_setting_user_id
            // 
            this.lb_db_setting_user_id.AutoSize = true;
            this.lb_db_setting_user_id.Location = new System.Drawing.Point(109, 134);
            this.lb_db_setting_user_id.Name = "lb_db_setting_user_id";
            this.lb_db_setting_user_id.Size = new System.Drawing.Size(70, 15);
            this.lb_db_setting_user_id.TabIndex = 2;
            this.lb_db_setting_user_id.Text = "유저 ID : ";
            // 
            // lb_db_setting_db_name
            // 
            this.lb_db_setting_db_name.AutoSize = true;
            this.lb_db_setting_db_name.Location = new System.Drawing.Point(32, 99);
            this.lb_db_setting_db_name.Name = "lb_db_setting_db_name";
            this.lb_db_setting_db_name.Size = new System.Drawing.Size(147, 15);
            this.lb_db_setting_db_name.TabIndex = 1;
            this.lb_db_setting_db_name.Text = "데이터베이스 이름 : ";
            // 
            // lb_db_setting_server_name
            // 
            this.lb_db_setting_server_name.AutoSize = true;
            this.lb_db_setting_server_name.Location = new System.Drawing.Point(92, 65);
            this.lb_db_setting_server_name.Name = "lb_db_setting_server_name";
            this.lb_db_setting_server_name.Size = new System.Drawing.Size(87, 15);
            this.lb_db_setting_server_name.TabIndex = 0;
            this.lb_db_setting_server_name.Text = "서버 이름 : ";
            // 
            // mp_db_setting_main
            // 
            this.mp_db_setting_main.Controls.Add(this.gb_connect_setting);
            this.mp_db_setting_main.HorizontalScrollbarBarColor = true;
            this.mp_db_setting_main.HorizontalScrollbarHighlightOnWheel = false;
            this.mp_db_setting_main.HorizontalScrollbarSize = 10;
            this.mp_db_setting_main.Location = new System.Drawing.Point(2, 74);
            this.mp_db_setting_main.Name = "mp_db_setting_main";
            this.mp_db_setting_main.Size = new System.Drawing.Size(503, 375);
            this.mp_db_setting_main.TabIndex = 1;
            this.mp_db_setting_main.VerticalScrollbarBarColor = true;
            this.mp_db_setting_main.VerticalScrollbarHighlightOnWheel = false;
            this.mp_db_setting_main.VerticalScrollbarSize = 10;
            // 
            // DatabaseSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 450);
            this.Controls.Add(this.mp_db_setting_main);
            this.Name = "DatabaseSetting";
            this.Text = "DatabaseSetting";
            this.Load += new System.EventHandler(this.DatabaseSetting_Load);
            this.gb_connect_setting.ResumeLayout(false);
            this.gb_connect_setting.PerformLayout();
            this.mp_db_setting_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_connect_setting;
        private System.Windows.Forms.Label lb_db_setting_user_pw;
        private System.Windows.Forms.Label lb_db_setting_user_id;
        private System.Windows.Forms.Label lb_db_setting_db_name;
        private System.Windows.Forms.Label lb_db_setting_server_name;
        private System.Windows.Forms.TextBox tb_db_setting_db_name;
        private System.Windows.Forms.TextBox tb_db_setting_user_pw;
        private System.Windows.Forms.TextBox tb_db_setting_user_id;
        private System.Windows.Forms.TextBox tb_db_setting_server_name;
        private MetroFramework.Controls.MetroButton mbtn_db_setting_cancel;
        private MetroFramework.Controls.MetroButton mbtn_db_setting_ok;
        private MetroFramework.Controls.MetroButton mbtn_db_setting_test;
        private MetroFramework.Controls.MetroPanel mp_db_setting_main;
    }
}