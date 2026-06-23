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
        private string currentDirection = "none";


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
        public Image getImage()
        {
            return spriteimage;
        }
        public string getCurrentDirection()
        {
            return currentDirection;
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

        public void setCurrentDirection(string newDirection)
        {
            this.currentDirection = newDirection;
        }

        // Dispose the loaded image to free resources when the sprite is removed
        public void DisposeImage()
        {
            if (spriteimage != null)
            {
                spriteimage.Dispose();
                spriteimage = null;
            }
        }

        



    }
}
