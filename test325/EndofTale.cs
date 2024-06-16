using System;
using System.Media;
using System.Windows.Forms;

namespace Projektvecka
{
    public partial class EndofTale : Form
    {
        public EndofTale()
        {
            InitializeComponent();
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Charactercreation charStart = new Charactercreation();
            this.Hide();
            charStart.Visible = true;
            

        }

        
    }
}
