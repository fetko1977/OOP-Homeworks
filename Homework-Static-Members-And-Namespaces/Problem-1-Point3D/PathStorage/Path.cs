using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space3D
{
    public class Path
    {
        private List<Point3D> pts = new List<Point3D>();

        //Constructor
        public Path(params Point3D[] pts)
        {
            if (pts.Length > 0)
            {
                this.pts.AddRange(pts);   
            }
        }

        //Method for adding point in the List
        public void AddPoint(Point3D point)
        {
            this.pts.Add(point);
        }
        
        //String override method
        public override string ToString()
        {
            return string.Join(" ", this.pts);
        }
    }
}
