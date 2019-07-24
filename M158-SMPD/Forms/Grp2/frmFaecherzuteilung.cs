using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace M158_SMPD.Forms
//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
{
    public partial class frmFaecherzuteilung : Form
    {
        MySQLCon mysql = new MySQLCon();                //Variablen werden hier definiert
        string[] ArrDatatable;
        string[] ArrClass;
        DataTable DtClass;
        DataTable DtClassTotal;
        public frmFaecherzuteilung()
        {
            InitializeComponent();              //Initialisierung
        }


//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void frmFaecherzuteilung_Load(object sender, EventArgs e)               //Laden der Form
        {
            DataTable DtDatatable = mysql.GetSqlStatement("SELECT DISTINCT Kl_Nr FROM tbl_fae_kla_sem");            //Aus der Tabelle "tbl_fae_kla_sem" werden alle Klassen ausgewählt
            ArrDatatable = DtDatatable.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            for (int i = 0; i < ArrDatatable.Length; i++)                                                           //i=0 wenn ArrDatatable grösser als 0 wird die ausgewählte Klasse angezeigt
            {
                if (i > 0)
                {
                    DtClass = mysql.GetSqlStatement("SELECT klasse FROM tbl_klasse WHERE Kl_Nr = " + ArrDatatable[i]);      //Hier werden alle Klassen entsprechend der Kl_Nr angezeigt ansonsten passiert da gleiche
                    DtClassTotal.Merge(DtClass);
                }
                else
                {
                    DtClassTotal= mysql.GetSqlStatement("SELECT klasse FROM tbl_klasse WHERE Kl_Nr = " + ArrDatatable[i]);      //Hier werden nochmal alle Klassen entsprechend der Kl_Nr angezeigt
                }
            }
            ArrClass = DtClassTotal.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            for (int i = 0; i < ArrClass.Length; i++)
            {
                CmxClass.Items.Add(ArrClass[i]);
            }
        }
//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void CmxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable DtGrid = mysql.GetSqlStatement("SELECT * FROM faecherzuteilung WHERE Klasse = '" + CmxClass.Text + "'");      //Statement welches die Informationen aus "faecherzuteilung" auswählt, welche man über die CmxClass ausgewählt hat
            DgvView.DataSource = DtGrid;
            DgvView.Columns["Se_Nr"].Visible = false;
            DgvView.Columns["Klasse"].Visible = false;
            DgvView.Columns["Fae_Nr"].Visible = false;
            DgvView.Columns["Kl_Nr"].Visible = false;

        }
//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------      
        private void DgvView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string StrQuery = "";
            if(DgvView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "")    //Sobald der Wert im Gridview geändert wird, wir die COLUMN in der Tabelle geändert
            {
                if (DgvView.Columns[e.ColumnIndex].Name == "Semester")
                {
                    StrQuery = "UPDATE tbl_semester SET Semester='" + DgvView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() + "' WHERE Se_Nr=" + DgvView.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
                else
                {
                    StrQuery = "UPDATE tbl_faecher SET Fach='" + DgvView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() + "' WHERE Fae_Nr=" + DgvView.Rows[e.RowIndex].Cells[4].Value.ToString();
                }
                mysql.SetSQLStatement(StrQuery);
            }
            else
            {
                MessageBox.Show("Bitte geben Sie einen Wert ein");        //Bei keiner Eingabe (NOT NULL) erscheint eine Messagebox welche den Benutzer informiert
                return;
            }
        }
    }
}
