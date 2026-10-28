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
    public partial class frmStartScreen : Form
    {
        public frmStartScreen()
        {
            InitializeComponent();
            this.DoubleBuffered = true;// Enable double buffering to reduce flickering
        }

       
        private void frmStartScreen_Load(object sender, EventArgs e)
        {

        }

        private void Startbutton_Click(object sender, EventArgs e)
        {// This is the event handler for when the start button is clicked
            frmMapSelection frmMapSelection = new frmMapSelection();
            frmMapSelection.Show();
            this.Hide();// Hide the start screen instead of closing it
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close the application when the exit button is clicked
        }

        
    }
}
