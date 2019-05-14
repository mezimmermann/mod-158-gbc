using M158_SMPD.Forms.Grp1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M158_SMPD
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string StrPasswordDB;
            string StrUsername = TbxUsername.Text.ToString();
            MySQLCon MysqlconUser = new MySQLCon();

            //string password = Cryption.encrypt("test");
            StrPasswordDB = MysqlconUser.getSQLStatement("SELECT Passwort FROM user WHERE Benutzername=\""+ StrUsername + "\"").Rows[0][0].ToString();

            if (Cryption.checkPwd(StrPasswordDB, TbxPassword.Text.ToString()) == true)
            {
                MessageBox.Show("Login Successful");
            }
            else
            {
                MessageBox.Show("Login Denied");
            }

        }

        public void Wait(int ms)
        {
            DateTime start = DateTime.Now;
            while ((DateTime.Now - start).TotalMilliseconds < ms)
                Application.DoEvents();

        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            FrmLoading frmLoading = new FrmLoading();
            frmLoading.Show();
            Wait(3000);
            frmLoading.Close();

        }
    }
}
