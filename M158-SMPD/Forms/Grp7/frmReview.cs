using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M158_SMPD.Forms
{
    public partial class frmReview : Form
    {
        public frmReview()
        {
            MySQLCon mysql = new MySQLCon();
            
            
            

            //MessageBox.Show(outTable.Rows[0].RowState.ToString());
            InitializeComponent();
        }

        private void btn_beruf_ext_form_Click(object sender, EventArgs e)
        {
            FrmReviewBeruf fberuf = new FrmReviewBeruf();
            fberuf.ShowDialog(); // Shows Forms Review-Beruf
        }

        private void BtnFaecher_Click(object sender, EventArgs e)
        {
            FrmReviewFaecher ffaecher = new FrmReviewFaecher();
            ffaecher.ShowDialog(); // Shows Forms Review-Fächer

        }

        private void BtnFirma_Click(object sender, EventArgs e)
        {
            FrmReviewFirma ffirma = new FrmReviewFirma();
            ffirma.ShowDialog(); // Shows Forms Review-Firma
        }

        private void BtnKlasse_Click(object sender, EventArgs e)
        {
            FrmReviewKlasse fklasse = new FrmReviewKlasse();
            fklasse.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmReviewLehrling flehrling = new FrmReviewLehrling();
            flehrling.ShowDialog();
        }

        private void BtnLehrzeiten_Click(object sender, EventArgs e)
        {
            FrmReviewLehrzeiten flehrzeiten = new FrmReviewLehrzeiten();
            flehrzeiten.ShowDialog();
        }

        private void BtnSemester_Click(object sender, EventArgs e)
        {
            FrmReviewSemester fsemester = new FrmReviewSemester();
            fsemester.ShowDialog();
        }
    }
}
