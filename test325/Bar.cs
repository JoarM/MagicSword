using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace test325
{
    public partial class Bar : Form
    {
        public Bar()
        {
            InitializeComponent();
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            lbl_money.Text = "Money: " + TalesOfTheMagicSword.Stats.money;
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            if (TalesOfTheMagicSword.Stats.money >= 50)
            {
                TalesOfTheMagicSword.Stats.money = TalesOfTheMagicSword.Stats.money - 50;
                TalesOfTheMagicSword.Stats.potions++;
                lbl_money.Text = "Money: " + TalesOfTheMagicSword.Stats.money;
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            TalesOfTheMagicSword.InTavern inTavern = new TalesOfTheMagicSword.InTavern();
            this.Hide();
            inTavern.Visible = true;
        }
    }
}
