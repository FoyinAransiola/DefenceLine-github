using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defence_line_form
{
    internal class Sprite
    {
        private Image spriteimage;
        private int positionX;
        private int positionY;
        private int height;
        private int width;
        private int speed;



        public Sprite(int newX, int newY, int newHeight, int newWidth, int newSpeed)
        {
            this.positionX = newX;
            this.positionY = newY;
            this.height = newHeight;
            this.width = newWidth;
            this.speed = newSpeed;
        }

        public int getPositionX() 
        { 
            return positionX;
        }
        
        public int getPositionY()
        {
            return positionY;
        }

        public int getHeight()
        {
            return height;
        }

        public int getWidth()
        {
            return width;
        }

        public int getSpeed()
        {
            return speed;
        }


        public void setPositionX(int newX)
        {
            positionX = newX;
        } 

        public void setPositionY(int newY)
        {
            positionY = newY;
        }

        public void setHeight(int newHeight)
        {
            height = newHeight;
        }

        public void setWidth(int newWidth)
        {
            width = newWidth;
        }

        public void setSpeed(int newSpeed)
        {
            speed = newSpeed;
        }


    }
}
