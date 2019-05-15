using System;
using System.Data;
using System.Windows.Forms;

namespace M158_SMPD
{
    public partial class FrmReviewKlasse : Form
    {
        M158_SMPD.MySQLCon mysql = new MySQLCon();                          //MySQL Connection initialisieren
        public FrmReviewKlasse()
        {
            InitializeComponent();
        }

        private void FrmReviewKlasse_Load(object sender, EventArgs e)
        {
            DataTable TableKlasse = mysql.GetSqlStatement("SELECT Kl_Nr, Klasse,  Beruf, Kürzel, tbl_klasse.Be_Nr FROM tbl_klasse JOIN tbl_beruf on tbl_beruf.Be_Nr = tbl_klasse.Be_Nr Order By tbl_klasse.Kl_Nr asc");       //MySQL Query für Tabelle "Klasse"
            TableKlasse.Columns[0].ColumnName = "Klassen Nr";                                                   //Umgänglicher Name für Spalte 1
            TableKlasse.Columns[1].ColumnName = "Klasse";                                                       //Umgänglicher Name für Spalte 2
            TableKlasse.Columns[4].ColumnName = "Beruf Nr";                                                     //Umgänglicher Name für Spalte 3

            DgvKlasse.DataSource = TableKlasse;                                                                 //DataGridView mit Daten der oben definierten Query befüllen

            foreach (DataGridViewColumn col in DgvKlasse.Columns)                                               //ForEach-Schlaufe um alle Spalten dem breitesten Element automatisch anzupassen
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
    }
}
