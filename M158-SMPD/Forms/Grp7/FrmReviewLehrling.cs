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
    public partial class FrmReviewLehrling : Form
    {
        MySQLCon mysql = new MySQLCon();
        public FrmReviewLehrling()
        {
            InitializeComponent();
        }

        private void FrmReviewLehrling_Load(object sender, EventArgs e)
        {
            DataTable TableLehrling = mysql.getSQLStatement("SELECT * FROM tbl_lehrling ORDER BY Ll_Nr ASC");
            TableLehrling.Columns[0].ColumnName = "Lehrlings Nr";
            TableLehrling.Columns[1].ColumnName = "Firmen Nr";
            TableLehrling.Columns[2].ColumnName = "Anrede";
            TableLehrling.Columns[3].ColumnName = "Name";
            TableLehrling.Columns[4].ColumnName = "Vorname";
            TableLehrling.Columns[5].ColumnName = "Strasse";
            TableLehrling.Columns[6].ColumnName = "Ortschafts Nr";
            TableLehrling.Columns[7].ColumnName = "Telefon";
            TableLehrling.Columns[8].ColumnName = "Zusatz";
            TableLehrling.Columns[9].ColumnName = "Weiblich";
            TableLehrling.Columns[10].ColumnName = "Geburtsdatum";
            TableLehrling.Columns[11].ColumnName = "Lehrjahr Nr";
            TableLehrling.Columns[12].ColumnName = "Aktiv";
            TableLehrling.Columns[13].ColumnName = "Klassen Nr";

            DgvLehrling.DataSource = TableLehrling;

            foreach (DataGridViewColumn col in DgvLehrling.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

        }
    }
}
