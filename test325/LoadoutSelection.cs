using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TalesOfTheMagicSword
{
    public partial class LoadoutSelection : Form
    {
        static bool weaponSwrd = OutsideBar.weaponSword;
        static bool swordBuy = Store.swordBuy;
        
        public LoadoutSelection()
        {
            InitializeComponent();
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

            if (Stats.dmg == 50)
            {
                Equip_MgkSwrd.Visible = false;
                Equip_Swrd.Visible = true;
            }
            else if (Stats.dmg == 10101)
            {
                Equip_MgkSwrd.Visible = true;
                Equip_Swrd.Visible = false;
            }
            else
            {
                Equip_MgkSwrd.Visible = false;
                Equip_Swrd.Visible = false;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Equip_Fists_Click(object sender, EventArgs e)
        {
            Stats.dmg = 10;
            DragonFight dragonFight = new DragonFight();
            this.Hide();
            dragonFight.Visible = true;   
        }

        private void Equip_MgkSwrd_Click(object sender, EventArgs e)
        {
            Stats.dmg = 10101;
            DragonFight dragonFight = new DragonFight();
            this.Hide();
            dragonFight.Visible = true;
        }

        private void Equip_Swrd_Click(object sender, EventArgs e)
        {
            Stats.dmg = 50;
            DragonFight dragonFight = new DragonFight();
            this.Hide();
            dragonFight.Visible = true;   
        }
    }
}
