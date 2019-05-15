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

namespace M158_SMPD.Forms.Grp6
{
    public partial class FrmKlassen : Form
    {
        //Momentaner Verbindungsaufbau
        string constring = "host=192.168.2.109;port=3306;user=remote;password=remote;database=access";

        //Variablen
        public int FillKuerzel;
        public int Add;
        public int edit;
        public string sKlasse;
        public string sKlasseNr;
        public string Query;
        public string QueryAdd;
        public string Queryedit;
        public string sBeruf;
        public string Querybenr;
        public string QueryFillKuerzel;

        public FrmKlassen()
        {
            InitializeComponent();
            Filllcombo();
            Filllistbox();
            FillcmxKuerzel();
            checkklasse();
        }

        //Prüfung ob Textbox Klasse leer ist
        void checkklasse()
        {
            if ((tbxKlasse.Text != String.Empty))
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

        //Combobox Kürzel mit Daten füllen
        public void FillcmxKuerzel()
        {
            cmxKuerzel.Items.Clear();
            //Berufs Tabelle wird abgefragt
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
                    sBeruf = myReader.GetString("Kürzel");
                    cmxKuerzel.Items.Add(sBeruf);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Kombobox Klassen füllen
        void Filllcombo()
        {
            cmxKlasse.Items.Clear();
            //Berufs Tabelle wird abgefragt
            Query = "select * from tbl_klasse ; ";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {
                    sKlasse = myReader.GetString("Klasse");
                    cmxKlasse.Items.Add(sKlasse);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Listbox Klassen füllen
        void Filllistbox()
        {
            lbxKlasse.Items.Clear();
            //Berufs Tabelle wird abgefragt
            Query = "select * from tbl_klasse ; ";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {

                    sKlasse = myReader.GetString("Klasse");
                    lbxKlasse.Items.Add(sKlasse);

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //Hauptschlüssel der Berufe wird eingelesen
            QueryAdd = "select Be_Nr from tbl_beruf where Kürzel='" + cmxKuerzel.Text + "'; ";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdAdd = new MySqlCommand(QueryAdd, conDataBase);
            MySqlDataReader AddReader;
            conDataBase.Open();
            AddReader = cmdAdd.ExecuteReader();

            while (AddReader.Read())
            {
                //Berufsnummer werden in Array eingelesen
                Add = Convert.ToInt16(AddReader[0]);
            }
            conDataBase.Close();

            //Insert Command mit den Berufsnummer aus dem Array
            Query = "insert into tbl_klasse (Klasse,Be_Nr) values('" + this.tbxKlasse.Text + "','" + Add + "') ;";
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                //Command wird ausgeführt
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Added");
                while (myReader.Read())
                {

                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //Aktualisierung Comboboxen und Listboxen
            Filllcombo();
            Filllistbox();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            //Hauptschlüssel der Berufe wird eingelesen
            Queryedit = "select Be_Nr from tbl_beruf where Kürzel='" + cmxKuerzel.Text + "'; ";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdedit = new MySqlCommand(Queryedit, conDataBase);
            MySqlDataReader editReader;
            conDataBase.Open();
            editReader = cmdedit.ExecuteReader();

            while (editReader.Read())
            {
                //Berufsnummer werden in Array eingelesen
                edit = Convert.ToInt16(editReader[0]);
            }
            conDataBase.Close();

            //Update Command mit den Berufsnummer aus dem Array
            Query = "update tbl_klasse set Klasse='" + this.tbxKlasse.Text + "',Be_Nr='" + edit + "' where + Kl_Nr='" + this.tbxKlasseNr.Text + "'; "; 
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
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
            //Aktualisierung Comboboxen und Listboxen
            Filllcombo();
            Filllistbox();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            //MySQL Delete Command
            Query = "delete from tbl_klasse where Klasse='" + this.tbxKlasse.Text + "'; ";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
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
            //Aktualisierung Comboboxen und Listboxen
            Filllcombo();
            Filllistbox();
        }

        private void cmxKlasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            Query = "select * from tbl_klasse where Klasse='" + cmxKlasse.Text + "'; ";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {
                    //Daten werden in Textboxen eingelesen
                    sKlasse = myReader.GetString("Klasse");
                    sKlasseNr = myReader.GetString("Kl_Nr");
                    tbxKlasse.Text = sKlasse;
                    lbxKlasse.Text = sKlasse;
                    tbxKlasseNr.Text = sKlasseNr;

                }
                conDataBase.Close();

                //Berufsnummer werden von der Klassen Tabelle ausgelesen
                Querybenr = "select Be_Nr from tbl_klasse where Klasse='" + cmxKlasse.Text + "'; ";
                MySqlCommand cmdbenr = new MySqlCommand(Querybenr, conDataBase);
                MySqlDataReader benrReader;
                conDataBase.Open();
                benrReader = cmdbenr.ExecuteReader();
                while (benrReader.Read())
                {
                    //Berufsnummer werden in Array gelesen
                    FillKuerzel = Convert.ToInt16(benrReader[0]);
                }
                conDataBase.Close();

                //Wenn der Fremdschlüssel 0 ist, dann ist kein Kürzel vorhanden
                if (FillKuerzel == 0)
                {
                    cmxKuerzel.Text = "";
                }
                
                //Kürzel werden mit dem Array der Berufsnummer ausgelesen
                QueryFillKuerzel = "select Kürzel from tbl_beruf where Be_Nr='" + FillKuerzel + "'; ";
                MySqlCommand cmdFillKuerzel = new MySqlCommand(QueryFillKuerzel, conDataBase);
                MySqlDataReader FillKuerzelReader;
                conDataBase.Open();
                FillKuerzelReader = cmdFillKuerzel.ExecuteReader();
                while (FillKuerzelReader.Read())
                {
                    //Kürzel werden in Textnbox Kürzel geschrieben
                    cmxKuerzel.Text = Convert.ToString(FillKuerzelReader[0]);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Wenn sich Textbox ändern wird gecheckt, ob sie leer ist
        private void TbxKlasse_TextChanged(object sender, EventArgs e)
        {
            checkklasse();
        }
    }
}
