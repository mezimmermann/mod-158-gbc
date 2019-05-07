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
    public partial class FrmReviewLehrzeiten : Form
    {
        MySQLCon mysql = new MySQLCon();                                //MySQL Connection initialisieren
        public FrmReviewLehrzeiten()
        {
            InitializeComponent();
        }

        private void FrmReviewLehrzeiten_Load(object sender, EventArgs e)                                                               
        {
            DataTable TableLehrzeiten = mysql.getSQLStatement("SELECT tbl_lehrling.Lj_Nr, Lj_Bis, Ll_Nr, Name, Vorname FROM tbl_lehrzeiten JOIN tbl_lehrling on tbl_lehrling.Lj_Nr = tbl_lehrzeiten.Lj_Nr Order By tbl_lehrling.Lj_Nr asc");                   //MySQL Query für Tabelle "Lehrzeiten"
            TableLehrzeiten.Columns[0].ColumnName = "Lehrjahres Nr";                                                                //Umgänglicher Name für Spalte 1
            TableLehrzeiten.Columns[1].ColumnName = "Bis";                                                                          //""                           2
            TableLehrzeiten.Columns[2].ColumnName = "Lehrlings Nr";                                                                 //""                           3

            DgvLehrzeiten.DataSource = TableLehrzeiten;                                                                             //DataGridView mit Daten der oben definierten Query befüllen

            foreach (DataGridViewColumn col in DgvLehrzeiten.Columns)                                                               //ForEach-Schlaufe um alle Spalten dem breitesten Element automatisch anzupassen
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

        }
    }
}
