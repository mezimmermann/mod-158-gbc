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
//using System.Web.UI.DataVisualization.Charting;
using System.Windows.Forms.DataVisualization.Charting;

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
                    dtblQuery = mysql.getSQLStatement("SELECT Kl_Nr, Klasse,  Beruf, Kürzel, tbl_klasse.Be_Nr FROM tbl_klasse JOIN tbl_beruf on tbl_beruf.Be_Nr = tbl_klasse.Be_Nr Order By tbl_klasse.Kl_Nr asc");       //Daten der Query in Datatable
                    saveCSVFile.FileName = "Klasse.csv";                                                    // default Filename
                    break;

                case "BtnLehrlingCSV":
                    dtblQuery = mysql.getSQLStatement("SELECT * FROM tbl_lehrling ORDER BY Ll_Nr ASC");     //Daten der Query in Datatable
                    saveCSVFile.FileName = "Lehrling.csv";                                                  // default Filename
                    break;

                case "BtnLehrzeitenCSV":
                    dtblQuery = mysql.getSQLStatement("SELECT tbl_lehrling.Lj_Nr, Lj_Bis, Ll_Nr, Name, Vorname FROM tbl_lehrzeiten JOIN tbl_lehrling on tbl_lehrling.Lj_Nr = tbl_lehrzeiten.Lj_Nr Order By tbl_lehrling.Lj_Nr asc");   //Daten der Query in Datatable
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

        private void FrmReview_Load(object sender, EventArgs e)
        {
            MySQLCon mysql = new MySQLCon();

            BarAuswertung();                                                                            //Funktionaufruf



        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        public void BarAuswertung()                                                                     //Function der Chart
        {
            MySQLCon mysql = new MySQLCon();                                                            // MySQL Connection initialisieren

            DataTable countberuf;                                                                       //Datatable für Count der Beruf-Datensätze
            DataTable countfaecher;                                                                     //Datatable für Count der Fächer-Datensätze
            DataTable countfirma;                                                                       //Datatable für Count der Firma-Datensätze
            DataTable countklasse;                                                                      //Datatable für Count der Klassen-Datensätze
            DataTable countlehrling;                                                                    //Datatable für Count der Lehrling-Datensätze
            DataTable countlehrzeiten;                                                                  //Datatable für Count der Lehrzeiten-Datensätze
            DataTable countsemester;                                                                    //Datatable für Count der Semester-Datensätze

            int berufcount;                                                                             // Int der Anzahl Datensäzue (Beruf)
            int faechercount;                                                                           // Int der Anzahl Datensäzue (Fächer)
            int firmacount;                                                                             // Int der Anzahl Datensäzue (Firma)
            int klassecount;                                                                            // Int der Anzahl Datensäzue (Klasse)
            int lehrlingcount;                                                                          // Int der Anzahl Datensäzue (Lehrling)
            int lehrzeitencount;                                                                        // Int der Anzahl Datensäzue (Lehrzeiten)
            int semestercount;                                                                          // Int der Anzahl Datensäzue (Semester)

            countberuf = mysql.getSQLStatement("SELECT COUNT(*) FROM tbl_beruf");                       // Count Query für Beruf
            countfaecher = mysql.getSQLStatement("SELECT COUNT(*) FROM tbl_faecher");                   // Count Query für Fächer
            countfirma = mysql.getSQLStatement("SELECT COUNT(*) FROM tbl_firma");                       // Count Query für Firma
            countklasse = mysql.getSQLStatement("SELECT COUNT(*) FROM tbl_klasse");                     // Count Query für Klasse
            countlehrling = mysql.getSQLStatement("SELECT COUNT(*) FROM tbl_lehrling");                 // Count Query für Lehrling
            countlehrzeiten = mysql.getSQLStatement("SELECT COUNT(*) FROM tbl_lehrzeiten");             // Count Query für Lehrzeiten
            countsemester = mysql.getSQLStatement("SELECT COUNT(*) FROM tbl_semester");                 // Count Query für Semester

            berufcount = int.Parse(countberuf.Rows[0][0].ToString());                                   // Ausgabe in String konvertieren
            faechercount = int.Parse(countfaecher.Rows[0][0].ToString());                               // " "
            firmacount = int.Parse(countfirma.Rows[0][0].ToString());                                   // " "
            klassecount = int.Parse(countklasse.Rows[0][0].ToString());                                 // " "
            lehrlingcount = int.Parse(countlehrling.Rows[0][0].ToString());                             // " "
            lehrzeitencount = int.Parse(countlehrzeiten.Rows[0][0].ToString());                         // " "
            semestercount = int.Parse(countsemester.Rows[0][0].ToString());                             // " "

            this.chr_auswertung.Series.Clear();
            
            string[] seriesArray = { "Beruf", "Fächer", "Firma", "Klasse", "Lehrling", "Lehrzeiten", "Semester" };                          // Balken des Diagrams
            int[] pointsArray = { berufcount, faechercount, firmacount, klassecount, lehrlingcount, lehrzeitencount, semestercount };       // als Datenpunkte dienen die Resultate der Count Querys

            this.chr_auswertung.Palette = ChartColorPalette.Fire;                                                                           // Farbdesign der Balken

            this.chr_auswertung.Titles.Add("Anzahl Datensätze");                                                                            // Titel

            for (int i = 0; i < seriesArray.Length; i++)                                                                                    // Daten ins Diagramm einfügen
            {
                Series series = this.chr_auswertung.Series.Add(seriesArray[i]);
                series.Points.Add(pointsArray[i]);
            }
        }
    }
}