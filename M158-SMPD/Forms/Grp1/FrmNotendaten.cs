using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M158_SMPD.Forms.Grp1
{
    public partial class FrmNotendaten : Form
    {
        public FrmNotendaten()
        {
            InitializeComponent();
        }

        private void FrmNotendaten_Load(object sender, EventArgs e)
        {
            MySQLCon conn = new MySQLCon();
            DataTable dtbKlasse = conn.getSQLStatement("SELECT * FROM tbl_klasse");
            var choices_kl = new Dictionary<string, int>();

            foreach (DataRow row_kl in dtbKlasse.Rows)
            {
                choices_kl.Add(row_kl[1].ToString(), int.Parse(row_kl[0].ToString()));
            }
            LbxBeruf.DataSource = new BindingSource(choices_kl, null);
            LbxBeruf.DisplayMember = "Key";
            LbxBeruf.ValueMember = "Value";
        }

        private void LbxBeruf_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySQLCon conn = new MySQLCon();
            DataTable dtbSemester = conn.getSQLStatement("SELECT * FROM tbl_semester JOIN tbl_fae_kla_sem ON tbl_fae_kla_sem.Se_Nr = tbl_semester.Se_Nr WHERE tbl_fae_kla_sem.Kl_Nr = 66");
            var choices_se = new Dictionary<string, int>();

            foreach (DataRow row_se in dtbSemester.Rows)
            {
                choices_se.Add(row_se[1].ToString(), int.Parse(row_se[0].ToString()));
            }
            LbxSemester.DataSource = new BindingSource(choices_se, null);
            LbxSemester.DisplayMember = "Key";
            LbxSemester.ValueMember = "Value";
        }
    }
}
