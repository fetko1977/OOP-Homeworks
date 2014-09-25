using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space3D
{
    public class Test
    {
        static void Main(string[] args)
        {
            //Problem 1 - Point3D
            
            Point3D p1 = new Point3D(1, 2, 3);
            Point3D p2 = new Point3D(5.35, 2.7, -3.29);
            Console.WriteLine();

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(Point3D.StartingPoint);
            Console.WriteLine();
            Console.WriteLine(new String('*', 20));
            Console.WriteLine();
            
            //Problem 2 - Distance Calculator

            double distance = DistanceCalculator.distance(p1, p2);
            Console.WriteLine(distance);
            Console.WriteLine();
            Console.WriteLine(new String('*', 20));
            Console.WriteLine();

            //Problem 3 - Paths

            Path path = new Path(p1, p2, Point3D.StartingPoint);
            Console.WriteLine("Save points {0} in path.", path);
            Storage.SaveFile("paths.txt", path);
            Path loadFile = Storage.LoadPath("paths.txt");
            Console.WriteLine("Load path: {0}", loadFile);
        }
    }
}
