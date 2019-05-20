using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace M158_SMPD.Forms.Grp3
{
    public partial class FrmCompData : Form
    {
        //public string connection = "Server=localhost;Database=notenprogramm;Uid=root;Pwd=;";
        public MySqlConnection connector = new MySqlConnection();
        public int sal;
        public int plz;

        public FrmCompData()
        {
            InitializeComponent();
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
            cmxcompsrc.Items.Add("Neue Firma");

            try
            {
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
                var classquerry = new M158_SMPD.MySQLCon();
                DataTable DtClass = classquerry.GetSqlStatement("SELECT `PLZ`, `Ort` FROM `tbl_ort` WHERE 1");
                foreach (DataRow row in DtClass.Rows)
                {
                    cmxtown.Items.Add(row["Ort"].ToString());
                    cmxplz.Items.Add(row["PLZ"].ToString());
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

                DataTable DtClass = classquerry.GetSqlStatement("SELECT `F_Name` FROM `tbl_firma` WHERE 1");
                foreach (DataRow row in DtClass.Rows)
                {
                    cmxcompsrc.Items.Add(row["F_Name"].ToString());
                }

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
                connector.Close();
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
                if (cmxcompsrc.Text == "Neue Firma")
                {
                    decimal existent = 0;

                    var classquerry = new M158_SMPD.MySQLCon();
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
                        DtClass = classquerry.GetSqlStatement("SELECT `An_Nr` FROM `tbl_anrede` WHERE `Anrede` = '" + cmxsal.Text + "'");
                        foreach (DataRow row in DtClass.Rows)
                        {
                            sal = Convert.ToInt16(row["An_Nr"]);
                        }

                        DtClass = classquerry.GetSqlStatement("SELECT `Or_Nr` FROM `tbl_ort` WHERE `PLZ` = " + cmxplz.Text);
                        foreach (DataRow row in DtClass.Rows)
                        {
                            plz = Convert.ToInt16(row["Or_Nr"]);
                        }

                        classquerry.SetSQLStatement("INSERT INTO `tbl_firma` (`Fi_Nr`, `F_Name`, `F_Vorname`, `F_Nachname`, `F_Strasse`, `An_Nr`, `Or_Nr`, `F_Ansprechperson`, `F_Zusatz`, `F_Telefon`, `F_Fax`, `F_Aktiv`) VALUES(NULL, '" + tbxcomp.Text + "', '" + tbxprename.Text + "', '" + tbxname.Text + "', '" + tbxstreet.Text + "', '" + sal + "', '" + plz + "', '" + tbxcontact.Text + "', '" + tbxadd.Text + "', '" + tbxtel.Text + "', '" + tbxfax.Text + "', '1')");
                    }
                }
                else
                {
                    var classquerry = new M158_SMPD.MySQLCon();
                    DataTable DtClass = classquerry.GetSqlStatement("SELECT `An_Nr` FROM `tbl_anrede` WHERE `Anrede` = '" + cmxsal.Text + "'");
                    foreach (DataRow row in DtClass.Rows)
                    {
                        sal = Convert.ToInt16(row["An_Nr"]);
                    }

                    DtClass = classquerry.GetSqlStatement("SELECT `Or_Nr` FROM `tbl_ort` WHERE `PLZ` = " + cmxplz.Text);
                    foreach (DataRow row in DtClass.Rows)
                    {
                        plz = Convert.ToInt16(row["Or_Nr"]);
                    }

                    classquerry.SetSQLStatement("UPDATE `tbl_firma` SET `F_Name`= '" + tbxcomp.Text + "', `F_Vorname`= '" + tbxprename.Text + "', `F_Nachname`= '" + tbxname.Text + "',`F_Strasse`= '" + tbxstreet.Text + "', `An_Nr`= '" + sal + "', `Or_Nr`= '" + plz + "',`F_Ansprechperson`= '" + tbxcontact.Text + "',`F_Zusatz`= '" + tbxadd.Text + "',`F_Telefon`= '" + tbxtel.Text + "',`F_Fax`= '" + tbxfax.Text + "' WHERE `F_Name` = '" + cmxcompsrc.Text + "'");
                }
            }
            catch
            {
                MessageBox.Show("Beim Speichern ist ein Fehler aufgetretten, versuchen Sie es erneut oder kontaktieren Sie den Support.");
            }
        }

        private void cmxcompsrc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string firmasuchen = Convert.ToString(cmxcompsrc.Text);

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

                    DtClass = classquerry.GetSqlStatement("SELECT `Anrede` FROM `tbl_anrede` WHERE `An_Nr` = " + sal);
                    foreach (DataRow row in DtClass.Rows)
                    {
                        cmxsal.Text = Convert.ToString(row["Anrede"]);
                    }

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

        private void cmxplz_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var classquerry = new M158_SMPD.MySQLCon();
                DataTable DtClass = classquerry.GetSqlStatement("SELECT `Ort` FROM `tbl_ort` WHERE `PLZ` = " + plz);
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

        private void cmxtown_SelectedIndexChanged(object sender, EventArgs e)
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
