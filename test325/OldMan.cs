using System;
using System.Media;
using System.Windows.Forms;


namespace Projektvecka
{
    public partial class OldMan : Form
    {
        string naMe;
        bool gnDrMale;
        public OldMan(string name, bool gndrMale)
        {
            InitializeComponent();
            
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            


            naMe = name;
            gnDrMale = gndrMale;

            if (gndrMale)
            {
                gndrFemale3.Visible = false;
                gndrMale3.Visible = true;
            }
            else
            {
                gndrMale3.Visible = false;
                gndrFemale3.Visible = true;
            }
            lblDialog1.Text = naMe + ", you need to go to the tavern and fight the gnomes.";
        }

        

        private void ctnbtn4_Click(object sender, EventArgs e)
        {
            OldManDialogR1 oldManD1 = new OldManDialogR1(naMe, gnDrMale);
            this.Hide();
            oldManD1.Visible = true;
        }
    }
}
