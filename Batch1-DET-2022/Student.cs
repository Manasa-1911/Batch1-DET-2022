using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Batch1_DET_2022
{
   
        public abstract class Student
        {
            public int regno { get; set; }
            public string Name { get; set; }



            public abstract double GetAvgMarks();

            public virtual string ToString()   //only virtual method can be overridden
            {
            return $"Student Regno={regno}, Student Name={Name}";
            }

    }
    }

