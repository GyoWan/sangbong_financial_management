using sangbong_financial_management.SFM.Common.GlobalSetting;

namespace sangbong_financial_management.SFM.Main
{
    partial class Main
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbn_main_search = new System.Windows.Forms.ToolStripButton();
            this.tsbn_main_add = new System.Windows.Forms.ToolStripButton();
            this.tsbn_main_save = new System.Windows.Forms.ToolStripButton();
            this.tsbn_main_delete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbn_main_exit = new System.Windows.Forms.ToolStripButton();
            this.tsbn_main_logout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ss_main = new System.Windows.Forms.StatusStrip();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(70, 70);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbn_main_search,
            this.tsbn_main_add,
            this.tsbn_main_save,
            this.tsbn_main_delete,
            this.toolStripSeparator1,
            this.tsbn_main_exit,
            this.tsbn_main_logout,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1400, 77);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbn_main_search
            // 
            this.tsbn_main_search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbn_main_search.Image = global::sangbong_financial_management.Properties.Resources.toolimg_serch;
            this.tsbn_main_search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbn_main_search.Name = "tsbn_main_search";
            this.tsbn_main_search.Size = new System.Drawing.Size(74, 74);
            this.tsbn_main_search.Text = "toolStripButton1";
            // 
            // tsbn_main_add
            // 
            this.tsbn_main_add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbn_main_add.Image = global::sangbong_financial_management.Properties.Resources.toolimg_add;
            this.tsbn_main_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbn_main_add.Name = "tsbn_main_add";
            this.tsbn_main_add.Size = new System.Drawing.Size(74, 74);
            this.tsbn_main_add.Text = "toolStripButton2";
            // 
            // tsbn_main_save
            // 
            this.tsbn_main_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbn_main_save.Image = global::sangbong_financial_management.Properties.Resources.toolimg_save;
            this.tsbn_main_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbn_main_save.Name = "tsbn_main_save";
            this.tsbn_main_save.Size = new System.Drawing.Size(74, 74);
            this.tsbn_main_save.Text = "toolStripButton3";
            // 
            // tsbn_main_delete
            // 
            this.tsbn_main_delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbn_main_delete.Image = global::sangbong_financial_management.Properties.Resources.toolimg_delete;
            this.tsbn_main_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbn_main_delete.Name = "tsbn_main_delete";
            this.tsbn_main_delete.Size = new System.Drawing.Size(74, 74);
            this.tsbn_main_delete.Text = "toolStripButton4";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 77);
            // 
            // tsbn_main_exit
            // 
            this.tsbn_main_exit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbn_main_exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbn_main_exit.Image = global::sangbong_financial_management.Properties.Resources.toolimg_exit;
            this.tsbn_main_exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbn_main_exit.Name = "tsbn_main_exit";
            this.tsbn_main_exit.Size = new System.Drawing.Size(74, 74);
            this.tsbn_main_exit.Text = "toolStripButton5";
            this.tsbn_main_exit.Click += new System.EventHandler(this.Tsbn_main_exit_Click);
            // 
            // tsbn_main_logout
            // 
            this.tsbn_main_logout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbn_main_logout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbn_main_logout.Image = global::sangbong_financial_management.Properties.Resources.toolimg_logout;
            this.tsbn_main_logout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbn_main_logout.Name = "tsbn_main_logout";
            this.tsbn_main_logout.Size = new System.Drawing.Size(74, 74);
            this.tsbn_main_logout.Text = "toolStripButton6";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 77);
            // 
            // ss_main
            // 
            this.ss_main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ss_main.Location = new System.Drawing.Point(0, 795);
            this.ss_main.Name = "ss_main";
            this.ss_main.Size = new System.Drawing.Size(1400, 22);
            this.ss_main.TabIndex = 1;
            this.ss_main.Text = "statusStrip1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 817);
            this.Controls.Add(this.ss_main);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Main";
            this.Text = "SangBong_Financial_Management_Program";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbn_main_search;
        private System.Windows.Forms.ToolStripButton tsbn_main_add;
        private System.Windows.Forms.ToolStripButton tsbn_main_save;
        private System.Windows.Forms.ToolStripButton tsbn_main_delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbn_main_exit;
        private System.Windows.Forms.ToolStripButton tsbn_main_logout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.StatusStrip ss_main;
    }
}