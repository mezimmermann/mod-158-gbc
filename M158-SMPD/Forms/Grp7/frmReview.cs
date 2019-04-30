using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M158_SMPD.Forms
{
    public partial class frmReview : Form
    {
        public frmReview()
        {
            MySQLCon mysql = new MySQLCon();
            //mysql.setSQLStatement("");

            DataTable TableBeruf = mysql.getSQLStatement("SELECT * FROM tbl_beruf");
            //DataTable TableFaecher = mysql.getSQLStatement("SELECT * FROM tbl_faecher");
            //DataTable TableFirma = mysql.getSQLStatement("SELECT * FROM tbl_firma");
            //DataTable TableKlasse = mysql.getSQLStatement("SELECT * FROM tbl_klasse");
            //DataTable TableLehrling = mysql.getSQLStatement("SELECT * FROM tbl_lehrling");
            //DataTable TableLehrzeit = mysql.getSQLStatement("SELECT * FROM tbl_lehrzeiten");
            //DataTable TableSemester = mysql.getSQLStatement("SELECT * FROM tbl_semester");

            //MessageBox.Show(outTable.Rows[0].RowState.ToString());
            InitializeComponent();
        }

        private void btn_beruf_ext_form_Click(object sender, EventArgs e)
        {
            FrmReviewBeruf fberuf = new FrmReviewBeruf();
            fberuf.ShowDialog(); // Shows Form2
        }
    }
}
