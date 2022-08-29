using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class PersonDOB
    {
        
        DateTime dob;
        public string DOB(DateTime dob)
    {
        if (dob > DateTime.Now)
        {
            
                return "true";
        }
            else
                return "false";
        
       
        
    }
 }



    
}
