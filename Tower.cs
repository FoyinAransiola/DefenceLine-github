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
    }
}
