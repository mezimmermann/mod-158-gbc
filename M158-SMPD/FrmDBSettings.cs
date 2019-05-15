using System;
using System.Windows.Forms;

namespace M158_SMPD
{
    public partial class FrmDBSettings : Form
    {
        public FrmDBSettings()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DBName = TbxDBName.Text;
            Properties.Settings.Default.DBServer = TbxDBServer.Text;
            Properties.Settings.Default.DBUser = TbxDBUser.Text;
            Properties.Settings.Default.DBPassword = TbxDBPass.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void FrmDBSettings_Load(object sender, EventArgs e)
        {
            TbxDBName.Text = Properties.Settings.Default.DBName;
            TbxDBUser.Text = Properties.Settings.Default.DBUser;
            TbxDBServer.Text = Properties.Settings.Default.DBServer;
            TbxDBPass.Text = Properties.Settings.Default.DBPassword;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
