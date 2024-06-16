using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TalesOfTheMagicSword
{
    public partial class Store : Form
    {
        public static bool swordBuy = false;
        public Store()
        {
            InitializeComponent();
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btn_Swordask_Click(object sender, EventArgs e)
        {
            Stats.dmg = 10101;
            btn_Swordask.Visible = false;
            Stats.money = Stats.money - 500;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            FightSelect fightSelect = new FightSelect();
            this.Hide();
            fightSelect.Visible = true;
        }
    }
}
