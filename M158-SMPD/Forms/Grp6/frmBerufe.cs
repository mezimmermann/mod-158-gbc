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

namespace M158_SMPD.Forms.Grp6
{
    public partial class frmBerufe : Form
    {
        //From frmKlassen eingebunden
        frmKlassen fk = new frmKlassen();

        //Momentaner Verbindungsaufbau
        string constring = "host=192.168.2.109;port=3306;user=remote;password=remote;database=access";

        MySQLCon mysql = new MySQLCon();

        //Variablen
        public string sBeruf;
        public string sKuerzel;
        public string sBerufNr;
        public string Query;

        public frmBerufe()
        {
            InitializeComponent();
            Filllcombo();
            Filllistbox();
            checkkürzel();
            //Form Klassen wird gleichzeitig geöffnet
            fk.Show();
        }

        //Prüfung ob Textbox Kürzel und Berufe leer sind
        void checkkürzel()
        {
            if ((tbxKuerzel.Text != String.Empty) && (tbxBerufe.Text != String.Empty))
            {
                btnAdd.Enabled = true;
                btnEdit.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
            }
        }

        //Combobox Berufe mit Daten füllen
        void Filllcombo()
        {
            cmxBerufe.Items.Clear();
            
            Query = "select * from tbl_beruf ; ";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {
                    sBeruf = myReader.GetString("Beruf");
                    cmxBerufe.Items.Add(sBeruf);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Listbox Berufe mit Daten füllen
        void Filllistbox()
        {
            lbxBerufe.Items.Clear();
            
            Query = "select * from tbl_beruf ; ";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {
                    
                    sBeruf = myReader.GetString("Beruf");
                    lbxBerufe.Items.Add(sBeruf);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //MySQL Insert Command
            Query = "insert into tbl_beruf (Beruf,Kürzel) values('" + this.tbxBerufe.Text + "','" + this.tbxKuerzel.Text + "') ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                //Ausführung des Commands
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Added");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //Aktualisierung der List und Comboboxen sowie der Kürzel in der Klassen Form
            Filllistbox();
            Filllcombo();
            fk.FillcmxKuerzel();

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            //MySQL update Command
            Query = "update tbl_beruf set Beruf='" + this.tbxBerufe.Text + "',Kürzel='" + this.tbxKuerzel.Text + "' where + Be_Nr='" + this.tbxBerufNr.Text + "'; ";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                //Ausführung des Commands
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Updated");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //Aktualisierung der List und Comboboxen sowie der Kürzel in der Klassen Form
            Filllistbox();
            Filllcombo();
            fk.FillcmxKuerzel();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            //MySQL delete Command
            Query = "delete from tbl_beruf where Beruf='" + this.tbxBerufe.Text +"'; ";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                //Ausführung des Commands
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Gelöscht");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //Aktualisierung der List und Comboboxen sowie der Kürzel in der Klassen Form
            Filllistbox();
            Filllcombo();
            fk.FillcmxKuerzel();
        }

        private void cmxBerufe_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Daten werden abgerufen
            Query = "select * from tbl_beruf where Beruf='"+ cmxBerufe.Text + "'; ";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                //Ausführung des Commands
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {
                    //Textboxen werden mit Daten befüllt
                    sBeruf = myReader.GetString("Beruf");
                    sKuerzel = myReader.GetString("Kürzel");
                    sBerufNr = myReader.GetString("Be_Nr");

                    tbxBerufe.Text = sBeruf;
                    lbxBerufe.Text = sBeruf;
                    tbxKuerzel.Text = sKuerzel;
                    tbxBerufNr.Text = sBerufNr;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Sobald sich Textboxen ändern wird der Check ob sie leer sind ausgeführt
        private void tbxKuerzel_TextChanged(object sender, EventArgs e)
        {
            checkkürzel();
        }

        private void TbxBerufe_TextChanged(object sender, EventArgs e)
        {
            checkkürzel();
        }
    }
}
