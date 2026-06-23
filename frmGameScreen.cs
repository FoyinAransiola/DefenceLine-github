using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace defence_line_form
{
    public partial class frmGameScreen : Form
    {
        private List<Enemy> enemies = new List<Enemy>();// list that holds all the enemy objects in the game
        private List<waypoint> waypoints;//List that holds all the waypoints for enemy pathfinding
        private int totalenemies = 10; // total number of enemies to spawn into the game screen
        private int spawnedEnemyCount = 0; // counter to keep track of how many enemies have been spawned into the game screen
        private int spawnInterval = 60; // time interval between enemy spawns in game timer ticks (60 ticks = 1second)
        private int spawnCounter = 0; // keep track of time passed in game timer ticks to determine when to spawn next enemy 


        public frmGameScreen()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            
        }

        private void frmGameScreen__Load(object sender, EventArgs e)
        {
            waypoints = new List<waypoint>
            {//list of waypoint coordinates that define enemy path
                new waypoint(290, 223),
                new waypoint(290, 57),
                new waypoint(500, 57),
                new waypoint(500, 345),
                new waypoint(724, 345)
            };


            // game timer setup
            Timer gameTimer = new Timer();
            gameTimer.Interval = 16;
            gameTimer.Tick += gameTimerEvent;
            gameTimer.Start();

            
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            if (spawnedEnemyCount < totalenemies)
            // checks if the number of spawned enemies is less that the total number of
            // enemies to spawn before spawning the next enemy (preventing infinite spawning)
            {
                spawnCounter++; // incremented every tick
                if (spawnCounter >= spawnInterval)// once spawn counter reaches spawn interval new enemy is spawned
                {
                    enemies.Add(new Enemy(0, 223, 65, 65, 1, waypoints)); // spawn new enemy at starting position 
                    spawnedEnemyCount++;
                    spawnCounter = 0; //reset spawn counter after spawning an enemy (resets clock)
                }
            }

            foreach (Enemy enemy in enemies)
            {
                enemy.move(); // moves each enemy along path using waypoints
            }

            // Remove enemies that reached the final waypoint and dispose their images
            for (int i = enemies.Count - 1; i >= 0; i--)
            {
                if (enemies[i].endReached())
                {
                    enemies[i].DisposeImage();
                    enemies.RemoveAt(i);
                }
            }

            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            foreach (Enemy enemy in enemies)// draws each enemy on the game screen at its current position
            {
                enemy.Draw(e.Graphics);
            }
            
        }

        
    }
}
