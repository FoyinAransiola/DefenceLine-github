using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defence_line_form
{
    internal class waypoint
    {
        public int coordinateX;
        public int coordinateY;

        public waypoint(int newx,int newy)
        {
            this.coordinateX = newx;
            this.coordinateY = newy;
        }


        //Getters
        public int getCoordinateX()
        {
            return coordinateX;
        }
        public int getCoordinateY()
        {
            return coordinateY;
        }

        //Setters 
        public void setCoordinateX(int newx)
        {
            this.coordinateX = newx;
        }
        public void setCoordinateY(int newY)
        {
            this.coordinateY = newY;
        }
    }
}
