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
    public partial class FrmReviewFirma : Form
    {
        MySQLCon mysql = new MySQLCon();                                       //MySQL Connection initialisieren
        public FrmReviewFirma()
        {
            InitializeComponent();
        }

        private void FrmReviewFirma_Load(object sender, EventArgs e)
        {
            DataTable TableFirma = mysql.getSQLStatement("SELECT * FROM tbl_firma ORDER BY Fi_Nr ASC");                 //MySQL Query für Tabelle "Firma"
            TableFirma.Columns[0].ColumnName = "Firmen Nr";                                                             //Umgängliche Beschriftung für Spalte 1
            TableFirma.Columns[1].ColumnName = "Firmen Name";                                                           //Umgängliche Beschriftung für Spalte 2
            TableFirma.Columns[2].ColumnName = "Vorname";                                                               //Umgängliche Beschriftung für Spalte 3
            TableFirma.Columns[3].ColumnName = "Nachname";                                                              //Umgängliche Beschriftung für Spalte 4
            TableFirma.Columns[4].ColumnName = "Strasse";                                                               //Umgängliche Beschriftung für Spalte 5
            TableFirma.Columns[5].ColumnName = "Anrede Nr";                                                             //Umgängliche Beschriftung für Spalte 6
            TableFirma.Columns[6].ColumnName = "Ortschafts Nr";                                                         //  " "                               7
            TableFirma.Columns[7].ColumnName = "Ansprechsperson";                                                       //  " "                               8
            TableFirma.Columns[8].ColumnName = "Zusatz";                                                                //  " "                               9
            TableFirma.Columns[9].ColumnName = "Telefon";                                                               //  " "                              10
            TableFirma.Columns[10].ColumnName = "Fax";                                                                  //  " "                              11
            TableFirma.Columns[11].ColumnName = "Aktiv";                                                                //  " "                              12
            DgvFirma.DataSource = TableFirma;                                                                           //DataGridView mit Daten der oben ausgeführten Query füllen

            
            foreach (DataGridViewColumn col in DgvFirma.Columns)                                                        //ForEach-Schlaufe um alle Spalten dem breitesten Element automatisch anzupassen
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
    }
}
