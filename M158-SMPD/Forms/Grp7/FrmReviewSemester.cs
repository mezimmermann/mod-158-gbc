using System;
using System.Data;
using System.Windows.Forms;

namespace M158_SMPD
{
    public partial class FrmReviewSemester : Form
    {
        MySQLCon mysql = new MySQLCon();                        //MySQL Connection Initialisieren
        public FrmReviewSemester()
        {
            InitializeComponent();
        }

        private void FrmReviewSemester_Load(object sender, EventArgs e)
        {
            DataTable TableSemester = mysql.GetSqlStatement("SELECT * FROM tbl_semester ORDER BY Se_Nr ASC");       //MySQL Query für Tabelle Semester
            TableSemester.Columns[0].ColumnName = "Semester Nr";                                                    //Umgängiger Name für Spalte 1
            TableSemester.Columns[1].ColumnName = "Semester";                                                       //""                         2

            DgvSemester.DataSource = TableSemester;                                                                 //DataGridView mit Daten der oben aufgeführten Query füllen

            foreach (DataGridViewColumn col in DgvSemester.Columns)                                                 //ForEach-Schlaufe um alle Spalten dem breitesten Element automatisch anzupassen
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; 
            }
        }
    }
}
