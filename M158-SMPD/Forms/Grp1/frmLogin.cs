using M158_SMPD.Forms.Grp1;
using System;
using System.Data;
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
                
                StrPasswordDB = MysqlconUser.GetSqlStatement("SELECT Passwort FROM user WHERE Benutzername=\"" + StrUsername + "\"").Rows[0][0].ToString();
                
                // Überprüfung der Passwörter (eingegebenes und DB-PW)
                if (Cryption.checkPwd(StrPasswordDB, TbxPassword.Text.ToString()) == true)
                {
                    LoginSuccessful(StrUsername);
                }
                else
                {
                    MessageBox.Show("Benutzername oder Passwort inkorrekt.","Login",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception ex)
            {
                //MessageBox.Show("Benutzername oder Passwort inkorrekt.");
                MessageBox.Show(ex.Message);
            }

        }
        private void LoginSuccessful(string StrUsername)
        {
            try
            {
                MySQLCon MysqlconUser = new MySQLCon();

                //liest Berechtigungen des eingeloggten Users aus
                DtUserdetails = MysqlconUser.GetSqlStatement("SELECT * FROM user JOIN benutzergruppen on user.IdBenutzergruppen=benutzergruppen.idbenutzergruppen WHERE Benutzername=\"" + StrUsername + "\"");

                this.Close();
            }
            catch
            {
                MessageBox.Show("Benutzername oder Passwort inkorrekt.");
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
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            FrmLoading frmLoading = new FrmLoading();
            frmLoading.Show();
            Wait(1400);
            frmLoading.Close();
            TbxUsername.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        }

        private void TbxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Int32)Keys.Enter)
            {
                BtnLogin.PerformClick();
            }
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            FrmDBSettings dbset = new FrmDBSettings();
            dbset.Show();
        }

        private void frmLogin_Shown(object sender, EventArgs e)
        {
            TbxPassword.Focus();
        }
    }
}
