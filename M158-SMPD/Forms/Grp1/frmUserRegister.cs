using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M158_SMPD.Forms.Grp1
{
    public partial class FrmUserRegister : Form
    {
        private static DataTable DtGroups = new DataTable();

        public FrmUserRegister()
        {
            InitializeComponent();

            MySQLCon MySQLConBenutzergruppen = new MySQLCon();
            DtGroups = MySQLConBenutzergruppen.getSQLStatement("SELECT * FROM benutzergruppen");
            foreach (DataRow DtrBenutzergruppen in DtGroups.Rows)
            {
                CmxUserGroups.Items.Add(DtrBenutzergruppen[1].ToString());
            }
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            string StrBooladm = "0";
            string StrFirstname = TbxFirstname.Text;
            string StrSurname = TbxSurname.Text;
            string StrUsername = TbxUsername.Text;
            string StrPassword = TbxPassword.Text;
            string StrConfirmPassword = TbxConfirmPassword.Text;
            string StrUserGroup = CmxUserGroups.Text;
            string StrPasswordhash;
            string StrUsergroupid = "";

            try
            {
                if (CbxAdm.Checked == true)
                {
                    StrBooladm = "1";
                }
                else
                {
                    StrBooladm = "0";
                }

                if ((StrFirstname == "") || (StrSurname == "") || (StrUsername == "") || (StrPassword == "") || (StrConfirmPassword == "") || (StrUserGroup == ""))
                {
                    //Ein Datensatz fehlt
                    LblComments.Text = "Ein Datensatz fehlt!";
                    LblComments.ForeColor = Color.Red;
                    LblComments.Visible = true;
                }
                else
                {
                    if (StrPassword == StrConfirmPassword)
                    {
                        // Überprüfung nach Sonderzeichen
                        string StrspecialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
                        bool BoolSonderzeichen = false;
                        foreach (var item in StrspecialChar)
                        {
                            if ((StrFirstname.Contains(item) == true) || (StrUsername.Contains(item) == true) || (StrSurname.Contains(item) == true))
                            {
                                BoolSonderzeichen = true;
                            }
                        }
                        if (BoolSonderzeichen == false)
                        {
                            StrPasswordhash = Cryption.encrypt(StrPassword);
                            foreach (DataRow DtrBenutzergruppen in DtGroups.Rows)
                            {
                                if (DtrBenutzergruppen[1].ToString() == StrUserGroup)
                                {
                                    StrUsergroupid = DtrBenutzergruppen[0].ToString();
                                }
                            }
                            string StrSqlCreateUser = "INSERT INTO `user` (`Name`, `Vorname`, `Benutzername`, `Passwort`, `Admin`, `idBenutzergruppen`) VALUES ('" + StrSurname + "', '" + StrFirstname + "', '" + StrUsername + "', '" + StrPasswordhash + "', '" + StrBooladm + "', '" + StrUsergroupid + "');";
                            MySQLCon MySQLConBenutzergruppen = new MySQLCon();
                            MySQLConBenutzergruppen.setSQLStatement(StrSqlCreateUser);
                            LblComments.Text = "Der Benutzer wurde hinzugefügt";
                            LblComments.ForeColor = Color.Green;
                            LblComments.Visible = true;
                        }
                        else
                        {
                            //Passwörter nicht identisch
                            LblComments.Text = " Bitte Benutzen Sie in den Feldern Vorname, \n\r Nachname und Benutzername keine Sonderzeichen.";
                            LblComments.ForeColor = Color.Red;
                            LblComments.Visible = true;
                        }
                    }
                    else
                    {
                        //Passwörter nicht identisch
                        LblComments.Text = "Die Passwörter sind nicht identisch!";
                        LblComments.ForeColor = Color.Red;
                        LblComments.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BtnBreak_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
