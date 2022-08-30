using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal interface ICar
    {
        int GetPrice(String name);
    }
    class Hyundai : ICar
    {
        public  int GetPrice(String name)
        {
            if (name == "i10")
            {
                return 2000000;
            }
            else if (name == "i20")
            {
                return 2500000;
            }
            else
                return 1500000;
        }

    }
    class BMW: ICar
    {
        public int GetPrice(String name)
        {
            if (name == "M3")
            {
                return 1300000;
            }
            else if (name == "X7")
            {
                return 9600000;
            }
            else
                return 1000000;
        }
    }
    class Toyoto:ICar
    {
        public int GetPrice(String name)
        {
            if (name == "Innova")
            {
                return 1700000;
            }
            else if (name == "Fortuner")
            {
                return 3200000;
            }
            else
                return 650000;
        }
    }

    class TestCar
    {
        public static void Main()
        {
            Hyundai h = new Hyundai();
            BMW b = new BMW();
            Toyoto t = new Toyoto();

            Console.WriteLine($"Price for I10 Model {h.GetPrice("i10")}");
            Console.WriteLine($"Price for X7 Model {b.GetPrice("X7")}");
            Console.WriteLine($"Price for Innova Model {t.GetPrice("Innova")}");
        }
    }
}
