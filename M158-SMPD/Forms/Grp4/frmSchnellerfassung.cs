using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using M158_SMPD.Forms.Grp6;

namespace M158_SMPD.Forms.Grp4
{
    public partial class FrmSchnellerfassung : Form
    {
        // Verbindung zum DB
        MySQLCon conn = new MySQLCon();
        private BindingSource mysqlbinder = new BindingSource(); 

        public FrmSchnellerfassung()
        {
            //Formen Initialisierung
            InitializeComponent();

        }


        private void cmx_class_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int IntColumnCounter = 0;
                //DataGridview 
                string auswahlclass = (this.cmx_class.SelectedItem.ToString());
                var sqlstatement = "SELECT * from tbl_lehrling JOIN tbl_klasse ON tbl_lehrling.Kl_Nr=tbl_klasse.Kl_Nr WHERE tbl_klasse.Klasse = '" + auswahlclass + "'";

                DataTable tablesql = new DataTable();

                tablesql = conn.GetSqlStatement(sqlstatement);

                mysqlbinder.DataSource = tablesql;

                dgvchoseclass.DataSource = mysqlbinder;
                foreach (var Column in dgvchoseclass.Columns)
                {
                    dgvchoseclass.Columns[IntColumnCounter].Visible = false;

                    IntColumnCounter++;
                }
                dgvchoseclass.Columns[3].Visible = true;
                dgvchoseclass.Columns[4].Visible = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_class_search_Click(object sender, EventArgs e)
        {
            //Klassen Form öffnen
            FrmKlassen klassen = new FrmKlassen();
            klassen.MdiParent = this.MdiParent;
            klassen.Show();
            //Forms.Grp7.FrmReview frm = new Forms.Grp7.FrmReview
            //{
            //    MdiParent = this
            //};
            //frmReview.Show();
        }

        private void btn_subjects_Click(object sender, EventArgs e)
        {
            //Fächer öffnen
            //frmStammdaten faecher = new frmStammdaten();
            //faecher.ShowDialog();
        }


        private void frmSchnellerfassung_Load(object sender, EventArgs e)
        {
            try
            {
                //Klasse im Drop Down Menü
                string auswahl = "SELECT * FROM tbl_klasse";

                DataTable _table = conn.GetSqlStatement(auswahl);
                foreach (DataRow row in _table.Rows)
                {
                    cmx_class.Items.Add(row[1].ToString());
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); 
            }
            
        }

        private void cmx_class_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                //Datagriedview
                string klasse = String.Format("SELECT Name, Vorname from tbl_lehrling");

                MySqlConnection connection = new MySqlConnection();
                MySqlCommand cmd = new MySqlCommand(klasse, connection);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void dgvchoseclass_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Daten im DB direkt eintragen und speichern
                var sqlstatement = "UPDATE tbl_lehrling SET " + dgvchoseclass.Columns[e.ColumnIndex].Name + "='" + dgvchoseclass.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() + "' WHERE Ll_Nr=" + dgvchoseclass.Rows[e.RowIndex].Cells[0].Value.ToString();
                conn.SetSQLStatement(sqlstatement);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
