using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Space3D
{
    static class Storage
    {
        public static void SaveFile(string file, Path path)
        {
            using (StreamWriter sw = new StreamWriter(file)){
                sw.Write(path);
            }
        }

        public static Path LoadPath(string file)
        {
            Path path = new Path();

            using (StreamReader sr = new StreamReader(file))
            {
                string entry = sr.ReadToEnd();

                string pattern = "{([\\d,.-]+), ([\\d,.-]+), ([\\d,.-]+)}";
                var rg = new Regex(pattern);
                var mathes = rg.Matches(entry);

                if (mathes.Count <= 0)
                {
                    throw new ArgumentException("Bad values in text file!");   
                }

                foreach (Match match in mathes)
                {
                    double x = double.Parse(match.Groups[1].Value);
                    double y = double.Parse(match.Groups[2].Value);
                    double z = double.Parse(match.Groups[3].Value);

                    Point3D pt = new Point3D(x, y, z);
                    path.AddPoint(pt);
                }
            }
            return path;
        }
    }
}
