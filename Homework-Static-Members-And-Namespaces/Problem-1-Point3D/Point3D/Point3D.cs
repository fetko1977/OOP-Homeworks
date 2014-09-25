using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space3D
{
    public class Point3D
    {
        //Private fields with 3 points - x, y, z
        private double x;
        private double y;
        private double z;
        
        //Private static readonly field with the values of the starting point
        private static readonly Point3D startingPoint;
        
        //Static Constructor of Point3D
        static Point3D()
        {
            startingPoint = new Point3D(0, 0, 0);
        }
        
        //Main Public Constructor for Point3D
        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        
        //Properties
        public double X 
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public double Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

        public static Point3D StartingPoint
        {
            get { return Point3D.startingPoint; }
        }

        //String Override
        public override string ToString()
        {
            string str = "{";
            str += String.Format("{0:F}, {1:F}, {2:F}", this.X, this.Y, this.Z);
            str += "}";
            return str;
        }
    }
}
