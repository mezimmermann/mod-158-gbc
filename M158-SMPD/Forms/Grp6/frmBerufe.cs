using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace M158_SMPD.Forms.Grp6
{
    public partial class FrmBerufe : Form
    {
        //From frmKlassen eingebunden
        FrmKlassen fk = new FrmKlassen();

        //Momentaner Verbindungsaufbau
        //string constring = "host=192.168.2.88;port=3306;user=remote;password=remote;database=access";

        MySQLCon mysql = new MySQLCon();

        //Variablen
        public string sBeruf;
        public string sKuerzel;
        public string sBerufNr;
        public string Query;

        public FrmBerufe()
        {
            InitializeComponent();
            FillCombo();
            Filllistbox();
            CheckKuerzel();
        }

        //Prüfung ob Textbox Kürzel und Berufe leer sind
        void CheckKuerzel()
        {
            if ((TbxKuerzel.Text != String.Empty) && (TbxBerufe.Text != String.Empty))
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
        void FillCombo()
        {
            cmxBerufe.Items.Clear();
            
            Query = "select * from tbl_beruf ; ";
            //MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlConnection conDataBase = mysql.GetConnection();
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
                conDataBase.Close();
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
            //MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlConnection conDataBase = mysql.GetConnection();
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
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //MySQL Insert Command
            Query = "insert into tbl_beruf (Beruf,Kürzel) values('" + this.TbxBerufe.Text + "','" + this.TbxKuerzel.Text + "') ;";
            //MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlConnection conDataBase = mysql.GetConnection();
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
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //Aktualisierung der List und Comboboxen sowie der Kürzel in der Klassen Form
            Filllistbox();
            FillCombo();
            fk.FillcmxKuerzel();

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            //MySQL update Command
            Query = "update tbl_beruf set Beruf='" + this.TbxBerufe.Text + "',Kürzel='" + this.TbxKuerzel.Text + "' where + Be_Nr='" + this.tbxBerufNr.Text + "'; ";
            //MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlConnection conDataBase = mysql.GetConnection();
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
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //Aktualisierung der List und Comboboxen sowie der Kürzel in der Klassen Form
            Filllistbox();
            FillCombo();
            fk.FillcmxKuerzel();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            //MySQL delete Command
            Query = "delete from tbl_beruf where Beruf='" + this.TbxBerufe.Text +"'; ";
            //MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlConnection conDataBase = mysql.GetConnection();
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
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //Aktualisierung der List und Comboboxen sowie der Kürzel in der Klassen Form
            Filllistbox();
            FillCombo();
            fk.FillcmxKuerzel();
        }

        private void CmxBerufe_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Daten werden abgerufen
            Query = "select * from tbl_beruf where Beruf='"+ cmxBerufe.Text + "'; ";
            //MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlConnection conDataBase = mysql.GetConnection();
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

                    TbxBerufe.Text = sBeruf;
                    lbxBerufe.Text = sBeruf;
                    TbxKuerzel.Text = sKuerzel;
                    tbxBerufNr.Text = sBerufNr;
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Sobald sich Textboxen ändern wird der Check ob sie leer sind ausgeführt
        private void TbxKuerzel_TextChanged(object sender, EventArgs e)
        {
            CheckKuerzel();
        }

        private void TbxBerufe_TextChanged(object sender, EventArgs e)
        {
            CheckKuerzel();
        }
    }
}
