using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projektvecka
{
    public partial class Walking : Form
    {
        string namE;
        bool gndRmale;
        public Walking(string naMe, bool gndrMale)
        {
            InitializeComponent();
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            gndRmale = gndrMale;
            namE = naMe;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OutsideTavern outSide = new OutsideTavern(namE, gndRmale);
            this.Hide();
            outSide.Visible = true;
        }

        private void Walking_Load(object sender, EventArgs e)
        {

        }
    }
}
