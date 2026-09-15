using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defence_line_form
{
    internal class projectiles : Sprite
    {
        public projectiles(int newX, int newY, int newHeight, int newWidth, int newSpeed)
            : base(newX, newY, newHeight, newWidth, newSpeed)
        {
            setImage("projectile.png");
        }
    }
}
