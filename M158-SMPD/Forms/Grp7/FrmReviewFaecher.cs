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
    public partial class FrmReviewFaecher : Form
    {
        MySQLCon mysql = new MySQLCon();                       //MySQL-Connection initialisieren
        public FrmReviewFaecher()
        {
            InitializeComponent();
        }

        private void FrmReviewFaecher_Load(object sender, EventArgs e)
        {
            DataTable TableFaecher = mysql.getSQLStatement("SELECT * FROM tbl_faecher ORDER BY Fae_Nr ASC");    //MySQL Query  für Auswertung der Table "Faecher"
            TableFaecher.Columns[0].ColumnName = "Fach Nr";                                                     //Umgängliche Beschriftung der Spalte 1
            TableFaecher.Columns[1].ColumnName = "Fach Name";                                                   //Umgängliche Beschriftung der Spalte 2
            DgvFaecher.DataSource = TableFaecher;                                                               //Daten der oben ausgeführten Query 
            DgvFaecher.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;                       //Spalten so definieren, dass diese sich automatisch der breitesten anpassen
            DgvFaecher.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void DgvFaecher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
