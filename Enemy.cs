using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace defence_line_form
{
    internal class Enemy : Sprite
    {
        private int currentWaypointIndex = 0;
        private List<waypoint> waypoints;
        private List<string> enemyMovement = new List<string>();
        int steps = 0;
        int slowDownFrameRate = 0;



        public Enemy(int newX, int newY, int newHeight, int newWidth, int newSpeed, List<waypoint> newWaypoint)
           : base(newX, newY, newHeight, newHeight, newSpeed)
        {
            this.waypoints = newWaypoint;
            enemyMovement = Directory.GetFiles("Goblins", "*.png").ToList();
            setImage(enemyMovement[60]); // uses Sprite set image method
        }


        public void move()// this method checks if the enemy has reached the waypoint and moves the enemy towards the next waypoint if it has not reached the last waypoint
        {
            if (currentWaypointIndex >= waypoints.Count) // this ensures the enemy stops after reaching the last waypoint
            {
                return;
            }

            waypoint target = waypoints[currentWaypointIndex]; // getting next waypoint to move to 

            // gets diretcions
            if (getPositionX() < target.coordinateX)
            {
                setCurrentDirection("Right");
            }
            if (getPositionX() > target.coordinateX)
            {
                setCurrentDirection("Left");
            }
            if (getPositionY() < target.coordinateY)
            {
                setCurrentDirection("Down");
            }
            if (getPositionY() > target.coordinateY)
            {
                setCurrentDirection("Up");
            }

            AnimationDirection(getCurrentDirection());


            // Moving left or right towards target(waypoint)
            if (getPositionX() < target.coordinateX)
            {
                setPositionX(getPositionX() + getSpeed());
            }
            else if (getPositionX() > target.coordinateX)
            {
                setPositionX(getPositionX() - getSpeed());
            }

            // Moving up or down towards target(waypoint) 
            if (getPositionY() < target.coordinateY)
            {
                setPositionY(getPositionY() + getSpeed());
            }
            else if (getPositionY() > target.coordinateY)
            {
                setPositionY(getPositionY() - getSpeed());
            }

            // checking is enemy sprite has reached waypoint         
            if (getPositionX() >= target.coordinateX - 3 && getPositionX() <= target.coordinateX + 3 &&
                getPositionY() >= target.coordinateY - 3 && getPositionY() <= target.coordinateY + 3)
            {
                currentWaypointIndex = currentWaypointIndex + 1;
            }
        }

        public bool endReached()// this checks if the enemy has reached every waypoint 
        {
            if (currentWaypointIndex >= waypoints.Count) { return true; }
            else { return false; }
        }

        public void Draw(Graphics g)
        {
            if (getPositionX() >= 0)
            {
                g.DrawImage(getImage(), getPositionX(), getPositionY(), getWidth(), getHeight());
            }
        }

        private void AnimateEnemy(int start, int end)// this is the methods that controls animations
        {
            slowDownFrameRate += 1;
            if (slowDownFrameRate == 4)
            {
                steps++;
                slowDownFrameRate = 0;
            }
            if (steps > end || steps < start)
            {
                steps = start;
            }
            setImage(enemyMovement[steps]);
        }

        public void AnimationDirection(string direction) // gets AnimateEnemy to iterate thorugh the right sequence of images
        {
            if (direction == "Up")
            {
                AnimateEnemy(0, 19);
            }
            if (direction == "Down")
            {
                AnimateEnemy(20, 39);
            }
            if (direction == "Left")
            {
                AnimateEnemy(40, 59);
            }
            if (direction == "Right")
            {
                AnimateEnemy(60, 79);
            }
        }

    }
}
