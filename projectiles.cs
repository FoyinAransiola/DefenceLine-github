using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defence_line_form
{
    internal class projectiles : Sprite 
    {
        private Enemy targetEnemy;// this is the enemy that the projectile is targeting
        private int damage; // this is the amount of damage that the projectile will do to the enemy when it hits it

        // these are the float positions of the projectile to allow for smooth movement
        private float posX; 
        private float posY;
        private float velX;
        private float velY;
        private float targetPointX;
        private float targetPointY;

        public projectiles(int newX, int newY, int newHeight, int newWidth, int newSpeed, Enemy newtargetEnemy, int newdamage)
            : base(newX, newY, newHeight, newWidth, newSpeed)
        {
            this.targetEnemy = newtargetEnemy;
            this.damage = newdamage;
            setImage("projectile.png");
            this.posX = newX;
            this.posY = newY;

            // capture enemy centre at spawn as fixed target point so projectiles will travels
            // to the enemy's centre even if the enemy moves after the projectile is fired
            // this also makes the projectiles non-homing, which is a common behaviour in many games
            if (newtargetEnemy != null)
            {
                targetPointX =  newtargetEnemy.getPositionX() + newtargetEnemy.getWidth() / 2f;
                targetPointY =  + newtargetEnemy.getPositionY() + newtargetEnemy.getHeight() / 2f;
            }
            else
            {
                targetPointX = posX;
                targetPointY = posY;
            }

            // compute initial normalized velocity toward that target point
            float projCenterX = posX + getWidth() / 2f;
            float projCenterY = posY + getHeight() / 2f;
            float dx = targetPointX - projCenterX;
            float dy = targetPointY - projCenterY;
            float dist = (float)Math.Sqrt(dx * dx + dy * dy);
            if (dist <= 0.001f)
            {
                velX = velY = 0f;
            }
            else
            {
                float speedF = 13;
                velX = dx / dist * speedF;
                velY = dy / dist * speedF;
            }
        }


        public int getDamage()
        {
            return damage;
        }

        public void moveTowardsEnemy()
        {
            // this update integer positon
            posX += velX;
            posY += velY;

            setPositionX((int)posX);
            setPositionY((int)posY);
        }
        public bool hasHitTaregt()
        {
            // check hit against captured enemy centre (so projectile goes to centre of hitbox)
            if (targetEnemy == null)
            {
                return false;
            }

            float projCX = posX + getWidth() / 2f;
            float projCY = posY + getHeight() / 2f;
            float dx = projCX - targetPointX;
            float dy = projCY - targetPointY;
            float distSq = dx * dx + dy * dy;

            float projRadius = Math.Max(getWidth(), getHeight()) / 2f;
            float enemyRadius = Math.Max(targetEnemy.getWidth(), targetEnemy.getHeight()) / 2f;
            float hitRadius = projRadius + enemyRadius + 2f;

            return distSq <= hitRadius * hitRadius;
        }

        public void Draw(Graphics g)
        {
            g.DrawImage(getImage(), getPositionX(), getPositionY(), getWidth(), getHeight());
        }
    }
}
