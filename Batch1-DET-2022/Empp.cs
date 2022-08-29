using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Empp
    {
        int id;
        string name;
        string dept;
        double sal;
        DateTime doj;

        //constructor - is a function used to init object data
        //has the same name as classname, no ret type
        public Empp(int id, string name, DateTime doj)
        {
            this.id = id; this.name = name; this.doj = doj;
        }
        public Empp()
        {
            id = -1; name = "no name";
        }
        public Empp(int id, string name)
        {
            this.id = id; this.name = name;
        }

        //function written inside a class is known as method
        public int GetYearsofExp()
        {
            return DateTime.Now.Year - doj.Year;
        }

        public virtual string ToString()   //only virtual method can be overridden
        {
            return $"Emp Id={id}, Name={name}, Experience={GetYearsofExp()} Years";
        }
    }
}
