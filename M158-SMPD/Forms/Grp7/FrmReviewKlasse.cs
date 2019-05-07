using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;

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
            DataTable TableKlasse = mysql.getSQLStatement("SELECT * FROM tbl_klasse ORDER BY Kl_Nr ASC");       //MySQL Query für Tabelle "Klasse"
            TableKlasse.Columns[0].ColumnName = "Klassen Nr";                                                   //Umgänglicher Name für Spalte 1
            TableKlasse.Columns[1].ColumnName = "Klasse";                                                       //Umgänglicher Name für Spalte 2
            TableKlasse.Columns[2].ColumnName = "Beruf Nr";                                                     //Umgänglicher Name für Spalte 3

            DgvKlasse.DataSource = TableKlasse;                                                                 //DataGridView mit Daten der oben definierten Query befüllen

            foreach (DataGridViewColumn col in DgvKlasse.Columns)                                               //ForEach-Schlaufe um alle Spalten dem breitesten Element automatisch anzupassen
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
    }
}
