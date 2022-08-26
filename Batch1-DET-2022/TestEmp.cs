using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class TestEmp
    {
        public static void Main()
        {
            emp e = new emp(22825, "Manasa", new DateOnly(2021, 8, 1));
            Console.WriteLine($"Years of experience{e.GetYearsofExp()}");
        }
    }
}
