using System;
using System.Media;
using System.Windows.Forms;

namespace Projektvecka
{
    public partial class Charactercreation2 : Form
    {
        static bool gndrMale;
        public static bool genderMale;

        public static string name;
        public Charactercreation2(bool genderMale)
        {
            InitializeComponent();
            if (genderMale == true)
            {
                gndrFemale2.Visible = false;
                gndrMale2.Visible = true;
            }
            else
            {
                gndrMale2.Visible = false;
                gndrFemale2.Visible = true;
            }
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

            gndrMale = genderMale;
        }

        private void cnfrmbtn2_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;

            if (name == "")
            {
                MessageBox.Show("Name cant be left empty", "problem");
            }
            else
            {
                OldMan oldMan = new OldMan(name, gndrMale);
                this.Hide();
                oldMan.Visible = true;
            }
            
            
        }
    }
}
