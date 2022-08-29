using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Person
    {
        string name;
        DateTime dob;
        string address;

        public enum MaritalStatus
        {
            Single,
            Married,
            Divorced,
            Widowed

        }

        public Person(string name, DateTime dob, string address, Enum MaritalStatus)
        {
            this.name = name;
            this.dob = dob;
            this.address = address;
        }
        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetDOB(DateTime dob)
        {
            this.dob = dob;
        }

        public void SetAddress(string address)
        {
            this.address = address;
        }

        public void SetMaritalStatus(Enum MaritalStatus)
        {

        }
        public string GetName()
        {
            return name;
        }

        public DateTime GetDOB()
        {
            return dob;
        }

        public string GetAddress()
        {
            return address;
        }

        public int GetAge(DateTime dob)
        {
            int CurrentYear = DateTime.Now.Year;
            //int C = DateTime.Now.Date;
            return CurrentYear - dob.Year;

        }

        public string CanMarry()
        {
            if (GetAge(dob) > 18)
            {
                return "true";
            }
            else
                return "false";
        }
    }
}
    
