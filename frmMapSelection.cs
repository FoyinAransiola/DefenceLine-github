using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace defence_line_form
{
    public partial class frmMapSelection : Form
    {
        public frmMapSelection()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Enable double buffering to reduce flickering
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {// This is the event handler for when the first map picture box is clicked
            frmGameScreen frmGameScreen = new frmGameScreen();
            frmGameScreen.Show();
            this.Close();// Close the map selection screen
        }

        private void frmMapSelection_Load(object sender, EventArgs e)
        {

        }

        public void Back_Click(object sender, EventArgs e)
        {
            frmStartScreen frmStartScreen = new frmStartScreen();
            frmStartScreen.Show();
            this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close the application when the exit button is clicked
        }
    }
}
