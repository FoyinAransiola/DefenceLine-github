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
    public partial class frmGameScreen : Form
    {
        private Enemy enemy;


        public frmGameScreen()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void frmGameScreen__Load(object sender, EventArgs e)
        {
            List<waypoint> waypoints = new List<waypoint>
            {
                new waypoint(316, 252),
                new waypoint(316, 84),
                new waypoint(524, 84),
                new waypoint(524, 370),
                new waypoint(727, 370)
            };

            enemy = new Enemy(12, 243, 25,25 , 1, waypoints);

            // game timer setup
            Timer gameTimer = new Timer();
            gameTimer.Interval = 16;
            gameTimer.Tick += gameTimerEvent;
            gameTimer.Start();

            
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            enemy.move();
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            enemy.Draw(e.Graphics);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
