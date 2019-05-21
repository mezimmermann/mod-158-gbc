using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace M158_SMPD.Forms.Grp3
{
    public partial class FrmCompData : Form
    {
        public int sal; //Variabel für die Anrede
        public int plz; //Variabel für die Postleitzahl

        public FrmCompData()
        {
            InitializeComponent();     
            //Alle Text und Comboboxen leeren
            cmxcompsrc.Items.Clear();
            tbxcomp.Clear();
            cmxsal.Items.Clear();
            tbxname.Clear();
            tbxprename.Clear();
            tbxstreet.Clear();
            cmxplz.Items.Clear();
            cmxtown.Items.Clear();
            tbxcontact.Clear();
            tbxadd.Clear();
            tbxtel.Clear();
            tbxfax.Clear();
            cbxactive.Checked = false;
            cmxsal.Text = "";
            cmxtown.Text = "";
            cmxplz.Text = "";
            //Firmenauswahl Dropdown "Neue Firma" einfügen für das erstellen neuer Firmen
            cmxcompsrc.Items.Add("Neue Firma");

            try
            {
                //Alle Firmen werden eingelesen und in ein Dropdownmenu eingelesen
                var classquerry = new M158_SMPD.MySQLCon();
                DataTable DtClass = classquerry.GetSqlStatement("SELECT `F_Name` FROM `tbl_firma` WHERE 1");
                foreach (DataRow row in DtClass.Rows)
                {
                    cmxcompsrc.Items.Add(row["F_Name"].ToString());
                }
            }
            catch
            {
                MessageBox.Show("Fehler beim Verbinden mit der Datenbank");
                System.Environment.Exit(1);
            }

            try
            {
                //Erfasste Anreden abfragen und in Dropdown einfügen
                var classquerry = new M158_SMPD.MySQLCon();
                DataTable DtClass = classquerry.GetSqlStatement("SELECT `Anrede` FROM `tbl_anrede` WHERE 1");
                foreach (DataRow row in DtClass.Rows)
                {
                    cmxsal.Items.Add(row["Anrede"].ToString());
                }
            }
            catch
            {
                MessageBox.Show("Fehler beim Verbinden mit der Datenbank");
                System.Environment.Exit(1);
            }

            try
            {
                //Orte und Postleitzahlen abfragen und in ihre eigenen Dropdown-Menus einfügen
                var classquerry = new M158_SMPD.MySQLCon();
                DataTable DtClass = classquerry.GetSqlStatement("SELECT `PLZ` FROM `tbl_ort` WHERE 1");
                foreach (DataRow row in DtClass.Rows)
                {
                    cmxplz.Items.Add(row["PLZ"].ToString());
                }
                //Orte mit mehreren Postleitzahlen werden nur einmal als Ort aufgelistet
                DtClass = classquerry.GetSqlStatement("SELECT DISTINCT `Ort` FROM `tbl_ort` WHERE 1");
                foreach (DataRow row in DtClass.Rows)
                {
                    cmxtown.Items.Add(row["Ort"].ToString());
                }
                
            }
            catch
            {
                MessageBox.Show("Fehler beim Verbinden mit der Datenbank");
                System.Environment.Exit(1);
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {
                var classquerry = new M158_SMPD.MySQLCon();
                classquerry.SetSQLStatement("DELETE FROM `tbl_firma` WHERE `F_Name` LIKE '" + cmxcompsrc.Text + "'");

                cmxcompsrc.Items.Clear();
                cmxcompsrc.Text = "";

                //Firmen werden nochmals abgefragt und in Combobox geschrieben, damit die Gelöschte Firma nicht mehr auftaucht
                DataTable DtClass = classquerry.GetSqlStatement("SELECT `F_Name` FROM `tbl_firma` WHERE 1");
                foreach (DataRow row in DtClass.Rows)
                {
                    cmxcompsrc.Items.Add(row["F_Name"].ToString());
                }

                //Alle Text - Comboboxen leeren nachdem die Firma gelöscht wurde
                tbxcomp.Clear();
                cmxsal.Text = "";
                tbxname.Clear();
                tbxprename.Clear();
                tbxstreet.Clear();
                cmxplz.Text = "";
                cmxtown.Text = "";
                tbxcontact.Clear();
                tbxadd.Clear();
                tbxtel.Clear();
                tbxfax.Clear();
                cbxactive.Checked = false;
                cmxcompsrc.Items.Add("Neue Firma");
            }
            catch
            {
                MessageBox.Show("Beim Löschen ist ein Fehler aufgetreten");
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                var classquerry = new M158_SMPD.MySQLCon();
                //Schauen ob es eine Firma ist
                if (cmxcompsrc.Text == "Neue Firma")
                {
                    decimal existent = 0;

                    //Schauen ob es diesen Firmennamen bereits gibt.
                    DataTable DtClass = classquerry.GetSqlStatement("SELECT `F_Name` FROM `tbl_firma` WHERE 1");
                    foreach (DataRow row in DtClass.Rows)
                    {
                        if (Convert.ToString(row["F_Name"]) == tbxcomp.Text)
                        {
                            MessageBox.Show("Diese Firma existiert bereits");
                            existent = 1;
                        }
                    }

                    if (existent == 0)
                    {
                        if (cmxsal.Text != "")
                        {
                            //Anrede in Anredennummer umformen um in Tabelle einzufügen
                            DtClass = classquerry.GetSqlStatement("SELECT `An_Nr` FROM `tbl_anrede` WHERE `Anrede` = '" + cmxsal.Text + "'");
                            foreach (DataRow row in DtClass.Rows)
                            {
                                sal = Convert.ToInt16(row["An_Nr"]);
                            }
                        }
                        else
                        {
                            //Falls keine Anrede ausgwählt ist, soll 0 geschrieben werden
                            sal = 0;
                        }

                        //Postletzahl in OrtNr umwandeln um in Tabelle einzufügen
                        if (cmxplz.Text != "")
                        {
                            DtClass = classquerry.GetSqlStatement("SELECT `Or_Nr` FROM `tbl_ort` WHERE `PLZ` = " + cmxplz.Text);
                            foreach (DataRow row in DtClass.Rows)
                            {
                                plz = Convert.ToInt16(row["Or_Nr"]);
                            }
                        }
                        else
                        {
                            //Falls kein Ort ausgewählt soll 0 geschrieben werden.
                            plz = 0;
                        }

                        //Infos in Datenbank einfügen
                        classquerry.SetSQLStatement("INSERT INTO `tbl_firma` (`Fi_Nr`, `F_Name`, `F_Vorname`, `F_Nachname`, `F_Strasse`, `An_Nr`, `Or_Nr`, `F_Ansprechperson`, `F_Zusatz`, `F_Telefon`, `F_Fax`, `F_Aktiv`) VALUES(NULL, '" + tbxcomp.Text + "', '" + tbxprename.Text + "', '" + tbxname.Text + "', '" + tbxstreet.Text + "', '" + sal + "', '" + plz + "', '" + tbxcontact.Text + "', '" + tbxadd.Text + "', '" + tbxtel.Text + "', '" + tbxfax.Text + "', '1')");
                    }
                }
                else //Wenn keine neue Firma erstellt werden soll
                {
                    //Anrede in Anredennummer umwandeln um einzufügen
                    if (cmxsal.Text != "")
                    {
                        DataTable DtClass = classquerry.GetSqlStatement("SELECT `An_Nr` FROM `tbl_anrede` WHERE `Anrede` = '" + cmxsal.Text + "'");
                        foreach (DataRow row in DtClass.Rows)
                        {
                            sal = Convert.ToInt16(row["An_Nr"]);
                        }
                    }
                    else
                    {
                        //Falls keine Anrede ausgwählt ist, soll 0 geschrieben werden
                        sal = 0;
                    }

                    //Postletzahl in OrtNr umwandeln um in Tabelle einzufügen
                    if (cmxplz.Text != "")
                    {
                        DataTable DtClass = classquerry.GetSqlStatement("SELECT `Or_Nr` FROM `tbl_ort` WHERE `PLZ` = " + cmxplz.Text);
                        foreach (DataRow row in DtClass.Rows)
                        {
                            plz = Convert.ToInt16(row["Or_Nr"]);
                        }
                    }
                    else
                    {
                        //Falls kein Ort ausgewählt soll 0 geschrieben werden.
                        plz = 0;
                    }
                    //Datenstatz in Tabelle erstellen
                    classquerry.SetSQLStatement("UPDATE `tbl_firma` SET `F_Name`= '" + tbxcomp.Text + "', `F_Vorname`= '" + tbxprename.Text + "', `F_Nachname`= '" + tbxname.Text + "',`F_Strasse`= '" + tbxstreet.Text + "', `An_Nr`= '" + sal + "', `Or_Nr`= '" + plz + "',`F_Ansprechperson`= '" + tbxcontact.Text + "',`F_Zusatz`= '" + tbxadd.Text + "',`F_Telefon`= '" + tbxtel.Text + "',`F_Fax`= '" + tbxfax.Text + "' WHERE `F_Name` = '" + cmxcompsrc.Text + "'");
                }
            }
            catch
            {
                MessageBox.Show("Beim Speichern ist ein Fehler aufgetretten, versuchen Sie es erneut oder kontaktieren Sie den Support.");
            }
        }

        private void cmxcompsrc_SelectedIndexChanged(object sender, EventArgs e) //Wenn im Dropdown eine Firma ausgewählt wurde
        {
            try
            {
                string firmasuchen = Convert.ToString(cmxcompsrc.Text);

                //Alle Felder sollen geleert werden
                tbxcomp.Clear();
                cmxsal.Text = "";
                tbxname.Clear();
                tbxprename.Clear();
                tbxstreet.Clear();
                cmxplz.Text = "";
                cmxtown.Text = "";
                tbxcontact.Clear();
                tbxadd.Clear();
                tbxtel.Clear();
                tbxfax.Clear();
                cbxactive.Checked = false;

                if (cmxcompsrc.Text != "Neue Firma")
                {
                    //Falls es keine neue Firma sein soll, werden alle Infos der Firma abgeruffen und in die Felder eingetragen
                    var classquerry = new M158_SMPD.MySQLCon();
                    DataTable DtClass = classquerry.GetSqlStatement("SELECT * FROM `tbl_firma` WHERE `F_Name` LIKE '" + firmasuchen + "'");
                    foreach (DataRow row in DtClass.Rows)
                    {
                        tbxcomp.Text += Convert.ToString(row["F_Name"].ToString());
                        sal = Convert.ToInt16(row["An_Nr"].ToString());
                        tbxname.Text += Convert.ToString(row["F_Nachname"].ToString());
                        tbxprename.Text += Convert.ToString(row["F_Vorname"].ToString());
                        tbxstreet.Text += Convert.ToString(row["F_Strasse"].ToString());
                        plz = Convert.ToInt16(row["Or_Nr"].ToString());
                        tbxcontact.Text += Convert.ToString(row["F_Ansprechperson"].ToString());
                        tbxadd.Text += Convert.ToString(row["F_Zusatz"].ToString());
                        tbxtel.Text += Convert.ToString(row["F_Telefon"].ToString());
                        tbxfax.Text += Convert.ToString(row["F_Fax"].ToString());
                        if (row["F_Aktiv"].ToString() != null)
                        {
                            cbxactive.Checked = true;
                        }
                    }

                    //Umwandlung Anredennummer in Anrede
                    DtClass = classquerry.GetSqlStatement("SELECT `Anrede` FROM `tbl_anrede` WHERE `An_Nr` = " + sal);
                    foreach (DataRow row in DtClass.Rows)
                    {
                        cmxsal.Text = Convert.ToString(row["Anrede"]);
                    }

                    //Umwandlung Ortnummer in Ort und Postleitzahl
                    DtClass = classquerry.GetSqlStatement("SELECT * FROM `tbl_ort` WHERE `Or_Nr` = " + plz);
                    foreach (DataRow row in DtClass.Rows)
                    {
                        cmxplz.Text = Convert.ToString(row["PLZ"]);
                        cmxtown.Text = Convert.ToString(row["Ort"]);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Beim Aufrufen von weiteren Firmen-Infos ist ein Fehler aufgetretten, versuchen Sie es erneut oder kontaktieren Sie den Support.");
            }
        }

        private void cmxplz_SelectedIndexChanged(object sender, EventArgs e) //Wenn eine Postleitzahl ausgwählt ist, soll Postleitzahl in Ort umgewandelt werden
        {
            try
            {
                var classquerry = new M158_SMPD.MySQLCon();
                DataTable DtClass = classquerry.GetSqlStatement("SELECT `Ort` FROM `tbl_ort` WHERE `PLZ` = " + cmxplz.Text);
                foreach (DataRow row in DtClass.Rows)
                {
                    cmxtown.Text = Convert.ToString(row["Ort"]);
                }
            }
            catch
            {
                MessageBox.Show("Diese Postleitzahl konnte nicht aufelösst werden, eventuell wurde sie noch nicht erfasst. \nWählen Sie bitte eine aus dem Dropdown Menu aus.");
            }
        }

        private void cmxtown_SelectedIndexChanged(object sender, EventArgs e) //Wenn ein Ort ausgewählt ist, solle er in eine Postleitzahl umgewandelt werden
        {
            try
            {
                var classquerry = new M158_SMPD.MySQLCon();
                DataTable DtClass = classquerry.GetSqlStatement("SELECT `PLZ` FROM `tbl_ort` WHERE `Ort` = '" + cmxtown.Text + "'");
                foreach (DataRow row in DtClass.Rows)
                {
                    cmxplz.Text = Convert.ToString(row["PLZ"]);
                }
            }
            catch
            {
                MessageBox.Show("Dieser Ort konnte nicht aufelösst werden, eventuell wurde er noch nicht erfasst. \nWählen Sie bitte einen Ort aus dem Dropdown Menu aus.");
            }
        }
    }
}
