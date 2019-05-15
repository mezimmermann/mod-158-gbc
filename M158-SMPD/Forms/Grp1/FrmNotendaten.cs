using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace M158_SMPD.Forms.Grp1
{
    public partial class FrmNotendaten : Form
    {
        public FrmNotendaten()
        {
            InitializeComponent();
        }

        // alle Daten von tbl_Klasse in einen DataTable speichern und in ein Dictionary
        private void FrmNotendaten_Load(object sender, EventArgs e)
        {
            try
            {
                MySQLCon conn = new MySQLCon();
                DataTable dtbKlasse = conn.GetSqlStatement("SELECT * FROM tbl_klasse");
                var choices_kl = new Dictionary<string, int>();

                foreach (DataRow row_kl in dtbKlasse.Rows)
                {
                    choices_kl.Add(row_kl[1].ToString(), int.Parse(row_kl[0].ToString()));
                }
                LbxBeruf.DataSource = new BindingSource(choices_kl, null);
                LbxBeruf.DisplayMember = "Key";
                LbxBeruf.ValueMember = "Value";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }           
        }

        // Berufe auslesen und die ListBox Beruf anpassen wenn eine Klasse ausgewählt wurde
        private void LbxBeruf_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var KvpClasspair = (KeyValuePair<string, int>)LbxBeruf.SelectedItem;
                string StrClass = KvpClasspair.Value.ToString();

                MySQLCon conn = new MySQLCon();
                DataTable dtbSemester = conn.GetSqlStatement("SELECT tbl_semester.Se_Nr ,tbl_semester.Semester FROM tbl_semester JOIN tbl_fae_kla_sem ON tbl_fae_kla_sem.Se_Nr = tbl_semester.Se_Nr WHERE tbl_fae_kla_sem.Kl_Nr =" + StrClass + " GROUP BY Se_Nr;");
                var choices_se = new Dictionary<string, int>();

                foreach (DataRow row_se in dtbSemester.Rows)
                {
                    choices_se.Add(row_se[1].ToString(), int.Parse(row_se[0].ToString()));

                }
                LbxSemester.DataSource = new BindingSource(choices_se, null);
                LbxSemester.DisplayMember = "Key";
                LbxSemester.ValueMember = "Value";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        //  Semester auslesen und die ListBox Semester anpassen wenn ein Beruf ausgewählt wurde
        private void LbxSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var KvpSubject = (KeyValuePair<string, int>)LbxSemester.SelectedItem;
                string StrSemester = KvpSubject.Value.ToString();
                var KvpClasspair = (KeyValuePair<string, int>)LbxBeruf.SelectedItem;
                string StrClass = KvpClasspair.Value.ToString();

                MySQLCon conn = new MySQLCon();
                DataTable dtbFach = conn.GetSqlStatement("select tbl_faecher.Fach, tbl_fae_kla_sem.Fae_Nr from tbl_fae_kla_sem join tbl_semester on tbl_semester.Se_Nr = tbl_fae_kla_sem.Se_Nr join tbl_faecher on tbl_faecher.Fae_Nr = tbl_fae_kla_sem.Fae_Nr where tbl_fae_kla_sem.Kl_Nr = " + StrClass + " and tbl_fae_kla_sem.Se_Nr = " + StrSemester + ";");
                var choices_fa = new Dictionary<string, int>();

                foreach (DataRow row_fa in dtbFach.Rows)
                {
                    choices_fa.Add(row_fa[0].ToString(), int.Parse(row_fa[1].ToString()));
                }
                LbxFach.DataSource = new BindingSource(choices_fa, null);
                LbxFach.DisplayMember = "Key";
                LbxFach.ValueMember = "Value";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void LbxFach_SelectedIndexChanged(object sender, EventArgs e)
        {
            IndexChangedFach();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            printDialog.UseEXDialog = true;
            //Get the document
            if (DialogResult.OK == printDialog.ShowDialog())
            {
                printDocument1.DocumentName = "Test Page Print";
                printDocument1.Print();
            }
        }

        private void DgvGrade_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DgvGrade.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "")
                {
                    string StrSqlstatement = "UPDATE tbl_noten SET "+ DgvGrade.Columns[e.ColumnIndex].Name + "=" + DgvGrade.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() + " WHERE No_Nr=" + DgvGrade.Rows[e.RowIndex].Cells[11].Value.ToString();

                    MySQLCon conn = new MySQLCon();
                    conn.SetSQLStatement(StrSqlstatement);

                    IndexChangedFach();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        //  Fach auslesen und die ListBox Fach anpassen wenn ein Semester ausgewählt wurde
        private void IndexChangedFach()
        {
            try
            {
                var KvpSubject = (KeyValuePair<string, int>)LbxSemester.SelectedItem;
                string StrSemester = KvpSubject.Value.ToString();
                var KvpFach = (KeyValuePair<string, int>)LbxFach.SelectedItem;
                string StrFach = KvpFach.Value.ToString();
                DataTable DtbAverage = new DataTable(); // Durchschnitt der einzelnen Personen
                DtbAverage.Columns.Add("Durchschnitt");
                DataTable DtbAverages = new DataTable(); // Klassendurchschnitt

                double DoubleCells;
                double DoubleDurchschnitt1 = 0;
                double DoubleGewichtung1 = 0;
                double DoubleDurchschnitt2 = 0;
                double DoubleGewichtung2 = 0;
                double DoubleDurchschnitt3 = 0;
                double DoubleGewichtung3 = 0;
                double DoubleDurchschnitt4 = 0;
                double DoubleGewichtung4 = 0;
                double DoubleDurchschnitt5 = 0;
                double DoubleGewichtung5 = 0;
                double DoubleGewichtung = 0;
                double DoubleAverage = 0;
                double DoubleAverages = 0;

                //Auslesen der Daten
                MySQLCon conn = new MySQLCon();
                DataTable DtbGrade = conn.GetSqlStatement("select concat(Name, ' ', Vorname) AS Name, Note_1, GewN1, Note_2, GewN2, Note_3, GewN3, Note_4, GewN4, Note_5, GewN5, No_Nr from tbl_noten join tbl_lehrling on tbl_noten.Ll_Nr = tbl_lehrling.Ll_Nr where Fae_Nr = " + StrFach + " and Se_Nr = " + StrSemester + ";");
                DataTable DtbCountCells = conn.GetSqlStatement("select Count(*) from tbl_noten where Fae_Nr = " + StrFach + " and Se_Nr = " + StrSemester + ";");
                DoubleCells = Convert.ToInt16(DtbCountCells.Rows[0][0].ToString());

                // Überprüfung der Daten auf Null Werte und Fehlerbehandlung fehlender Werte
                for (int i = 0; DoubleCells > i; i++)
                {
                    if (DtbGrade.Rows[i][1] is DBNull)
                    {
                        DoubleDurchschnitt1 = 0;
                        DoubleGewichtung1 = 0;
                    }
                    if ((DtbGrade.Rows[i][2] is DBNull) && (!(DtbGrade.Rows[i][1] is DBNull)))
                    {
                        DoubleGewichtung1 = 1;
                        DoubleDurchschnitt1 = Convert.ToInt16(DtbGrade.Rows[i][1]) * DoubleGewichtung1;
                    }
                    else if ((!(DtbGrade.Rows[i][2] is DBNull)) && (!(DtbGrade.Rows[i][1] is DBNull)))
                    {
                        DoubleGewichtung1 = Convert.ToInt16(DtbGrade.Rows[i][2]);
                        DoubleDurchschnitt1 = Convert.ToInt16(DtbGrade.Rows[i][1]) * Convert.ToInt16(DtbGrade.Rows[i][2]);
                    }
                    else
                    {
                        DoubleDurchschnitt1 = 0;
                    }
                    if (DtbGrade.Rows[i][3] is DBNull)
                    {
                        DoubleDurchschnitt2 = 0;
                        DoubleGewichtung2 = 0;
                    }
                    if ((DtbGrade.Rows[i][4] is DBNull) && (!(DtbGrade.Rows[i][3] is DBNull)))
                    {
                        DoubleGewichtung2 = 1;
                        DoubleDurchschnitt2 = Convert.ToInt16(DtbGrade.Rows[i][3]) * DoubleGewichtung2;
                    }
                    else if ((!(DtbGrade.Rows[i][4] is DBNull)) && (!(DtbGrade.Rows[i][3] is DBNull)))
                    {
                        DoubleGewichtung2 = Convert.ToInt16(DtbGrade.Rows[i][4]);
                        DoubleDurchschnitt2 = Convert.ToInt16(DtbGrade.Rows[i][3]) * Convert.ToInt16(DtbGrade.Rows[i][4]);
                    }
                    else
                    {
                        DoubleDurchschnitt2 = 0;
                    }
                    if (DtbGrade.Rows[i][5] is DBNull)
                    {
                        DoubleDurchschnitt3 = 0;
                        DoubleGewichtung3 = 0;
                    }
                    if ((DtbGrade.Rows[i][6] is DBNull) && (!(DtbGrade.Rows[i][5] is DBNull)))
                    {
                        DoubleGewichtung3 = 1;
                        DoubleDurchschnitt3 = Convert.ToInt16(DtbGrade.Rows[i][5]) * DoubleGewichtung3;
                    }
                    else if ((!(DtbGrade.Rows[i][5] is DBNull)) && (!(DtbGrade.Rows[i][5] is DBNull)))
                    {
                        DoubleGewichtung3 = Convert.ToInt16(DtbGrade.Rows[i][6]);
                        DoubleDurchschnitt3 = Convert.ToInt16(DtbGrade.Rows[i][5]) * Convert.ToInt16(DtbGrade.Rows[i][6]);
                    }
                    else
                    {
                        DoubleDurchschnitt3 = 0;
                    }
                    if (DtbGrade.Rows[i][7] is DBNull)
                    {
                        DoubleDurchschnitt4 = 0;
                        DoubleGewichtung4 = 0;
                    }
                    if ((DtbGrade.Rows[i][8] is DBNull) && (!(DtbGrade.Rows[i][7] is DBNull)))
                    {
                        DoubleGewichtung4 = 1;
                        DoubleDurchschnitt4 = Convert.ToInt16(DtbGrade.Rows[i][7]) * DoubleGewichtung4;
                    }
                    else if ((!(DtbGrade.Rows[i][7] is DBNull)) && (!(DtbGrade.Rows[i][7] is DBNull)))
                    {
                        DoubleGewichtung4 = Convert.ToInt16(DtbGrade.Rows[i][8]);
                        DoubleDurchschnitt4 = Convert.ToInt16(DtbGrade.Rows[i][7]) * Convert.ToInt16(DtbGrade.Rows[i][8]);
                    }
                    else
                    {
                        DoubleDurchschnitt4 = 0;
                    }
                    if (DtbGrade.Rows[i][9] is DBNull)
                    {
                        DoubleDurchschnitt5 = 0;
                        DoubleGewichtung5 = 0;
                    }
                    if ((DtbGrade.Rows[i][10] is DBNull) && (!(DtbGrade.Rows[i][9] is DBNull)))
                    {
                        DoubleGewichtung5 = 1;
                        DoubleDurchschnitt5 = Convert.ToInt16(DtbGrade.Rows[i][9]) * DoubleGewichtung5;
                    }
                    else if ((!(DtbGrade.Rows[i][9] is DBNull)) && (!(DtbGrade.Rows[i][9] is DBNull)))
                    {
                        DoubleGewichtung5 = Convert.ToInt16(DtbGrade.Rows[i][10]);
                        DoubleDurchschnitt5 = Convert.ToInt16(DtbGrade.Rows[i][9]) * Convert.ToInt16(DtbGrade.Rows[i][10]);
                    }
                    else
                    {
                        DoubleDurchschnitt5 = 0;
                    }

                    //Berechnung Durchschnitt
                    DoubleGewichtung = DoubleGewichtung1 + DoubleGewichtung2 + DoubleGewichtung3 + DoubleGewichtung4 + DoubleGewichtung5;
                    DoubleAverage = (DoubleDurchschnitt1 + DoubleDurchschnitt2 + DoubleDurchschnitt3 + DoubleDurchschnitt4 + DoubleDurchschnitt5) / DoubleGewichtung;
                    DtbAverage.Rows.Add(DoubleAverage.ToString("0.00"));
                    DoubleAverages += DoubleAverage;
                }
                DtbAverages.Columns.Add("Klassendurchschnitt");
                DtbAverages = conn.GetSqlStatement("select ROUND(AVG(Note_1), 2) AS Note1, ROUND(AVG(Note_2), 2) AS Note2, ROUND(AVG(Note_3), 2) AS Note3, ROUND(AVG(Note_4), 2) AS Note4, ROUND(AVG(Note_5), 2) AS Note5 from tbl_noten join tbl_lehrling on tbl_noten.Ll_Nr = tbl_lehrling.Ll_Nr where Fae_Nr = " + StrFach + " and Se_Nr = " + StrSemester + ";");
                DtbAverages.Columns.Add("Gesamt"); ;
                DtbAverages.Rows[0]["Gesamt"] = (DoubleAverages / DoubleCells).ToString("0.00");

                DgvGrade.DataSource = DtbGrade;
                DgvAverage.DataSource = DtbAverage;
                DgvAverages.DataSource = DtbAverages;
                DgvGrade.Columns["No_Nr"].Visible = false;

                // Spalten nicht sortierbar machen
                foreach (DataGridViewColumn DgvcColumnGrade in DgvGrade.Columns)
                {
                    DgvcColumnGrade.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                foreach (DataGridViewColumn DgvcColumnAverage in DgvAverage.Columns)
                {
                    DgvcColumnAverage.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                foreach (DataGridViewColumn DgvcColumnAverages in DgvAverages.Columns)
                {
                    DgvcColumnAverages.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        // Bilder zeichnen von den DataGridViews
        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                Bitmap BmBitmapGrade = new Bitmap(this.DgvGrade.Width, this.DgvGrade.Height);
                DgvGrade.DrawToBitmap(BmBitmapGrade, new Rectangle(0, 0, this.DgvGrade.Width, this.DgvGrade.Height));
                e.Graphics.DrawImage(BmBitmapGrade, 0, 0);

                Bitmap BmBitmapAverage = new Bitmap(this.DgvAverage.Width, this.DgvAverage.Height);
                DgvAverage.DrawToBitmap(BmBitmapAverage, new Rectangle(0, 0, this.DgvAverage.Width, this.DgvAverage.Height));
                e.Graphics.DrawImage(BmBitmapAverage, DgvGrade.Width + 10, 0);

                Bitmap BmBitmapAverages = new Bitmap(this.DgvAverages.Width, this.DgvAverages.Height);
                DgvAverages.DrawToBitmap(BmBitmapAverages, new Rectangle(0, 0, this.DgvAverages.Width, this.DgvAverages.Height));
                e.Graphics.DrawImage(BmBitmapAverages, 0, DgvGrade.Height + 10);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
