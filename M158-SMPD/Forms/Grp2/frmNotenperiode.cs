using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace M158_SMPD.Forms
{
    public partial class frmNotenperiode : Form
    {
        MySQLCon mysql = new MySQLCon();        //Variablen werden hier definiert
        string[] ArrDatatable;
        string[] ArrClass;
        DataTable DtClass;
        DataTable DtClassTotal;
//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------       
        public frmNotenperiode()
        {
            InitializeComponent();      //Initialisierung
        }
//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------  
        private void frmNotenperiode_Load(object sender, EventArgs e)
        {
            NotenperiodeLoadList();     //Beim Öffnen der Form wird die Liste geladen
        }
//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------  
        private void NotenperiodeLoadList()
        {
            CbxDrop.Items.Clear();
            DataTable DtDatatable = mysql.GetSqlStatement("SELECT DISTINCT * FROM tbl_semester");       //Alle Notenperioden werden ausgewählt
            ArrDatatable = DtDatatable.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            for (int i = 0; i < ArrDatatable.Length; i++)
            {
                if (i > 0)
                {
                    DtClass = mysql.GetSqlStatement("SELECT Semester FROM tbl_semester WHERE Se_Nr = " + ArrDatatable[i]);      //Hier werden alle Semester entsprechend der SE_Nr angezeigt
                    DtClassTotal.Merge(DtClass);
                }
                else
                {
                    DtClassTotal = mysql.GetSqlStatement("SELECT Semester FROM tbl_semester WHERE Se_Nr = " + ArrDatatable[i]);     //Hier werden alle Semester entsprechend der SE_Nr angezeigt
                }
            }
            ArrClass = DtClassTotal.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            for (int i = 0; i < ArrClass.Length; i++)
            {
                CbxDrop.Items.Add(ArrClass[i]);
            }            
        }
//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------  
        private void CbxDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            TbxEdit.Text = CbxDrop.Text;        //Der Text in der Combobox wir mit dem angepassten Text angepasst
        }
//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------  
        private void button1_Click(object sender, EventArgs e)      //SAVE-Button: Was geschieht wenn der "Speicher-Button" geklickt wird.
        {
            string StrQuery1 = "Select Se_Nr FROM tbl_semester where Semester = '" + CbxDrop.Text + "'";        
            DataTable Dtresult = mysql.GetSqlStatement(StrQuery1);
            int Intresult = Convert.ToInt16(Dtresult.Rows[0][0]);
            string StrQuery2 = "UPDATE tbl_semester SET Semester='" + TbxEdit.Text + "' WHERE Se_Nr=" + Intresult;
            mysql.SetSQLStatement(StrQuery2);
            NotenperiodeLoadList();
            CbxDrop.Text = TbxEdit.Text;
            MessageBox.Show("Semestername wurde zu " + TbxEdit.Text + " geändert!");       //Als Information für den Benutzer "Die Werte wurden geändert"
        }
    }
}
