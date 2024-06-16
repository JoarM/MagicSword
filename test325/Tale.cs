using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projektvecka
{
    public partial class Tale : Form
    {
        public Tale()
        {
            InitializeComponent();
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void Tale_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void ctnbtn2_Click(object sender, EventArgs e)
        {
            EndofTale endStart = new EndofTale();
            this.Hide();
            endStart.Visible = true;
        }
    }
}
