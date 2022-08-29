using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class circle
    {
        double radius;

        public void SetRadius(int radius)
        {
            this.radius = radius;
        }

        public double GetRadius()
        {
            return radius;
        }

        public double calcDiameter()
        {
            return 2 * radius;
        }

        public double Calcarea()

        {
            return Math.PI * radius * radius;
        }
    }
}
    
