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
    public partial class FrmReviewSemester : Form
    {
        MySQLCon mysql = new MySQLCon();
        public FrmReviewSemester()
        {
            InitializeComponent();
        }

        private void FrmReviewSemester_Load(object sender, EventArgs e)
        {
            DataTable TableSemester = mysql.getSQLStatement("SELECT * FROM tbl_semester ORDER BY Se_Nr ASC");
            TableSemester.Columns[0].ColumnName = "Semester Nr";
            TableSemester.Columns[1].ColumnName = "Semester";

            DgvSemester.DataSource = TableSemester;

            foreach (DataGridViewColumn col in DgvSemester.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
    }
}
