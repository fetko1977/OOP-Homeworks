using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space3D
{
    class DistanceCalculator
    {
        public static double distance(Point3D pointOne, Point3D pointTwo)
        {
            double distance;
            distance = Math.Sqrt(Math.Pow((pointTwo.X - pointOne.X), (double)2) + Math.Pow((pointTwo.Y - pointOne.Y), (double)2) + Math.Pow((pointTwo.Z - pointOne.Z), (double)2));
            return distance;
        }
    }
}
