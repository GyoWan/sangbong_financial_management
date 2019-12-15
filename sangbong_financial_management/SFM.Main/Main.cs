using System.Windows.Forms;

namespace sangbong_financial_management.SFM.Main
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Tsbn_main_exit_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
