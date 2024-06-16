using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TalesOfTheMagicSword
{
    public partial class Restart : Form
    {
        public Restart()
        {
            InitializeComponent();
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            OutsideBar.Chestopend = false;
            Stats.dmg = 10;
            Stats.health = 100;
            Projektvecka.Menu menu = new Projektvecka.Menu();
            this.Hide();
            menu.Visible = true;
            Stats.money = 0;
            Stats.potions = 1;
        }
    }
}
