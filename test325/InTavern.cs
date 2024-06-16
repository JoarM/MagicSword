using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TalesOfTheMagicSword
{
    public partial class InTavern : Form
    {
        bool ropePickedUp = false;

        public InTavern()
        {
            InitializeComponent();
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btn_rope_Click(object sender, EventArgs e)
        {
            ropePickedUp = true;

            btn_rope.Visible = false;
        }

        private void btn_chair_Click(object sender, EventArgs e)
        {
            if (ropePickedUp == true)
            {
                Restart restart1 = new Restart();
                this.Hide();
                restart1.Visible = true;
            }
        }

        private void btn_ext_Click(object sender, EventArgs e)
        {
            FightSelect fightSelect = new FightSelect();
            this.Hide();
            fightSelect.Visible = true;
        }

        private void btn_dice_Click(object sender, EventArgs e)
        {
            test325.DiceRoll diceRoll = new test325.DiceRoll();
            this.Hide();
            diceRoll.Visible = true;
        }

        private void btn_bar_Click(object sender, EventArgs e)
        {
            test325.Bar bar = new test325.Bar();
            this.Hide();
            bar.Visible = true;
        }
    }
}
