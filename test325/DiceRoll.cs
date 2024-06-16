using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace test325
{
    public partial class DiceRoll : Form
    {
        public DiceRoll()
        {
            InitializeComponent();
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }
        int[] randNo;
        Random randm = new Random();

        private void btn_fight_Click(object sender, EventArgs e)
        {
            txtB_u.Clear();
            txtB_enemy.Clear();

            int no1 = 1;
            int no2 = 6;
            int noAmount = 5;
            int uScore = 0;
            int enemyScore = 0;
            int moneyAdded = 0;

            randNo = new int[noAmount];
            no2++;

            for (int i = 0; i < randNo.Length; i++)
            {
                randNo[i] = randm.Next(no1, no2);
                txtB_u.AppendText(randNo[i] + "\r\n");
                uScore = uScore + randNo[i];
            }

            for (int i = 0; i < randNo.Length; i++)
            {
                randNo[i] = randm.Next(no1, no2);
                txtB_enemy.AppendText(randNo[i] + "\r\n");
                enemyScore = enemyScore + randNo[i];
            }

            if (uScore >= enemyScore)
            {
                while (moneyAdded < 50)
                {
                    moneyAdded++;
                    TalesOfTheMagicSword.Stats.money++;
                    lbl_balance.Text = "Money: " + TalesOfTheMagicSword.Stats.money;
                }

                if (moneyAdded == 50)
                {
                    moneyAdded = 0;
                }

                lbl_win.Text = "You win";
            }
            else
            {
                lbl_win.Text = "You lose";
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
    

