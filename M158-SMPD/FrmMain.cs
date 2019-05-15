using System;
using System.Windows.Forms;
using M158_SMPD.Forms;

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


        private void BtnReports_Click(object sender, EventArgs e)
        {
            Forms.Grp7.FrmReview frmReview = new Forms.Grp7.FrmReview
            {
                MdiParent = this
            };
            frmReview.Show();
        }

        private void BtnCreateUser_Click(object sender, EventArgs e)
        {
            Forms.Grp1.frmUserRegister frmuserreg = new Forms.Grp1.frmUserRegister
            {
                MdiParent = this
            };
            frmuserreg.Show();
        }

        private void BtnNotendaten_Click(object sender, EventArgs e)
        {
            Forms.Grp1.FrmNotendaten notendaten = new Forms.Grp1.FrmNotendaten
            {
                MdiParent = this
            };
            notendaten.Show();
        }

        private void BtnFaecherzuteilung_Click(object sender, EventArgs e)
        {
            Forms.frmFaecherzuteilung faecherzuteilung = new Forms.frmFaecherzuteilung
            {
                MdiParent = this
            };
            faecherzuteilung.Show();
        }

        private void BtnNotenperiode_Click(object sender, EventArgs e)
        {
            Forms.frmNotenperiode notenperiode = new Forms.frmNotenperiode
            {
                MdiParent = this
            };
            notenperiode.Show();
        }

        private void BtnSSL_Click(object sender, EventArgs e)
        {
            Forms.Grp3.frmStudMgmt frmStudMgmt = new Forms.Grp3.frmStudMgmt
            {
                MdiParent = this
            };
            frmStudMgmt.Show();
        }

        private void BtnFirmendaten_Click(object sender, EventArgs e)
        {
            Forms.Grp3.frmCompData frmCompData = new Forms.Grp3.frmCompData
            {
                MdiParent = this
            };
            frmCompData.Show();
        }

        private void BtnSchnellerfassung_Click(object sender, EventArgs e)
        {
            Forms.Grp4.frmSchnellerfassung frmSchnellerfassung = new Forms.Grp4.frmSchnellerfassung
            {
                MdiParent = this
            };
            frmSchnellerfassung.Show();
        }

        private void BtnAnrede_Click(object sender, EventArgs e)
        {
            Forms.Grp5.frmanrede frmAnrede = new Forms.Grp5.frmanrede
            {
                MdiParent = this
            };
            frmAnrede.Show();
        }

        private void BtnFaecher_Click(object sender, EventArgs e)
        {
            Forms.Grp5.frmfach frmFach = new Forms.Grp5.frmfach
            {
                MdiParent = this
            };
            frmFach.Show();
        }

        private void BtnOrte_Click(object sender, EventArgs e)
        {
            Forms.Grp5.frmort frmOrte = new Forms.Grp5.frmort
            {
                MdiParent = this
            };
            frmOrte.Show();
        }

        private void BtnKlassen_Click(object sender, EventArgs e)
        {
            Forms.Grp6.frmKlassen frmKlassen = new Forms.Grp6.frmKlassen
            {
                MdiParent = this
            };
            frmKlassen.Show();
        }

        private void BtnBerufe_Click(object sender, EventArgs e)
        {
            Forms.Grp6.frmBerufe frmBerufe = new Forms.Grp6.frmBerufe
            {
                MdiParent = this
            };
            frmBerufe.Show();
        }

        private void BtnNotenlisten_Click(object sender, EventArgs e)
        {
            Forms.Grp4.frmNotenlisten frmNotenlisten = new Forms.Grp4.frmNotenlisten
            {
                MdiParent = this
            };
            frmNotenlisten.Show();
        }
    }
}
