using System;
using System.Data;
using System.Windows.Forms;

namespace M158_SMPD
{
    public partial class FrmReviewBeruf : Form
    {
        MySQLCon mysql = new MySQLCon();                        //MySQL Connection initialisieren
        public FrmReviewBeruf()
        {
            InitializeComponent();
        }

        private void FrmReviewBeruf_Load(object sender, EventArgs e)
        {
            DataTable TableBeruf = mysql.GetSqlStatement("SELECT * FROM tbl_beruf ORDER BY Be_Nr ASC");         //MySQL Query für Tabelle "Beruf"
            TableBeruf.Columns[0].ColumnName = "ID";                                                            //Umgängige Beschriftung für Spalte 1
            DgvBeruf.DataSource = TableBeruf;                                                                   //DataGridView mit Daten aus oben stehender Query füllen
            DgvBeruf.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;                         //Spalten automatisch dem breitesten Element anpassen
            DgvBeruf.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DgvBeruf.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
    }
}
