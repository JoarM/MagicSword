using System;
using System.Windows.Forms;

namespace TalesOfTheMagicSword
{
    public partial class FightSelect : Form
    {
        public FightSelect()
        {
            InitializeComponent();
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btn_dragon_Click(object sender, EventArgs e)
        {
            LoadoutSelection loadoutSelection = new LoadoutSelection();
            this.Hide();
            loadoutSelection.Visible = true;
        }

        private void btn_Gnomes_Click(object sender, EventArgs e)
        {
            GnomeFight gnomeFight = new GnomeFight();
            this.Hide();
            gnomeFight.Visible = true;
        }
    }
}
