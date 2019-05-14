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
            InitializeComponent();
            // Adminberechtigung
            if ((frmLogin.BoolExit == false) && (frmLogin.DtUserdetails.Rows[0][5].ToString() == "True"))
            {
                BtnCreateUser.Enabled = true;
            }
        }

        private void TsmiRegistration_Click(object sender, EventArgs e)
        {
            frmUserRegister Registration = new frmUserRegister();
            Registration.Show();
        }

        private void TsmiNotendaten_Click(object sender, EventArgs e)
        {
            FrmNotendaten Notendaten = new FrmNotendaten();
            Notendaten.Show();
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            Forms.FrmReview frmReview = new Forms.FrmReview();
            frmReview.MdiParent = this;
            frmReview.Show();
        }

        private void BtnCreateUser_Click(object sender, EventArgs e)
        {
            frmUserRegister frmuserreg = new frmUserRegister();
            frmuserreg.MdiParent = this;
            frmuserreg.Show();
        }
    }
}
