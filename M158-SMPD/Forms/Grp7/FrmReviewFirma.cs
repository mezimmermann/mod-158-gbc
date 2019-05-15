using System;
using System.Data;
using System.Windows.Forms;

namespace M158_SMPD
{
    public partial class FrmReviewFirma : Form
    {
        MySQLCon mysql = new MySQLCon();                                       //MySQL Connection initialisieren
        public FrmReviewFirma()
        {
            InitializeComponent();
        }

        private void FrmReviewFirma_Load(object sender, EventArgs e)
        {
            DataTable TableFirma = mysql.GetSqlStatement("SELECT Fi_Nr, F_Name, Anrede, F_Vorname, F_Nachname, Ort, F_Strasse, F_Ansprechperson, F_Zusatz, F_Telefon, F_Fax FROM tbl_firma JOIN tbl_anrede on tbl_anrede.An_Nr = tbl_firma.An_Nr JOIN tbl_ort on tbl_ort.Or_Nr = tbl_firma.Or_Nr;");                 //MySQL Query für Tabelle "Firma"
            TableFirma.Columns[0].ColumnName = "Firmen Nr";                                                             //Umgängliche Beschriftung für Spalte 1
            TableFirma.Columns[1].ColumnName = "Firmen Name";                                                           //Umgängliche Beschriftung für Spalte 2
            TableFirma.Columns[2].ColumnName = "Anrede";                                                                //Umgängliche Beschriftung für Spalte 3
            TableFirma.Columns[3].ColumnName = "Vorname";                                                               //Umgängliche Beschriftung für Spalte 4
            TableFirma.Columns[4].ColumnName = "Nachname";                                                              //Umgängliche Beschriftung für Spalte 5
            TableFirma.Columns[5].ColumnName = "Ortschaft";                                                             //Umgängliche Beschriftung für Spalte 6
            TableFirma.Columns[6].ColumnName = "Adresse";                                                               //  " "                               7
            TableFirma.Columns[7].ColumnName = "Ansprechperson";                                                        //  " "                               8
            TableFirma.Columns[8].ColumnName = "Zusatz";                                                                //  " "                               9
            TableFirma.Columns[9].ColumnName = "Telefon";                                                               //  " "                              10
            TableFirma.Columns[10].ColumnName = "Fax";                                                                  //  " "                              11
            DgvFirma.DataSource = TableFirma;                                                                           //DataGridView mit Daten der oben ausgeführten Query füllen

            
            foreach (DataGridViewColumn col in DgvFirma.Columns)                                                        //ForEach-Schlaufe um alle Spalten dem breitesten Element automatisch anzupassen
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
    }
}
