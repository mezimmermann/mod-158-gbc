using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M158_SMPD
{
    public partial class FrmLoading : Form
    {
        public FrmLoading()
        {
            InitializeComponent();
        }
        private void PlaySimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(M158_SMPD.Properties.Resources.btman);
            simpleSound.Play();
        }
        private void FrmLoading_Shown(object sender, EventArgs e)
        {
            PlaySimpleSound();
        }
    }
}
