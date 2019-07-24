using System;
using System.Data;
using System.Windows.Forms;

namespace M158_SMPD.Forms.Grp5
{
    public partial class frmort : Form
    {
        private BindingSource BSbinder = new BindingSource(); // Ein Mysql Binder wird erstellt
        MySQLCon MYSQLconn = new MySQLCon(); //Eine Mysql MYSQLconn wird erstellt

        public frmort()
        {
            InitializeComponent(); //Komponenten werden Inizialisiert
            try
            {
                string sql = " SELECT * FROM tbl_ort"; //SQL Query wird erstellt
                DataTable table = new DataTable(); // Datatable wird erstellt

                table = MYSQLconn.GetSqlStatement(sql); //Abfrage wird mit MySQLCon.cs durchgeführt
                BSbinder.DataSource = table; //Daten werden Formatiert
                DgvFrmortdisplay.DataSource = BSbinder; //Daten werden in Data Grid View gelesen

                DgvFrmortdisplay.Columns["Or_Nr"].ReadOnly = true; // Primary ID wird zum Bearbeiten Deaktiviert
            }
            catch (Exception e)
            {
                MessageBox.Show("Fehler beim Lesen. Starten Sie das Programm Neu.\n\n Error Message: \n\n " + e.Message);//Eine Messagebox wird ausgegeben das es ein  Fehler gibt.
            }
        }

        private void BtnSearchOrt_Click(object sender, EventArgs e)
        {
            try
            {
                var tbxcontent = "%" + Tbxsearchort.Text + "%";//Suche wird integriert
                string sql = " SELECT * FROM tbl_ort WHERE tbl_ort.Ort LIKE '" + tbxcontent + "' OR tbl_ort.PLZ LIKE '" + tbxcontent + "' OR tbl_ort.Or_Nr LIKE '" + tbxcontent + "'";//SQL Query wird erstellt mit Where Statement
                DataTable table = new DataTable(); // Datatable wird erstellt

                table = MYSQLconn.GetSqlStatement(sql); //Abfrage wird mit MySQLCon.cs durchgeführt

                BSbinder.DataSource = table;//Daten werden Formatiert
                DgvFrmortdisplay.DataSource = BSbinder; //Daten werden in Data Grid View gelesen

                DgvFrmortdisplay.Columns["Or_Nr"].ReadOnly = true; // Primary ID wird zum Bearbeiten Deaktiviert
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Lesen. Starten Sie das Programm Neu.\n\n Error Message: \n\n " + ex.Message);//Eine Messagebox wird ausgegeben das es ein  Fehler gibt.
            }
        }

        private void BtnSaveOrt_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable changes = ((DataTable)BSbinder.DataSource).GetChanges(); //Änderungen werden ind den Datable changes durchgeführt
                MYSQLconn.SendDataTable(changes, "tbl_ort"); //Änderungen werden in die Datenbank geschrieben
                ((DataTable)BSbinder.DataSource).AcceptChanges(); //Die Angezeigte Datatable akzeptiert die Daten nicht mehr als Änderungen und sieht sie als normal an
                MessageBox.Show("Gespeichert"); //Eine Messagebox wird ausgegeben das es geschpeichert wurde.
            }
            catch (Exception)
            {
                MessageBox.Show("Fehler beim Schreiben");//Eine Messagebox wird ausgegeben das es geschpeichert wurde.
            }
        }
    }
}
