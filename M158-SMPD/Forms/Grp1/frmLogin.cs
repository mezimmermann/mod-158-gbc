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

        public static DataTable DtUserdetails = new DataTable();

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string StrPasswordDB;
            string StrUsername = TbxUsername.Text.ToString();

            try
            {
                MySQLCon MysqlconUser = new MySQLCon();

                //string password = Cryption.encrypt("test");
                StrPasswordDB = MysqlconUser.getSQLStatement("SELECT Passwort FROM user WHERE Benutzername=\"" + StrUsername + "\"").Rows[0][0].ToString();

                if (Cryption.checkPwd(StrPasswordDB, TbxPassword.Text.ToString()) == true)
                {
                    LoginSuccessful(StrUsername);
                }
                else
                {
                    MessageBox.Show("Benutzername oder Passwort inkorrekt.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
        private void LoginSuccessful(string StrUsername)
        {
            try
            {
                MySQLCon MysqlconUser = new MySQLCon();

                //string password = Cryption.encrypt("test");
                DtUserdetails = MysqlconUser.getSQLStatement("SELECT * FROM user JOIN benutzergruppen on user.IdBenutzergruppen=benutzergruppen.idbenutzergruppen WHERE Benutzername=\"" + StrUsername + "\"");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
