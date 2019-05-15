using System;
using System.Data;
using System.Windows.Forms;

namespace M158_SMPD
{
    public partial class FrmReviewLehrling : Form
    {
        MySQLCon mysql = new MySQLCon();                    //MySQL Connection initialisieren
        public FrmReviewLehrling()
        {
            InitializeComponent();
        }

        private void FrmReviewLehrling_Load(object sender, EventArgs e)
        {
            DataTable TableLehrling = mysql.GetSqlStatement("SELECT * FROM tbl_lehrling ORDER BY Ll_Nr ASC");           //MySQL Query für Tabelle "Lehrling"
            TableLehrling.Columns[0].ColumnName = "Lehrlings Nr";                                                       //Umgänglicher Name für Spalte 1
            TableLehrling.Columns[1].ColumnName = "Firmen Nr";                                                          //""                           2
            TableLehrling.Columns[2].ColumnName = "Anrede";                                                             //""                           3
            TableLehrling.Columns[3].ColumnName = "Name";                                                               //""                           4
            TableLehrling.Columns[4].ColumnName = "Vorname";                                                            //""                           5
            TableLehrling.Columns[5].ColumnName = "Strasse";                                                            //""                           6
            TableLehrling.Columns[6].ColumnName = "Ortschafts Nr";                                                      //""                           7
            TableLehrling.Columns[7].ColumnName = "Telefon";                                                            //""                           8
            TableLehrling.Columns[8].ColumnName = "Zusatz";                                                             //""                           9
            TableLehrling.Columns[9].ColumnName = "Weiblich";                                                           //""                          10
            TableLehrling.Columns[10].ColumnName = "Geburtsdatum";                                                      //""                          11
            TableLehrling.Columns[11].ColumnName = "Lehrjahr Nr";                                                       //""                          12
            TableLehrling.Columns[12].ColumnName = "Aktiv";                                                             //""                          13
            TableLehrling.Columns[13].ColumnName = "Klassen Nr";                                                        //""                          14

            DgvLehrling.DataSource = TableLehrling;                                                                     //DataGridView mit Daten der oben definierten Query befüllen

            foreach (DataGridViewColumn col in DgvLehrling.Columns)                                                     //ForEach-Schlaufe um alle Spalten dem breitesten Element automatisch anzupassen
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

        }
    }
}
