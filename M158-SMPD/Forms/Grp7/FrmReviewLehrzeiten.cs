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
        MySQLCon mysql = new MySQLCon();
        public FrmReviewLehrzeiten()
        {
            InitializeComponent();
        }

        private void FrmReviewLehrzeiten_Load(object sender, EventArgs e)
        {
            DataTable TableLehrzeiten = mysql.getSQLStatement("SELECT * FROM tbl_lehrzeiten ORDER BY Lj_Nr ASC");
            TableLehrzeiten.Columns[0].ColumnName = "Lehrlings Nr";
            TableLehrzeiten.Columns[1].ColumnName = "Von";
            TableLehrzeiten.Columns[2].ColumnName = "Bis";

            DgvLehrzeiten.DataSource = TableLehrzeiten;

            foreach (DataGridViewColumn col in DgvLehrzeiten.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

        }
    }
}
