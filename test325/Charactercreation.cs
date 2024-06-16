using System;
using System.Media;
using System.Windows.Forms;

namespace Projektvecka
{
    public partial class Charactercreation : Form
    {
        static bool selected = false;
        public static bool genderMale;
        public Charactercreation()
        {
            InitializeComponent();
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void Charactercreation_Load(object sender, EventArgs e)
        {
            gndrFemale.Visible = false;
            gndrMale.Visible = false;
        }

        private void gndrbtn1_Click(object sender, EventArgs e)
        {
            gndrFemale.Visible = false;
            gndrMale.Visible = true;
            genderMale = true;
            selected = true;
        }

        private void gndrbtn2_Click(object sender, EventArgs e)
        {
            gndrMale.Visible = false;
            gndrFemale.Visible = true;
            genderMale = false;
            selected = true;
        }

        private void cnfrmbtn_Click(object sender, EventArgs e)
        {
            if (selected == true)
            {
                Charactercreation2 charactercreation2 = new Charactercreation2(genderMale);
                this.Hide();
                charactercreation2.Visible = true;
            }
            else
            {
                MessageBox.Show("You need to select a gender", "men y");
            }
        }
    }
}
