using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TalesOfTheMagicSword
{
    public partial class GnomeFight : Form
    {
        public static int gnomesKilled;



        static bool gnome1Alive = true;

        static bool gnome2Alive = true;

        static bool gnome3Alive = true;

        static bool opendChest = false;

        public GnomeFight()
        {
            InitializeComponent();
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            gnome1Alive = true;
            gnome2Alive = true;
            gnome3Alive = true;

            opendChest = OutsideBar.Chestopend;
            playerHealth.Value = Stats.health;

            gnome1_health.Value = 30;
            gnome2_health.Value = 30;
            gnome3_health.Value = 30;

            btn_potions.Text = "potions:" + Stats.potions;
        }

        private void btn_gnome1_Click(object sender, EventArgs e)
        {

            if (Stats.dmg >= gnome1_health.Value)
            {
                gnome1_health.Value = 0;
            }
            else
            {
                gnome1_health.Value = gnome1_health.Value - Stats.dmg;
            }

            if (gnome1_health.Value == 0)
            {
                gnomesKilled++;
                btn_gnome1.Visible = false;
                pictureBoxgnome1.Visible = false;
                gnome1Alive = false;
            }
            
            
            if (opendChest == true)
            {
                if (gnome1Alive == false && gnome2Alive == false && gnome3Alive == false)
                {
                    InTavern inTavern = new InTavern();
                    this.Hide();
                    inTavern.Visible = true;
                    Stats.health = playerHealth.Value;
                }
            }
            else
            {
                if (gnome1Alive == false && gnome2Alive == false && gnome3Alive == false)
                {
                    OutsideBar outsideBar = new OutsideBar();
                    this.Hide();
                    outsideBar.Visible = true;
                    Stats.health = playerHealth.Value;
                }
            }

            Random no = new Random();
            int rndm = no.Next(1, 3);
            if (rndm == 2)
            {
                if (playerHealth.Value <= 10)
                {
                    playerHealth.Value = 0;
                    Restart restart = new Restart();
                    this.Hide();
                    restart.Visible = true;
                }
                else
                {
                    playerHealth.Value = playerHealth.Value - 10;
                    Stats.health = Stats.health - 10;
                }
            }
        }

        private void btn_gnome3_Click(object sender, EventArgs e)
        {
            if (Stats.dmg >= gnome3_health.Value)
            {
                gnome3_health.Value = 0;
            }
            else
            {
                gnome3_health.Value = gnome3_health.Value - Stats.dmg;
            }

            if (gnome3_health.Value == 0)
            {
                gnomesKilled++;
                btn_gnome3.Visible = false;
                gnome3Alive = false;
                pictureBoxgnome3.Visible = false;
            }

            
            if (opendChest == true)
            {
                if (gnome1Alive == false && gnome2Alive == false && gnome3Alive == false)
                {
                    InTavern inTavern = new InTavern();
                    this.Hide();
                    inTavern.Visible = true;
                    Stats.health = playerHealth.Value;
                }
            }
            else
            {
                if (gnome1Alive == false && gnome2Alive == false && gnome3Alive == false)
                {
                    OutsideBar outsideBar = new OutsideBar();
                    this.Hide();
                    outsideBar.Visible = true;
                    Stats.health = playerHealth.Value;
                }
            }

            Random no = new Random();
            int rndm = no.Next(1, 3);
            if (rndm == 2)
            {
                if (playerHealth.Value <= 10)
                {
                    playerHealth.Value = 0;
                    Restart restart = new Restart();
                    this.Hide();
                    restart.Visible = true;
                }
                else
                {
                    playerHealth.Value = playerHealth.Value - 10;
                    Stats.health = Stats.health - 10;
                }
            }
        }

        private void btn_gnome2_Click(object sender, EventArgs e)
        {
            if (Stats.dmg >= gnome2_health.Value)
            {
                gnome2_health.Value = 0;
            }
            else
            {
                gnome2_health.Value = gnome2_health.Value - Stats.dmg;
            }

            if (gnome2_health.Value == 0)
            {
                gnomesKilled++;
                btn_gnome2.Visible = false;
                gnome2Alive = false;
                pictureBoxGnome2.Visible = false;
            }

            if (opendChest == true)
            {
                if (gnome1Alive == false && gnome2Alive == false && gnome3Alive == false)
                {
                    InTavern inTavern = new InTavern();
                    this.Hide();
                    inTavern.Visible = true;
                    Stats.health = playerHealth.Value;
                }
            }
            else
            {
                if (gnome1Alive == false && gnome2Alive == false && gnome3Alive == false)
                {
                    OutsideBar outsideBar = new OutsideBar();
                    this.Hide();
                    outsideBar.Visible = true;
                    Stats.health = playerHealth.Value;
                }
            }

            Random no = new Random();
            int rndm = no.Next(1, 3);
            if (rndm == 2)
            {
                if (playerHealth.Value <= 10)
                {
                    playerHealth.Value = 0;
                    Restart restart = new Restart();
                    this.Hide();
                    restart.Visible = true;
                }
                else
                {
                    playerHealth.Value = playerHealth.Value - 10;
                    Stats.health = Stats.health - 10;
                }
            }
        }

        private void btn_potions_Click(object sender, EventArgs e)
        {
            if (Stats.potions > 0)
            {
                if (100 - playerHealth.Value >= 30)
                {
                    Stats.health = Stats.health + 30;
                    playerHealth.Value = Stats.health;
                    Stats.potions--;
                    btn_potions.Text = "potions:" + Stats.potions;
                }
                else
                {
                    playerHealth.Value = 100;
                    Stats.health = 100;
                    Stats.potions--;
                    btn_potions.Text = "potions:" + Stats.potions;
                }
            }
        }
    }
}
