using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace M158_SMPD.Forms.Grp3
{
    public partial class frmClassMgmt : Form
    {
        public int klnr;
        public string studnr;

        public frmClassMgmt()
        {
            InitializeComponent();
            lbxstudents.Font = new Font(lbxstudents.Font.FontFamily, 12);

            try
            {
                cmxclass.Items.Clear();
                var classquerry = new M158_SMPD.MySQLCon();
                DataTable DtClass = classquerry.getSQLStatement("SELECT `Klasse` FROM `tbl_klasse` WHERE 1");
                foreach (DataRow row in DtClass.Rows)
                {
                    cmxclass.Items.Add(row["Klasse"].ToString());
                }
            }
            catch
            {
                MessageBox.Show("Fehler beim Verbinden mit der Datenbank");
                Application.Exit();
            }
        }

        private void lbxstudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string lbxstudentsindex;
                string prename;
                string name;
                lbxstudentsindex = lbxstudents.Text;

                int stop = 0;
                int preneamelength = 0;
                while (stop == 0)
                {
                    string item = "";
                    item = lbxstudentsindex.Substring(preneamelength, 1);
                    foreach (char c in item)
                    {
                        if (c == 9)
                        {
                            stop = 1;
                        }
                        else
                        {
                            preneamelength++;
                        }
                    }
                }

                prename = lbxstudentsindex.Substring(0, preneamelength);
                stop = 0;
                int start = preneamelength +1 ;
                while (stop == 0)
                {
                    string item = "";
                    item = lbxstudentsindex.Substring(start, 1);
                    foreach (char c in item)
                    {
                        if (c == 9)
                        {
                            stop = 1;
                        }
                        else
                        {
                            start++;
                        }
                    }
                }
                int namelength = start - preneamelength;
                name = lbxstudentsindex.Substring(preneamelength + 1, namelength-1);
                var classquerry = new M158_SMPD.MySQLCon();
                DataTable DtClass = classquerry.getSQLStatement("SELECT `Ll_Nr` FROM `tbl_lehrling` WHERE `Vorname` = '" + prename + "' AND `Name` = '" + name + "'");
                foreach (DataRow row in DtClass.Rows)
                {
                    studnr = row["Ll_Nr"].ToString();
                }
                var student = new M158_SMPD.Forms.Grp3.frmStudMgmt();
                student.getexdata(studnr);
            }
            catch
            {
                MessageBox.Show("Der Schüler konnte nicht geöffenet werden, versuchen Sie es erneut oder kontakieren Sie den Support");
            }
        }

        private void cmxclass_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                lbxstudents.Items.Clear();
                var classquerry = new M158_SMPD.MySQLCon();
                DataTable DtClass = classquerry.getSQLStatement("SELECT `Kl_Nr` FROM `tbl_klasse` WHERE `Klasse` = '" + cmxclass.Text + "'");
                foreach (DataRow row in DtClass.Rows)
                {
                    klnr = Convert.ToInt16(row["Kl_Nr"]);
                }

                DataTable DtClass2 = classquerry.getSQLStatement("SELECT `Vorname`,`Name` FROM `tbl_lehrling` WHERE `Kl_Nr` = " + klnr);
                foreach (DataRow row in DtClass2.Rows)
                {
                    lbxstudents.Items.Add(row["Vorname"].ToString() + "\t" + row["Name"].ToString() + "\t");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnclasses_Click(object sender, EventArgs e)
        {

        }

        private void btnsubj_Click(object sender, EventArgs e)
        {

        }
    }
}
