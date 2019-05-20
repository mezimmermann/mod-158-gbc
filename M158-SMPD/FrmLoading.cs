using System;
using System.Media;
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
