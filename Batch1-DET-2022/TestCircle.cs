using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class TestCircle
    {
        public static void Main()
        {
            circle c = new circle();
            c.SetRadius(2);
            Console.WriteLine(c.GetRadius());
            Console.WriteLine($"Diameter of a circle {c.calcDiameter()}");
            Console.WriteLine($"Radius of a circle {c.Calcarea()}");
        }
    }
}
