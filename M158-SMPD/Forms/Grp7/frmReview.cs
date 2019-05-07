using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M158_SMPD.Forms
{
    public partial class FrmReview : Form
    {
        public FrmReview()
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

        private void CsvExport_Click(object sender, EventArgs e)
        {
            Button BtnSender = sender as Button;                            //Sender des Buttons definieren
            MySQLCon mysql = new MySQLCon();                                //MySQL Connection initialisieren
            SaveFileDialog saveCSVFile = new SaveFileDialog();              //Savedialog initialisieren
            DataTable dtblQuery;                                            //Datatable erstellen
            switch (BtnSender.Name)                                         //Switch-Case Funktion mit case nach Buttonnamen
            {
                case "BtnBerufCSV":
                    dtblQuery = mysql.getSQLStatement("SELECT * FROM tbl_beruf ORDER BY Be_Nr ASC");   //Daten der Query in Datatable
                    saveCSVFile.FileName = "Beruf.csv";                                                     // default Filename
                    break;

                case "BtnFaecherCSV":
                    dtblQuery = mysql.getSQLStatement("SELECT * FROM tbl_faecher ORDER BY Fae_Nr ASC");     //Daten der Query in Datatable
                    saveCSVFile.FileName = "Faecher.csv";                                                   // default Filename
                    break;

                case "BtnFirmaCSV":
                    dtblQuery = mysql.getSQLStatement("SELECT Fi_Nr, F_Name, Anrede, F_Vorname, F_Nachname, Ort, F_Strasse, F_Ansprechperson, F_Zusatz, F_Telefon, F_Fax FROM tbl_firma JOIN tbl_anrede on tbl_anrede.An_Nr = tbl_firma.An_Nr JOIN tbl_ort on tbl_ort.Or_Nr = tbl_firma.Or_Nr");        //Daten der Query in Datatable
                    saveCSVFile.FileName = "Firma.csv";                                                                                                                                                                                                                                                 // default Filename
                    break;

                case "BtnKlasseCSV":
                    dtblQuery = mysql.getSQLStatement("SELECT * FROM tbl_klasse ORDER BY Kl_Nr ASC");       //Daten der Query in Datatable
                    saveCSVFile.FileName = "Klasse.csv";                                                    // default Filename
                    break;

                case "BtnLehrlingCSV":
                    dtblQuery = mysql.getSQLStatement("SELECT * FROM tbl_lehrling ORDER BY Ll_Nr ASC");     //Daten der Query in Datatable
                    saveCSVFile.FileName = "Lehrling.csv";                                                  // default Filename
                    break;

                case "BtnLehrzeitenCSV":
                    dtblQuery = mysql.getSQLStatement("SELECT * FROM tbl_lehrzeiten ORDER BY Lj_Nr ASC");   //Daten der Query in Datatable
                    saveCSVFile.FileName = "Lehrzeiten.csv";                                                // default Filename
                    break;

                case "BtnSemesterCSV":
                    dtblQuery = mysql.getSQLStatement("SELECT * FROM tbl_semester ORDER BY Se_Nr ASC");     //Daten der Query in Datatable
                    saveCSVFile.FileName = "Semester.csv";                                                  //default Filename
                    break;

                default:
                    return;
            }
 
            saveCSVFile.Filter = "Comma Seperated Values (*.csv)|*.csv";                                    //Filter, damit nur als CSV-File abgespeichert werden kann                                 

            if (saveCSVFile.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveCSVFile.FileName;
                dtblQuery.ToCSV(fileName);                                                                  //Funktionsaufruf "ToCSV" -> Siehe CSVUtil.cs, Exportierung nach definiertem Pfad/Namen in Dialog
            }
        }
    }
}
