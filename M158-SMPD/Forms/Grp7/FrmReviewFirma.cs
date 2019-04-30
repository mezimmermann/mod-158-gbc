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
    public partial class FrmReviewFirma : Form
    {
        MySQLCon mysql = new MySQLCon();
        public FrmReviewFirma()
        {
            InitializeComponent();
        }

        private void FrmReviewFirma_Load(object sender, EventArgs e)
        {
            DataTable TableFirma = mysql.getSQLStatement("SELECT * FROM tbl_firma ORDER BY Fi_Nr ASC");
            TableFirma.Columns[0].ColumnName = "Firmen Nr";
            TableFirma.Columns[1].ColumnName = "Firmen Name";
            TableFirma.Columns[2].ColumnName = "Vorname";
            TableFirma.Columns[3].ColumnName = "Nachname";
            TableFirma.Columns[4].ColumnName = "Strasse";
            TableFirma.Columns[5].ColumnName = "Anrede Nr";
            TableFirma.Columns[6].ColumnName = "Ortschafts Nr";
            TableFirma.Columns[7].ColumnName = "Ansprechsperson";
            TableFirma.Columns[8].ColumnName = "Zusatz";
            TableFirma.Columns[9].ColumnName = "Telefon";
            TableFirma.Columns[10].ColumnName = "Fax";
            TableFirma.Columns[11].ColumnName = "Aktiv";
            DgvFirma.DataSource = TableFirma;

            
            foreach (DataGridViewColumn col in DgvFirma.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
    }
}
