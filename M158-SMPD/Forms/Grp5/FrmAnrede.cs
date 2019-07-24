using System;
using System.Data;
using System.Windows.Forms;

namespace M158_SMPD.Forms.Grp5
{
    public partial class frmanrede : Form
    {
        private BindingSource BSbinder = new BindingSource(); // Ein Mysql Binder wird erstellt
        MySQLCon MYSQLconn = new MySQLCon(); //Eine Mysql MYSQLconn wird erstellt

        public frmanrede()
        {
            InitializeComponent(); //Komponenten werden Inizialisiert
            try
            {
                string sql = " SELECT * FROM tbl_anrede";//SQL Query wird erstellt
                DataTable table = new DataTable(); // Datatable wird erstellt

                table = MYSQLconn.GetSqlStatement(sql); //Abfrage wird mit MySQLCon.cs durchgeführt
                BSbinder.DataSource = table;//Daten werden Formatiert
                DgvFrmanrededisplay.DataSource = BSbinder; //Daten werden in Data Grid View gelesen

                DgvFrmanrededisplay.Columns["An_Nr"].ReadOnly = true; // Primary ID wird zum Bearbeiten Deaktiviert
            }
            catch (Exception e)
            {
                MessageBox.Show("Fehler beim Lesen. Starten Sie das Programm Neu.\n\n Error Message: \n\n " + e.Message);//Eine Messagebox wird ausgegeben das es ein  Fehler gibt.
            }
         }

        private void Btnsearchanrede_Click(object sender, EventArgs e)
        {
            try
            {
                var tbxcontent = "%" + Tbxsearchanrede.Text + "%";//Suche wird integriert
                string sql = " SELECT * FROM tbl_anrede WHERE tbl_anrede.Anrede LIKE '" + tbxcontent + "' OR tbl_anrede.An_Nr LIKE '" + tbxcontent + "'";//SQL Query wird erstellt
                DataTable table = new DataTable();// Datatable wird erstellt

                table = MYSQLconn.GetSqlStatement(sql); //Abfrage wird mit MySQLCon.cs durchgeführt
                BSbinder.DataSource = table;//Daten werden Formatiert
                DgvFrmanrededisplay.DataSource = BSbinder; //Daten werden in Data Grid View gelesen

                DgvFrmanrededisplay.Columns["An_Nr"].ReadOnly = true; // Primary ID wird zum Bearbeiten Deaktiviert
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Lesen. Starten Sie das Programm Neu.\n\n Error Message: \n\n " + ex.Message);//Eine Messagebox wird ausgegeben das es ein  Fehler gibt.
            }
        }

        private void Btnsavanrede_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable changes = ((DataTable)BSbinder.DataSource).GetChanges();//Änderungen werden ind den Datable changes durchgeführt
                MYSQLconn.SendDataTable(changes, "tbl_anrede");//Änderungen werden in die Datenbank geschrieben
                ((DataTable)BSbinder.DataSource).AcceptChanges();//Die Angezeigte Datatable akzeptiert die Daten nicht mehr als Änderungen und sieht sie als normal an
                MessageBox.Show("Gespeichert");//Eine Messagebox wird ausgegeben das es geschpeichert wurde.
            }
            catch (Exception)
            {
                MessageBox.Show("Fehler beim Schreiben");//Eine Messagebox wird ausgegeben das es geschpeichert wurde.
            }
        }
    }
}
