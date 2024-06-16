using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projektvecka
{
    public partial class GameStart : Form
    {
        public GameStart()
        {
            InitializeComponent();
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

       

        private void ctnbtn1_Click(object sender, EventArgs e)
        {
            Tale taleStart = new Tale();
            this.Hide();
            taleStart.Visible = true;
        }
    }
}
