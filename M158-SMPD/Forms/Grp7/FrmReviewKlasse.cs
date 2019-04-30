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
        M158_SMPD.MySQLCon mysql = new MySQLCon();
        public FrmReviewKlasse()
        {
            InitializeComponent();
        }

        private void FrmReviewKlasse_Load(object sender, EventArgs e)
        {
            DataTable TableKlasse = mysql.getSQLStatement("SELECT * FROM tbl_klasse ORDER BY Kl_Nr ASC");
            TableKlasse.Columns[0].ColumnName = "Klassen Nr";
            TableKlasse.Columns[1].ColumnName = "Klasse";
            TableKlasse.Columns[2].ColumnName = "Beruf Nr";

            DgvKlasse.DataSource = TableKlasse;

            foreach (DataGridViewColumn col in DgvKlasse.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
    }
}
