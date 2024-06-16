using System;
using System.Media;
using System.Windows.Forms;





namespace Projektvecka
{
    
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }
        
        private void Menu_Load(object sender, EventArgs e)
        {
            

            

            
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            
            
            GameStart gameStart = new GameStart();
            this.Hide();
            gameStart.Visible = true;
            

           

        }

       
    }
}
