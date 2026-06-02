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
        {// Constructor 
            this.positionX = newX;
            this.positionY = newY;
            this.height = newHeight;
            this.width = newWidth;
            this.speed = newSpeed;
        }

        // Getters
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

        // Setters
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

        public void setImage(string newImage)
        {
            if (newImage != null)
            {
                this.spriteimage = Image.FromFile(newImage);
            }
            else
            {
                this.spriteimage = null;
            }
        }

        // Methods (Movement)
        public void movesprite(string direction, EventArgs e)
        {
            if (direction == "left" && positionX > 0)
            {
                positionX -= speed;
            }
            else if (direction == "right" )
            {
                positionX += speed;
            }
            else if (direction == "up" && positionY > 0)
            {
                positionY -= speed;
            }
            else if (direction == "down" )
            {
                positionY += speed;
            }
        }
    }
}
