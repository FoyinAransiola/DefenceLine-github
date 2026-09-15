using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace defence_line_form
{
    internal class Tower : Sprite
    {
        private int range;
        private int damage;
        private string type;

        public Tower(int newX, int newY, int newHeight, int newWidth, int newSpeed, int newRange, int newDamage, string newType)
            : base(newX, newY, newHeight, newWidth, 0)// the speed is set to 0 because the tower does not move
        {
            this.range = newRange; 
            this.damage = newDamage;
            this.type = newType;
            setImage("enemydemo.jpeg");// uses Sprite set image method
        }

        public void DrawTower(Graphics g)
        {
            g.DrawImage(getImage(), getPositionX(), getPositionY(), getWidth(), getHeight());
        }


        // the is the enemy detection method that checks if the enemy is within the tower's range and returns true if it is and false if it is not
        private int getDistanceToEnemy(Enemy enemy)
        {// this works out the straight line distance between the tower and the enemy using the pythagorean theorem
            int xdifference = enemy.getPositionX() - getPositionX();
            int ydifference = enemy.getPositionY() - getPositionY();

            return (int)Math.Sqrt(xdifference * xdifference + ydifference * ydifference);

        }

        public Enemy findEnemyInRange(List<Enemy> enemies)
        {// this method checks if any of the enemies in the list are within the
         // tower's range and returns the first enemy that is found to be within range
            foreach (Enemy enemy in enemies)
            {
                if (getDistanceToEnemy(enemy) <= range)
                {// this checks if the distance to the enemy is less than or equal to the tower's range
                 // this means that the enemy is within range and can be attacked by the tower

                    return enemy; // this causes method to stop and return the first enemy that is found to be within range
                }
            }
            return null;// this means that no enemies were found to be within range and no enemy can be attacked by the tower
        }


    }
}
