﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class Circle
    {
        int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public double area()

        {
            return Math.PI * radius * radius;
        }
    }
}
