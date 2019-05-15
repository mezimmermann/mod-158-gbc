using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using M158_SMPD.Forms.Grp6;
using M158_SMPD.Forms.Grp5;

namespace M158_SMPD.Forms.Grp4
{
    public partial class FrmNotenlisten : Form
    {
        // Verbindung zum DB
        MySQLCon conn = new MySQLCon();
        private BindingSource mysqlbinder = new BindingSource();

        public FrmNotenlisten()
        {
            //Formen Initialisieren
            InitializeComponent();
        
        }

        private void cmx_class_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Vorhandene Klasse im Drop Down menü anzeigen
                string auswahlclass = (cmx_class.SelectedItem).ToString();
                string auswahl_subject = "SELECT Fach FROM tbl_faecher  INNER JOIN tbl_fae_kla_sem ON tbl_fae_kla_sem.Fae_Nr = tbl_faecher.Fae_Nr INNER JOIN tbl_klasse ON tbl_klasse.Kl_Nr = tbl_fae_kla_sem.Kl_Nr WHERE Klasse  = '" + auswahlclass + "'";


                DataTable table = conn.getSQLStatement(auswahl_subject);
                foreach (DataRow row in table.Rows)
                {
                    cmx_subject.Items.Add(row[0].ToString());
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void cmx_subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Vorhandene Fächer im Drop Down menü anzeigen
                string auswahlsubject = (cmx_subject.SelectedItem).ToString();
                string auswahlclass = (cmx_class.SelectedItem).ToString();
                var sqlstatement = "SELECT Name, Vorname, Note_1, Note_2, Note_3, Note_4, Note_5 FROM tbl_lehrling INNER JOIN tbl_noten ON tbl_noten.Ll_Nr = tbl_lehrling.Ll_Nr INNER JOIN tbl_fae_kla_sem ON tbl_lehrling.Kl_Nr = tbl_fae_kla_sem.Kl_Nr INNER JOIN tbl_faecher ON tbl_faecher.Fae_Nr = tbl_fae_kla_sem.Fae_Nr INNER JOIN tbl_klasse ON tbl_lehrling.Kl_Nr = tbl_klasse.Kl_Nr WHERE tbl_klasse.Klasse = '" + auswahlclass + "' AND tbl_faecher.Fach = '" + auswahlsubject + "'";


                DataTable tablesql = new DataTable();

                tablesql = conn.getSQLStatement(sqlstatement);

                mysqlbinder.DataSource = tablesql;

                dgvchoseclass.DataSource = mysqlbinder;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }



        private void frmNotenlisten_Load_1(object sender, EventArgs e)
        {
            try
            {
                //Drop Drawn Menü
                string auswahl_class = "SELECT * FROM tbl_klasse";

                DataTable _table = conn.getSQLStatement(auswahl_class);
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

        private void cmx_subject_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            try
            {
                //Datagriedview 
                string klasse = String.Format("SELECT Name, Vorname, Note_1, Note_2, Note_3, Note_4, Note_5 FROM tbl_lehrling INNER JOIN tbl_noten ON tbl_noten.Ll_Nr = tbl_lehrling.Ll_Nr");

                MySqlConnection connection = new MySqlConnection();
                MySqlCommand cmd = new MySqlCommand(klasse, connection);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
    }

}
