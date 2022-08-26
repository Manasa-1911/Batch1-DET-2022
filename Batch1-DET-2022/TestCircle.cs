using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class TestCircle
    {
        public static void Main()
        {
            Circle  c = new Circle(2);
            Console.WriteLine($"Radius of a circle {c.area()}");
        }
    }
}
