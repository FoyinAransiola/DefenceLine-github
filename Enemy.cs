using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defence_line_form
{
    internal class Enemy : Sprite
    {
        private int health;
        private int enemyImage_Location;
        private Image image;


        public Enemy(int newX, int newY, int newHeight, int newWidth, int newSpeed)
           : base(newX , newY, newHeight,newHeight,newSpeed)
        {
            health = 0;
        }
    }
}
