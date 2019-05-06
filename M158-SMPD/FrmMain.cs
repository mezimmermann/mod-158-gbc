using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using M158_SMPD.Forms.Grp1;

namespace M158_SMPD
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            // Adminberechtigung
            if (frmLogin.DtUserdetails.Rows[0][5].ToString() == "True")
            {
                //TsmiRegistration.Visible = true;
                //TsmiSeperator.Visible = true;
            }
        }

        private void TsmiRegistration_Click(object sender, EventArgs e)
        {
            frmUserRegister Registration = new frmUserRegister();
            Registration.Show();
        }
    }
}
