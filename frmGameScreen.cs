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
                new waypoint(100,100),
                new waypoint(150,150),
                new waypoint(400,400)
            };

            enemy = new Enemy(50, 100, 40, 40, 2, waypoints);

            // game timer setup
            Timer gameTimer = new Timer();
            gameTimer.Interval = 20;
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
    }
}
