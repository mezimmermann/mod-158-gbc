using M158_SMPD.Forms.Grp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M158_SMPD
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new FrmMain());
            Application.Run(new frmUserRegister());
=======
            Application.Run(new frmLogin());
>>>>>>> 240cc6122d9824c55d7d7e91133fbd44af4629be
        }
    }
}
