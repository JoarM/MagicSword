using System;
using System.Media;
using System.Windows.Forms;

namespace Projektvecka
{
    public partial class OldManDialogR1 : Form
    {
        string naMe;
        bool gNdrMale;
        public OldManDialogR1(string name, bool gndrMale)
        {
            InitializeComponent();
            if (gndrMale)
            {
                gndrMale4.Visible = true;
                gndrFemale4.Visible = false;
            }
            else
            {
                gndrMale4.Visible = false;
                gndrFemale4.Visible = true;
            }
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            naMe = name;
            lblRe1.Text = naMe;
            gNdrMale = gndrMale;
        }

        private void OldManDialogR1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Walking walk = new Walking(naMe, gNdrMale);
            this.Hide();
            walk.Visible = true;
        }
    }
}
