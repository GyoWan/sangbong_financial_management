﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace sangbong_financial_management.SFM.Main
{
    public partial class mf_login : MetroForm
    {
        public mf_login()
        {
            InitializeComponent();


        }

        private void Mtbn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Mbtn_login_set_db_Click(object sender, EventArgs e)
        {

        }
    }
}
