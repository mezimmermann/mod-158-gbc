using System;
using System.Data;
using System.Windows.Forms;

namespace M158_SMPD.Forms.Grp3
{
    public partial class FrmStudMgmt : Form
    { 
        public string comp;
        public string sal;
        public string place;
        public string clas;
        public string birth;
        public int plz;
        public string time;

        public FrmStudMgmt()
        {
            try
            {
                InitializeComponent();

                cmxapsrc.Items.Add("Neuer Schüler"); //Im Dropdown soll daer Punkt neuer Schüler erstellt werden um neue Schüller zu erstellen

                var classquerry = new M158_SMPD.MySQLCon();

                //Abfragen aller Anreden und einfügen in Combobox
                DataTable DtClass = classquerry.GetSqlStatement("SELECT `Anrede` FROM `tbl_anrede` WHERE 1");
                foreach (DataRow row in DtClass.Rows)
                {
                    cmxsal.Items.Add(row["Anrede"].ToString());
                }
                //Abfragen aller Firmen und einfügen in Combobox
                DtClass = classquerry.GetSqlStatement("SELECT `F_Name` FROM `tbl_firma` WHERE 1");
                foreach (DataRow row in DtClass.Rows)
                {
                    cmxcomp.Items.Add(row["F_Name"].ToString());
                }
                //Abfragen aller Klassen und einfügen in Combobox
                DtClass = classquerry.GetSqlStatement("SELECT `Klasse` FROM `tbl_klasse` WHERE 1");
                foreach (DataRow row in DtClass.Rows)
                {
                    cmxclass.Items.Add(row["Klasse"].ToString());
                }
                //Abfragen aller Lehrzeiten und einfügen in Combobox
                DtClass = classquerry.GetSqlStatement("SELECT * FROM `tbl_lehrzeiten` WHERE 1");
                foreach (DataRow row in DtClass.Rows)
                {
                    cmxtime.Items.Add(Convert.ToString(row["Lj_Von"] + " - " + row["Lj_Bis"]));
                }
                //Abfragen aller Postleitzahlen und einfügen in Combobox
                DtClass = classquerry.GetSqlStatement("SELECT `PLZ` FROM `tbl_ort` WHERE 1");
                foreach (DataRow row in DtClass.Rows)
                {
                    cmxplz.Items.Add(row["PLZ"].ToString());
                }
                //Abfragen aller Orte und einfügen in Combobox
                DtClass = classquerry.GetSqlStatement("SELECT DISTINCT `Ort` FROM `tbl_ort` WHERE 1");
                foreach (DataRow row in DtClass.Rows)
                {
                    cmxcity.Items.Add(row["Ort"].ToString());
                }
                
            }
            catch
            {
                MessageBox.Show("Beim Starten dieses Fensters ist ein Problem aufgetretten \nVersuchen Sie es erneut oder kontaktieren Sie den Support");
                Application.Exit();
            }
            getpeople();
        }

        public void getpeople()
        {
            try
            {
                //Schüler abfragen und mit eigener Formatierung in Combobox einfügen
                var classquerry = new M158_SMPD.MySQLCon();
                DataTable DtClass = classquerry.GetSqlStatement("SELECT `Ll_Nr`, `Vorname`, `Name` FROM `tbl_lehrling` WHERE 1 ORDER BY `Ll_Nr` ASC");
                foreach (DataRow row in DtClass.Rows)
                {
                    cmxapsrc.Items.Add("(" + row["Ll_Nr"].ToString() + ") " + row["Vorname"].ToString() + " " + row["Name"].ToString());
                }
            }
            catch
            {
                MessageBox.Show("Beim Abfragen der Lehrlinge ist ein Fehler aufgetretten, versuchen Sie es erneut");
            }
        }

        public void getdata()
        {
            try
            {
                var classquerry = new M158_SMPD.MySQLCon();
                DataTable DtClass = classquerry.GetSqlStatement("SELECT * FROM `tbl_lehrling` WHERE `Ll_Nr` = " + tbxap.Text);
                //Alle Felder leeren
                cmxcity.Text = "";
                cmxclass.Text = "";
                cmxcomp.Text = "";
                cmxplz.Text = "";
                cmxsal.Text = "";
                tbxadd.Text = "";
                tbxap.Text = "";
                tbxname.Text = "";
                tbxpre.Text = "";
                tbxstr.Text = "";
                tbxtel.Text = "";
                dtrbirth.Value = Convert.ToDateTime(DateTime.Now);
                //Daten zum ausgewählten Lehrling abfragen
                foreach (DataRow row in DtClass.Rows)
                {
                    tbxap.Text = Convert.ToString(row["Ll_Nr"]);
                    comp = Convert.ToString(row["Fi_Nr"]);
                    sal = Convert.ToString(row["An_Nr"]);
                    tbxname.Text = Convert.ToString(row["Name"]);
                    tbxpre.Text = Convert.ToString(row["Vorname"]);
                    tbxstr.Text = Convert.ToString(row["Strasse"]);
                    place = Convert.ToString(row["Or_Nr"]);
                    tbxtel.Text = Convert.ToString(row["Telefon"]);
                    tbxadd.Text = Convert.ToString(row["Zusatz"]);
                    time = Convert.ToString(row["Lj_Nr"]);
                    if (Convert.ToString(row["GebDat"]) != "")
                    {
                        dtrbirth.Value = Convert.ToDateTime(row["GebDat"]);
                    }
                    clas = Convert.ToString(row["Kl_Nr"]);
                }
                //Firmennummer in Firma umwandeln
                DtClass = classquerry.GetSqlStatement("SELECT `F_Name` FROM `tbl_firma` WHERE `Fi_Nr` = " + comp);
                foreach (DataRow row in DtClass.Rows)
                {
                    cmxcomp.Text = Convert.ToString(row["F_Name"]);
                }
                //Anredennummer in Anrede umwandeln
                DtClass = classquerry.GetSqlStatement("SELECT `Anrede` FROM `tbl_anrede` WHERE `An_Nr` =  " + sal);
                foreach (DataRow row in DtClass.Rows)
                {
                    cmxsal.Text = Convert.ToString(row["Anrede"]);
                }
                //Ortnr in PLZ und Ort umwandeln
                DtClass = classquerry.GetSqlStatement("SELECT `PLZ`,`Ort` FROM `tbl_ort` WHERE `Or_Nr` = " + place);
                foreach (DataRow row in DtClass.Rows)
                {
                    cmxplz.Text = Convert.ToString(row["PLZ"]);
                    cmxcity.Text = Convert.ToString(row["Ort"]);
                }
                //Lehrzeit abfragen und einfügen
                if (time != "0")
                {
                    DtClass = classquerry.GetSqlStatement("SELECT * FROM `tbl_lehrzeiten` WHERE `Lj_Nr` = " + time);
                    foreach (DataRow row in DtClass.Rows)
                    {
                        cmxtime.Text = Convert.ToString(row["Lj_Von"] + " - " + row["Lj_Bis"]);
                    }
                }
                else
                {
                    cmxtime.Text = "";
                }
                //Klassennummer in Klasse umwandeln und einfügen
                DtClass = classquerry.GetSqlStatement("SELECT `Klasse` FROM `tbl_klasse` WHERE `Kl_Nr` = " + clas);
                foreach (DataRow row in DtClass.Rows)
                {
                    cmxclass.Text = Convert.ToString(row["Klasse"]);
                }
            }
            catch
            {
                MessageBox.Show("Die Informationen des Schülers konnten nicht geladen werden, versuchen Sie es erneut.");
            }
        }

        public void getexdata(string Ll_Nr) //Das selbe wie getdata einfach für externe abfragen
        {
            this.Show();
            try
            {
                var classquerry = new M158_SMPD.MySQLCon();
                DataTable DtClass = classquerry.GetSqlStatement("SELECT * FROM `tbl_lehrling` WHERE `Ll_Nr` = " + Ll_Nr);
                //Alle Felder leeren
                cmxcity.Text = "";
                cmxclass.Text = "";
                cmxcomp.Text = "";
                cmxplz.Text = "";
                cmxsal.Text = "";
                tbxadd.Text = "";
                tbxap.Text = "";
                tbxname.Text = "";
                tbxpre.Text = "";
                tbxstr.Text = "";
                tbxtel.Text = "";
                //Daten zum ausgewählten Lehrling abfragen
                dtrbirth.Value = Convert.ToDateTime(DateTime.Now);
                foreach (DataRow row in DtClass.Rows)
                {
                    MessageBox.Show(Convert.ToString(row["Vorname"]));
                    tbxap.Text = Convert.ToString(row["Ll_Nr"]);
                    comp = Convert.ToString(row["Fi_Nr"]);
                    sal = Convert.ToString(row["An_Nr"]);
                    tbxname.Text = Convert.ToString(row["Name"]);
                    tbxpre.Text = Convert.ToString(row["Vorname"]);
                    tbxstr.Text = Convert.ToString(row["Strasse"]);
                    place = Convert.ToString(row["Or_Nr"]);
                    tbxtel.Text = Convert.ToString(row["Telefon"]);
                    tbxadd.Text = Convert.ToString(row["Zusatz"]);
                    time = Convert.ToString(row["Lj_Nr"]);
                    if (Convert.ToString(row["GebDat"]) != "")
                    {
                        dtrbirth.Value = Convert.ToDateTime(row["GebDat"]);
                    }
                    clas = Convert.ToString(row["Kl_Nr"]);
                }
                //Firmennummer in Firma umwandeln
                DtClass = classquerry.GetSqlStatement("SELECT `F_Name` FROM `tbl_firma` WHERE `Fi_Nr` = " + comp);
                foreach (DataRow row in DtClass.Rows)
                {
                    cmxcomp.Text = Convert.ToString(row["F_Name"]);
                }
                //Anredennummer in Anrede umwandeln
                DtClass = classquerry.GetSqlStatement("SELECT `Anrede` FROM `tbl_anrede` WHERE `An_Nr` =  " + sal);
                foreach (DataRow row in DtClass.Rows)
                {
                    cmxsal.Text = Convert.ToString(row["Anrede"]);
                }
                //Ortnr in PLZ und Ort umwandeln
                DtClass = classquerry.GetSqlStatement("SELECT `PLZ`,`Ort` FROM `tbl_ort` WHERE `Or_Nr` = " + place);
                foreach (DataRow row in DtClass.Rows)
                {
                    cmxplz.Text = Convert.ToString(row["PLZ"]);
                    cmxcity.Text = Convert.ToString(row["Ort"]);
                }
                //Lehrzeit abfragen und einfügen
                if (time != "0")
                {
                    DtClass = classquerry.GetSqlStatement("SELECT * FROM `tbl_lehrzeiten` WHERE `Lj_Nr` = " + time);
                    foreach (DataRow row in DtClass.Rows)
                    {
                        cmxtime.Text = Convert.ToString(row["Lj_Von"] + " - " + row["Lj_Bis"]);
                    }
                }
                else
                {
                    cmxtime.Text = "";
                }
                //Klassennummer in Klasse umwandeln und einfügen
                DtClass = classquerry.GetSqlStatement("SELECT `Klasse` FROM `tbl_klasse` WHERE `Kl_Nr` = " + clas);
                foreach (DataRow row in DtClass.Rows)
                {
                    cmxclass.Text = Convert.ToString(row["Klasse"]);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Die Informationen des Schülers konnten nicht geladen werden, versuchen Sie es erneut.");
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmxapsrc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                if (cmxapsrc.Text != "Neuer Schüler")
                {
                    //Benuterdefinierte Formatierung zu Schüllernummer aufheben
                    tbxap.Text = "";
                    string nr = cmxapsrc.Text;
                    int stop = 0;
                    int i = 1;
                    string item;
                    while (stop == 0)
                    {
                        item = "";
                        item = nr.Substring(i, 1); //Einzelne Zeichen abfragen
                        if (item == ")") //Die länge der Nummer anschauen bis die schliessende Klammer kommt
                        {
                            stop = 1;
                        }
                        else
                        {
                            tbxap.Text += item;
                            i++;
                        }
                    }
                    getdata();
                }

                else
                {
                    //Alle Felder leeren
                    cmxcity.Text = "";
                    cmxclass.Text = "";
                    cmxcomp.Text = "";
                    cmxplz.Text = "";
                    cmxsal.Text = "";
                    tbxadd.Text = "";
                    tbxap.Text = "";
                    tbxname.Text = "";
                    tbxpre.Text = "";
                    tbxstr.Text = "";
                    tbxtel.Text = "";
                    dtrbirth.Value = Convert.ToDateTime(DateTime.Now);
                }
            }
            catch
            {
                MessageBox.Show("Fehler beim Auswählen des Schülers, versuchen Sie es erneut.");
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmxcomp.Text != "")
                {
                    //Firma in Firmennummer umwandeln
                    var classquerry = new M158_SMPD.MySQLCon();
                    DataTable DtClass = classquerry.GetSqlStatement("SELECT `Fi_Nr` FROM `tbl_firma` WHERE `F_Name` = '" + cmxcomp.Text + "'");
                    foreach (DataRow row in DtClass.Rows)
                    {
                        comp = "'" + Convert.ToString(row["Fi_Nr"]) + "'";
                    }
                }
                else if (cmxcomp.Text == "")
                {
                    comp = "'0'";
                }
                
                if (cmxsal.Text != "")
                {
                    //Anrede in Anredennr umwandeln
                    var classquerry = new M158_SMPD.MySQLCon();
                    DataTable DtClass = classquerry.GetSqlStatement("SELECT `An_Nr` FROM `tbl_anrede` WHERE `Anrede` = '" + cmxsal.Text + "'");
                    foreach (DataRow row in DtClass.Rows)
                    {
                        sal = "'" + Convert.ToString(row["An_Nr"]) + "'";
                    }
                }
                else if (cmxsal.Text == "")
                {
                    //Falls nichts ausgewählt soll 0 geschrieben werden
                    sal = "'0'";
                }

                if (cmxplz.Text != "")
                {
                    //PLZ in Ortnr umwandeln
                    var classquerry = new M158_SMPD.MySQLCon();
                    DataTable DtClass = classquerry.GetSqlStatement("SELECT `Or_Nr` FROM `tbl_ort` WHERE `PLZ` = " + cmxplz.Text);
                    foreach (DataRow row in DtClass.Rows)
                    {
                        place = "'" + Convert.ToString(row["Or_Nr"]) + "'";
                    }
                }
                else if (cmxplz.Text == "")
                {
                    //Falls nichts ausgewählt soll 0 geschrieben werden
                    place = "'0'";
                }

                if (cmxclass.Text != "")
                {
                    //Klasse in Klassenr umwandeln
                    var classquerry = new M158_SMPD.MySQLCon();
                    DataTable DtClass = classquerry.GetSqlStatement("SELECT `Kl_Nr` FROM `tbl_klasse` WHERE `Klasse` = '" + cmxclass.Text + "'");
                    foreach (DataRow row in DtClass.Rows)
                    {
                        clas = "'" + Convert.ToString(row["Kl_Nr"]) + "'";
                    }
                }
                else if (cmxclass.Text == "")
                {
                    //Falls nichts ausgewählt soll 0 geschrieben werden
                    clas = "'0'";
                }

                if (cmxtime.Text != "")
                {
                    //Lerhzeit in Lehrzeitnummer unwandeln
                    string item = cmxtime.Text.ToString();
                    time = item.Substring(0, 4);
                    item = cmxtime.Text.ToString();
                    string timeend = item.Substring(7, 4);

                    var classquerry = new M158_SMPD.MySQLCon();
                    DataTable DtClass = classquerry.GetSqlStatement("SELECT * FROM `tbl_lehrzeiten` WHERE `Lj_Von` = " + time + " AND `Lj_Bis` = " + timeend);
                    foreach (DataRow row in DtClass.Rows)
                    {
                        time = "'" + Convert.ToString(row["Lj_Nr"]) + "'";
                    }
                }
                else if (cmxtime.Text == "")
                {
                    //Falls nichts ausgewählt soll 0 geschrieben werden
                    time = "'0'";
                }


                if (cmxapsrc.Text == "Neuer Schüler")
                {
                    //Neuer Datensatz erstellen
                    var classquerry = new M158_SMPD.MySQLCon();
                    classquerry.SetSQLStatement("INSERT INTO `tbl_lehrling` (`Ll_Nr`, `Fi_Nr`, `An_Nr`, `Name`, `Vorname`, `Strasse`, `Or_Nr`, `Telefon`, `Zusatz`, `weibl`, `GebDat`, `Lj_Nr`, `Aktiv`, `Kl_Nr`) VALUES(NULL, " + comp + ", " + sal + ", '" + tbxname.Text + "', '" + tbxpre.Text + "', '" + tbxstr.Text + "', " + place + ", '" + tbxtel.Text + "', '" + tbxadd.Text + "', '0', '" + dtrbirth.Text + "', " + time + ", '1', " + clas + ")");
                    MessageBox.Show(tbxpre.Text + " " + tbxname.Text + " wurde erstellt.");
                }
                else
                {
                    //Datensatz aktuallisieren
                    var classquerry = new M158_SMPD.MySQLCon();
                    classquerry.SetSQLStatement("UPDATE `tbl_lehrling` SET `Fi_Nr` = " + comp + ", `An_Nr` = " + sal + ", `Name` = '" + tbxname.Text + "', `Vorname` = '" + tbxpre.Text + "', `Strasse` = '" + tbxstr.Text + "', `Or_Nr` = " + place + ", `Telefon` = '" + tbxtel.Text + "', `Zusatz` = '" + tbxadd.Text + "', `GebDat` = '" + dtrbirth.Text + "', `Kl_Nr` = " + clas + ", `Lj_Nr` = " + time + " WHERE `tbl_lehrling`.`Ll_Nr` = " + tbxap.Text);
                    MessageBox.Show(tbxpre.Text + " " + tbxname.Text + " wurde gespeichert.");
                }
            }
            catch
            {
                MessageBox.Show("Beim Speichern ist ein Fehler aufgetretten, versuchen Sie es erneut oder kontaktieren Sie den Support");
            }
            getpeople();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {
                var classquerry = new M158_SMPD.MySQLCon();
                //User löschen
                classquerry.SetSQLStatement("DELETE FROM `tbl_lehrling` WHERE `Ll_Nr` = " + tbxap.Text);
                MessageBox.Show("(" + tbxap.Text + ") " + tbxpre.Text + " " + tbxname.Text + " wurde gelöscht."); //Anzeigen dass der User gelöscht wurde
                //Alle Felder Leeren
                cmxapsrc.Text = "";
                cmxcity.Text = "";
                cmxclass.Text = "";
                cmxcomp.Text = "";
                cmxplz.Text = "";
                cmxsal.Text = "";
                tbxadd.Text = "";
                tbxap.Text = "";
                tbxname.Text = "";
                tbxpre.Text = "";
                tbxstr.Text = "";
                tbxtel.Text = "";
                dtrbirth.Value = Convert.ToDateTime(DateTime.Now);
            }
            catch
            {
                MessageBox.Show("Fehler beim Löschen des Datensatzes, versuchen Sie es erneut oder kontaktieren Sie den Support");
            }
        }

        private void cmxplz_SelectedIndexChanged(object sender, EventArgs e) //Falls die Postleitzahl geändert wurde sollte der Ort auch geändert werden
        {
            try
            {
                var classquerry = new M158_SMPD.MySQLCon();
                DataTable DtClass = classquerry.GetSqlStatement("SELECT `Ort` FROM `tbl_ort` WHERE `PLZ` = " + cmxplz.Text);
                foreach (DataRow row in DtClass.Rows)
                {
                    cmxcity.Text = Convert.ToString(row["Ort"]);
                }
            }
            catch
            {
                MessageBox.Show("Diese Post-Leit-Zahl konnte nicht zu einer Stadt aufgelöst werden, eventuell wurde diese noch nicht erfasst. \nWählen Sie bitte eine aus dem Dropdown-Menu aus");
            }
        }

        private void cmxcity_SelectedIndexChanged_1(object sender, EventArgs e)//Falls der Ort geändert wurde sollte die Postzleitzahl auch geändert werden
        {
            try
            {
                var classquerry = new M158_SMPD.MySQLCon();
                DataTable DtClass = classquerry.GetSqlStatement("SELECT `PLZ` FROM `tbl_ort` WHERE `Ort` = '" + cmxcity.Text + "'");
                foreach (DataRow row in DtClass.Rows)
                {
                    cmxplz.Text = Convert.ToString(row["PLZ"]);
                }
            }
            catch
            {
                MessageBox.Show("Die Stadt konnte nicht zu einer Postleitzahl aufgelöst, eventuell wurde diese noch nicht erfasst. \nWählen Sie bitte eine aus dem Dropdown-Menu aus");
            }
        }
    }
}
