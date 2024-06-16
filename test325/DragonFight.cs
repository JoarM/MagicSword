using System;
using System.Windows.Forms;

namespace TalesOfTheMagicSword
{
    public partial class DragonFight : Form
    {
        static int r_dmg = Stats.dmg;

        static bool magkweapon = false;

        static bool dragonAlive = true;

        static bool playerAlive = true;

        static int killedGnomes = GnomeFight.gnomesKilled;

        
        public DragonFight()
        {
            InitializeComponent();
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

            prgrs_playerHealth.Value = Stats.health;

            if (killedGnomes >= 6)
            {
                r_dmg = r_dmg * 2;
            }
            else if (killedGnomes >= 9)
            {
                r_dmg = r_dmg * 3;
            }

            if (Stats.dmg == 10101)
            {
                magkweapon = true;
            }

            btn_potion.Text = "potions:" + Stats.potions;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Fight_Click(object sender, EventArgs e)
        {
            try
            {
                if (playerAlive == true)
                {
                    if (magkweapon == true)
                    {
                        Random no = new Random();
                        int t_dmg = no.Next(0, 101);
                        r_dmg = t_dmg;

                        if (r_dmg >= prgs_Dragon.Value)
                        {
                            prgs_Dragon.Value = 0;
                            dragonAlive = false;
                            Win win = new Win();
                            this.Hide();
                            win.Visible = true;
                        }
                        else
                        {
                            prgs_Dragon.Value = prgs_Dragon.Value - r_dmg;
                        }
                    }
                    else
                    {
                        if (r_dmg >= prgs_Dragon.Value)
                        {
                            prgs_Dragon.Value = 0;
                            dragonAlive = false;
                            Win win = new Win();
                            this.Hide();
                            win.Visible = true;
                        }
                        else
                        {
                            prgs_Dragon.Value = prgs_Dragon.Value - r_dmg;
                        }
                    }
                }


                if (dragonAlive == true)
                {
                    Random i = new Random();
                    int t_Edmg = i.Next(0, 101);
                    int r_Edmg = t_Edmg;

                    if (playerAlive == true)
                    {
                        if (r_Edmg > prgrs_playerHealth.Value)
                        {
                            prgrs_playerHealth.Value = 0;
                            playerAlive = false;
                            Restart restart1 = new Restart();
                            this.Hide();
                            restart1.Visible = true;
                        }
                        else
                        {
                            prgrs_playerHealth.Value = prgrs_playerHealth.Value - r_Edmg;
                            Stats.health = Stats.health - r_Edmg;
                        }
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }


        }

        private void btn_Run_Click(object sender, EventArgs e)
        {
            LoadoutSelection loadoutSelection = new LoadoutSelection();
            this.Hide();
            loadoutSelection.Visible = true;
        }

        private void btn_potion_Click(object sender, EventArgs e)
        {
            if (Stats.potions > 0)
            {
                if (100 - prgrs_playerHealth.Value >= 30)
                {
                    Stats.health = Stats.health + 30;
                    prgrs_playerHealth.Value = Stats.health;
                    Stats.potions--;
                    btn_potion.Text = "potions:" + Stats.potions;
                }
                else
                {
                    prgrs_playerHealth.Value = 100;
                    Stats.health = 100;
                    Stats.potions--;
                    btn_potion.Text = "potions:" + Stats.potions;
                }
            }
        }
    }
}
