using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M158_SMPD
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string StrPasswordDB;
            string StrUsername = TbxUsername.ToString();
            MySQLCon MysqlconUser = new MySQLCon();

            DataTable dttest = MysqlconUser.getSQLStatement("SELECT * FROM user WHERE Benutzername=\""+ StrUsername + "\"");
            //StrPasswordDB = MysqlconUser.getSQLStatement("SELECT * FROM user WHERE Benutzername='" + StrUsername + "'").Rows[0][0].ToString();
            MessageBox.Show(dttest.Rows[0][0].ToString());
        }
    }
}
