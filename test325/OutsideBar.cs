using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TalesOfTheMagicSword
{
    public partial class OutsideBar : Form
    {
        public static bool weaponSword;

        public static bool Chestopend;
        public OutsideBar()
        {
            InitializeComponent();
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            pictureBoxcoins.Visible = false;
            pictureBoxMap.Visible = false;
            pictureBoxSword.Visible = false;
        }

        private void btn_openchest_Click(object sender, EventArgs e)
        {
            btn_map.Visible = true;
            btn_swrd.Visible = true;
            btn_openchest.Visible = false;
            pictureBoxcoins.Visible = true;
            pictureBoxMap.Visible = true;
            pictureBoxSword.Visible = true;
        }

        private void btn_swrd_Click(object sender, EventArgs e)
        {
            Stats.dmg = 50;
            InTavern inTavern = new InTavern();
            this.Hide();
            inTavern.Visible = true;
            Chestopend = true;
        }

        private void btn_map_Click(object sender, EventArgs e)
        {
            Store store = new Store();
            this.Hide();
            store.Visible = true;
            Chestopend = true;
            Stats.money = Stats.money + 600;
        }
    }
}
