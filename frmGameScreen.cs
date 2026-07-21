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
        private struct towerMenuItems
        {
            public string name;
            public int cost;
            public int damage;
            public int range;
            public Image image;
            public Rectangle bounds;
        }
        private List<towerMenuItems> towerMenu = new List<towerMenuItems>();
        private List<Tower> placedTowers = new List<Tower>();
        private bool isDragging = false;
        private towerMenuItems draggedTowerType;
        private int dragX;
        private int dragY;

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
                new waypoint(500, 280),
                new waypoint(770, 281)
            };

            towerMenu.Add(new towerMenuItems
            {
                name = "Basic Tower",
                cost = 100,
                damage = 10,
                range = 100,
                image = Image.FromFile("enemydemo.jpeg"),
                bounds = new Rectangle(400,400 , 35, 35)
            });

           


            // game timer setup
            Timer gameTimer = new Timer();
            gameTimer.Interval = 16;
            gameTimer.Tick += gameTimerEvent;
            gameTimer.Start();

            this.MouseDown += frmGameScreen_MouseDown;
            this.MouseMove += frmGameScreen_MouseMove;
            this.MouseUp += frmGameScreen_MouseUp;
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
                    enemies.Add(new Enemy(0, 223, 65, 65, 2, waypoints)); // spawn new enemy at starting position 
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


        private void frmGameScreen_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (var tower in towerMenu)
            {
                if (tower.bounds.Contains(e.Location))
                {
                    isDragging = true;
                    draggedTowerType = tower;
                    dragX = e.X;
                    dragY = e.Y;
                    break;
                }
            }
        }

        private void frmGameScreen_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                dragX = e.X;
                dragY = e.Y;
                this.Invalidate(); // Redraw the form to show the dragged tower
            }
        }

        private void frmGameScreen_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                // Place the tower at the drop location
                placedTowers.Add(new Tower(dragX - 20, dragY - 20, 40,40, 0, draggedTowerType.range, draggedTowerType.damage, draggedTowerType.name));
                isDragging = false;
                this.Invalidate(); // Redraw the form to show the placed tower
            }
        }

        private bool isValidPlacement(int x, int y)
        {
            // Check if the placement is within the bounds of the game area
            if (x < 0 || y < 0 || x > this.ClientSize.Width || y > this.ClientSize.Height)
                return false;
            // Check if the placement overlaps with existing towers
            foreach (var tower in placedTowers)
            {
                Rectangle towerRect = new Rectangle(tower.getPositionX(), tower.getPositionY(), tower.getWidth(), tower.getHeight());
                if (towerRect.Contains(x, y))
                    return false;
            }
            return true;
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            foreach (Enemy enemy in enemies)// draws each enemy on the game screen at its current position
            {
                enemy.Draw(e.Graphics);
            }
            foreach(Tower tower in placedTowers)
            {
                tower.DrawTower(e.Graphics);
            }
            foreach (var item in towerMenu)
            {
                e.Graphics.DrawImage(item.image, item.bounds);
            }

            if(isDragging)
            {
                e.Graphics.DrawImage(draggedTowerType.image, dragX - 20, dragY - 20, 40, 40);
            }

        }
    }
}

