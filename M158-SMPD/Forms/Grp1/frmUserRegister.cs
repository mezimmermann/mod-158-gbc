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
    public partial class frmUserRegister : Form
    {
        public frmUserRegister()
        {
            InitializeComponent();
        }

        private void frmUserRegister_Load(object sender, EventArgs e)
        {

        }

        private void TbxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            bool BoolAdm;
            string StrFirstname = TbxFirstname.Text;
            string StrSurname = TbxSurname.Text;
            string StrUsername = TbxUsername.Text;
            string StrPassword = TbxPassword.Text;
            string StrConfirmPassword = TbxConfirmPassword.Text;
            string StrUserGroup = CmxUserGroups.Text;
            
            if (CbxAdm.Checked == true)
            {
                BoolAdm = true;
            }
            else
            {
                BoolAdm = false;
            }
            if ((StrFirstname == "") && (StrSurname == "") && (StrUsername == "") && (StrPassword == "") && (StrConfirmPassword == "") && (StrUserGroup == ""))
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
                    LblComments.Text = "Die Eingaben sind korrekt";
                    LblComments.ForeColor = Color.Green;
                    LblComments.Visible = true;
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

        private void BtnBreak_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
