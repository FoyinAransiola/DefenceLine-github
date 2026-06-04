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
        


        public Enemy(int newX, int newY, int newHeight, int newWidth, int newSpeed,List<waypoint> newWaypoint)
           : base(newX , newY, newHeight,newHeight,newSpeed)
        {
            this.waypoints = newWaypoint;
            setImage("enemydemo.jpeg"); // uses Sprite set image method
        }

        // waypoint movement method for enemy pathfinding
        public void move()
        {
            if ( currentWaypointIndex >= waypoints.Count) // this ensures the enemy stops after reaching the last waypoint
            {
                return;
            }

            waypoint target = waypoints[currentWaypointIndex]; // getting next waypoint to move to 

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
            if (getPositionX() == target.coordinateX && getPositionY() == target.coordinateY)
            {
                currentWaypointIndex++;
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
    }
}
