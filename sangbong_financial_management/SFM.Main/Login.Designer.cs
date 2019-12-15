using sangbong_financial_management.SFM.Common.GlobalSetting;

namespace sangbong_financial_management.SFM.Main
{
    partial class Login
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
            this.mbtn_login = new MetroFramework.Controls.MetroButton();
            this.tb_login_id = new System.Windows.Forms.TextBox();
            this.tb_login_pw = new System.Windows.Forms.TextBox();
            this.lb_login_id = new System.Windows.Forms.Label();
            this.lb_login_pw = new System.Windows.Forms.Label();
            this.mtbn_exit = new MetroFramework.Controls.MetroButton();
            this.mp_login_right = new MetroFramework.Controls.MetroPanel();
            this.mp__login_right_img = new MetroFramework.Controls.MetroPanel();
            this.mbtn_login_set_db = new MetroFramework.Controls.MetroButton();
            this.mp_login_left_img = new MetroFramework.Controls.MetroPanel();
            this.mp_login_right.SuspendLayout();
            this.mp__login_right_img.SuspendLayout();
            this.SuspendLayout();
            // 
            // mbtn_login
            // 
            this.mbtn_login.Location = new System.Drawing.Point(145, 276);
            this.mbtn_login.Name = "mbtn_login";
            this.mbtn_login.Size = new System.Drawing.Size(109, 39);
            this.mbtn_login.TabIndex = 0;
            this.mbtn_login.Text = "로그인";
            this.mbtn_login.UseSelectable = true;
            this.mbtn_login.Click += new System.EventHandler(this.Mbtn_login_Click);
            // 
            // tb_login_id
            // 
            this.tb_login_id.Location = new System.Drawing.Point(37, 177);
            this.tb_login_id.Name = "tb_login_id";
            this.tb_login_id.Size = new System.Drawing.Size(217, 25);
            this.tb_login_id.TabIndex = 1;
            // 
            // tb_login_pw
            // 
            this.tb_login_pw.Location = new System.Drawing.Point(37, 236);
            this.tb_login_pw.Name = "tb_login_pw";
            this.tb_login_pw.PasswordChar = '*';
            this.tb_login_pw.Size = new System.Drawing.Size(217, 25);
            this.tb_login_pw.TabIndex = 2;
            this.tb_login_pw.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Tb_login_pw_KeyUp);
            // 
            // lb_login_id
            // 
            this.lb_login_id.AutoSize = true;
            this.lb_login_id.Location = new System.Drawing.Point(34, 159);
            this.lb_login_id.Name = "lb_login_id";
            this.lb_login_id.Size = new System.Drawing.Size(35, 15);
            this.lb_login_id.TabIndex = 3;
            this.lb_login_id.Text = "ID : ";
            // 
            // lb_login_pw
            // 
            this.lb_login_pw.AutoSize = true;
            this.lb_login_pw.Location = new System.Drawing.Point(34, 218);
            this.lb_login_pw.Name = "lb_login_pw";
            this.lb_login_pw.Size = new System.Drawing.Size(46, 15);
            this.lb_login_pw.TabIndex = 4;
            this.lb_login_pw.Text = "PW : ";
            // 
            // mtbn_exit
            // 
            this.mtbn_exit.Location = new System.Drawing.Point(37, 391);
            this.mtbn_exit.Name = "mtbn_exit";
            this.mtbn_exit.Size = new System.Drawing.Size(217, 39);
            this.mtbn_exit.TabIndex = 5;
            this.mtbn_exit.Text = "종료";
            this.mtbn_exit.UseSelectable = true;
            this.mtbn_exit.Click += new System.EventHandler(this.Mtbn_exit_Click);
            // 
            // mp_login_right
            // 
            this.mp_login_right.Controls.Add(this.mp__login_right_img);
            this.mp_login_right.Controls.Add(this.mbtn_login);
            this.mp_login_right.Controls.Add(this.tb_login_id);
            this.mp_login_right.Controls.Add(this.tb_login_pw);
            this.mp_login_right.Controls.Add(this.lb_login_id);
            this.mp_login_right.Controls.Add(this.lb_login_pw);
            this.mp_login_right.Controls.Add(this.mtbn_exit);
            this.mp_login_right.HorizontalScrollbarBarColor = true;
            this.mp_login_right.HorizontalScrollbarHighlightOnWheel = false;
            this.mp_login_right.HorizontalScrollbarSize = 10;
            this.mp_login_right.Location = new System.Drawing.Point(511, 76);
            this.mp_login_right.Name = "mp_login_right";
            this.mp_login_right.Size = new System.Drawing.Size(289, 443);
            this.mp_login_right.TabIndex = 6;
            this.mp_login_right.VerticalScrollbarBarColor = true;
            this.mp_login_right.VerticalScrollbarHighlightOnWheel = false;
            this.mp_login_right.VerticalScrollbarSize = 10;
            // 
            // mp__login_right_img
            // 
            this.mp__login_right_img.Controls.Add(this.mbtn_login_set_db);
            this.mp__login_right_img.HorizontalScrollbarBarColor = true;
            this.mp__login_right_img.HorizontalScrollbarHighlightOnWheel = false;
            this.mp__login_right_img.HorizontalScrollbarSize = 10;
            this.mp__login_right_img.Location = new System.Drawing.Point(0, 0);
            this.mp__login_right_img.Name = "mp__login_right_img";
            this.mp__login_right_img.Size = new System.Drawing.Size(289, 121);
            this.mp__login_right_img.TabIndex = 7;
            this.mp__login_right_img.VerticalScrollbarBarColor = true;
            this.mp__login_right_img.VerticalScrollbarHighlightOnWheel = false;
            this.mp__login_right_img.VerticalScrollbarSize = 10;
            // 
            // mbtn_login_set_db
            // 
            this.mbtn_login_set_db.Location = new System.Drawing.Point(110, 77);
            this.mbtn_login_set_db.Name = "mbtn_login_set_db";
            this.mbtn_login_set_db.Size = new System.Drawing.Size(144, 39);
            this.mbtn_login_set_db.TabIndex = 2;
            this.mbtn_login_set_db.Text = "DB Setting";
            this.mbtn_login_set_db.UseSelectable = true;
            this.mbtn_login_set_db.Click += new System.EventHandler(this.Mbtn_login_set_db_Click);
            // 
            // mp_login_left_img
            // 
            this.mp_login_left_img.HorizontalScrollbarBarColor = true;
            this.mp_login_left_img.HorizontalScrollbarHighlightOnWheel = false;
            this.mp_login_left_img.HorizontalScrollbarSize = 10;
            this.mp_login_left_img.Location = new System.Drawing.Point(0, 76);
            this.mp_login_left_img.Name = "mp_login_left_img";
            this.mp_login_left_img.Size = new System.Drawing.Size(505, 443);
            this.mp_login_left_img.TabIndex = 7;
            this.mp_login_left_img.VerticalScrollbarBarColor = true;
            this.mp_login_left_img.VerticalScrollbarHighlightOnWheel = false;
            this.mp_login_left_img.VerticalScrollbarSize = 10;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.mp_login_left_img);
            this.Controls.Add(this.mp_login_right);
            this.Name = "Login";
            this.Text = "SangBong 재정관리 프로그램";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.mp_login_right.ResumeLayout(false);
            this.mp_login_right.PerformLayout();
            this.mp__login_right_img.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton mbtn_login;
        private System.Windows.Forms.TextBox tb_login_id;
        private System.Windows.Forms.TextBox tb_login_pw;
        private System.Windows.Forms.Label lb_login_id;
        private System.Windows.Forms.Label lb_login_pw;
        private MetroFramework.Controls.MetroButton mtbn_exit;
        private MetroFramework.Controls.MetroPanel mp_login_right;
        private MetroFramework.Controls.MetroPanel mp__login_right_img;
        private MetroFramework.Controls.MetroPanel mp_login_left_img;
        private MetroFramework.Controls.MetroButton mbtn_login_set_db;
    }
}