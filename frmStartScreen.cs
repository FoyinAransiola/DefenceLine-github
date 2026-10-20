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
        }

        private void Startbutton_Click(object sender, EventArgs e)
        {
            frmMapSelection frmMapSelection = new frmMapSelection();
            frmMapSelection.Show();
        }

        private void frmStartScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
