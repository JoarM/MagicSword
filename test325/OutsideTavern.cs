using System;
using System.Media;
using System.Windows.Forms;

namespace Projektvecka
{
    public partial class OutsideTavern : Form
    {
        public OutsideTavern(string naMe, bool gndrMale)
        {
            InitializeComponent(); 
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            if (gndrMale)
            {
                gndrMale4.Visible = true;
                gndrFemale4.Visible = false;
            }
            else
            {
                gndrFemale4.Visible = true;
                gndrMale4.Visible = false;
            }
        }

        

        private void btnOpen_Click(object sender, EventArgs e)
        {
            TalesOfTheMagicSword.Restart restart = new TalesOfTheMagicSword.Restart();
            this.Hide();
            restart.Visible = true;
        }

        private void btnFight_Click(object sender, EventArgs e)
        {
            TalesOfTheMagicSword.GnomeFight gnomeFight = new TalesOfTheMagicSword.GnomeFight();
            this.Hide();
            gnomeFight.Visible = true;
        }
    }
}
