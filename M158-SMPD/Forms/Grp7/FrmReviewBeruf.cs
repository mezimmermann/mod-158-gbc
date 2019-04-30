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
    public partial class FrmReviewBeruf : Form
    {
        MySQLCon mysql = new MySQLCon();
        public FrmReviewBeruf()
        {
            InitializeComponent();
        }

        private void FrmReviewBeruf_Load(object sender, EventArgs e)
        {
            DataTable TableBeruf = mysql.getSQLStatement("SELECT * FROM tbl_beruf ORDER BY Be_Nr ASC");
            TableBeruf.Columns[0].ColumnName = "ID";
            DgvBeruf.DataSource = TableBeruf;
            DgvBeruf.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DgvBeruf.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DgvBeruf.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
    }
}
