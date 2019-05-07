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
            MySQLCon mysql = new MySQLCon();                            //MySQL-Connection initialisieren

            //MessageBox.Show(outTable.Rows[0].RowState.ToString());
            InitializeComponent();
        }

        private void btn_beruf_ext_form_Click(object sender, EventArgs e)   //Button (BtnBeruf;ClickEvent)
        {
            FrmReviewBeruf fberuf = new FrmReviewBeruf();                   //Form FrmReviewBeruf laden und öffnen
            fberuf.ShowDialog(); // Shows Forms Review-Beruf
        }

        private void BtnFaecher_Click(object sender, EventArgs e)           //Button (BtnFaecher;ClickEvent)
        {
            FrmReviewFaecher ffaecher = new FrmReviewFaecher();             //Form FrmReviewFaecher laden und öffnen
            ffaecher.ShowDialog(); // Shows Forms Review-Fächer

        }

        private void BtnFirma_Click(object sender, EventArgs e)             //Button (BtnFirma;ClickEvent)
        {
            FrmReviewFirma ffirma = new FrmReviewFirma();                   //Form FrmReviewFirma laden und öffnen
            ffirma.ShowDialog(); // Shows Forms Review-Firma
        }

        private void BtnKlasse_Click(object sender, EventArgs e)            //Button (BtnKlasse;ClickEvent)
        {
            FrmReviewKlasse fklasse = new FrmReviewKlasse();                //Form FrmReviewKlasse laden und öffnen
            fklasse.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)              //Button (BtnLehrling;ClickEvent)
        {
            FrmReviewLehrling flehrling = new FrmReviewLehrling();          //Form FrmReviewLehrling laden und öffnen
            flehrling.ShowDialog();
        }

        private void BtnLehrzeiten_Click(object sender, EventArgs e)        //Button (BtnLehrzeiten;ClickEvent)
        {
            FrmReviewLehrzeiten flehrzeiten = new FrmReviewLehrzeiten();    //Form FrmReviewLehrzeiten laden und öffnen
            flehrzeiten.ShowDialog();
        }

        private void BtnSemester_Click(object sender, EventArgs e)          //Button (BtnSemester;ClickEvent)
        {
            FrmReviewSemester fsemester = new FrmReviewSemester();          //Form FrmReviewSemester laden und öffnen
            fsemester.ShowDialog();
        }
    }
}
