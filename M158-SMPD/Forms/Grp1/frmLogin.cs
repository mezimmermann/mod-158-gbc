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
        public static bool BoolExit = false;

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string StrPasswordDB;
            string StrUsername = TbxUsername.Text.ToString();

            try
            {
                MySQLCon MysqlconUser = new MySQLCon();
                
                StrPasswordDB = MysqlconUser.getSQLStatement("SELECT Passwort FROM user WHERE Benutzername=\"" + StrUsername + "\"").Rows[0][0].ToString();
                
                // Überprüfung der Passwörter (eingegebenes und DB-PW)
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
                //liest Berechtigungen des eingeloggten Users aus
                DtUserdetails = MysqlconUser.getSQLStatement("SELECT * FROM user JOIN benutzergruppen on user.IdBenutzergruppen=benutzergruppen.idbenutzergruppen WHERE Benutzername=\"" + StrUsername + "\"");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        // Login Schliessen und true schliessen für Main-Form
        private void BtnClose_Click(object sender, EventArgs e)
        {
            BoolExit = true;
            Application.Exit();
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
