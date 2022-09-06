using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    
        public class Course
        {

            public int CourseID { get; set; }
            public string Title { get; set; }
            public int Credits { get; set; }
            [Timestamp]
            public byte[] TStamp { get; set; }

            public virtual ICollection<Enrollment> Enrollments { get; set; }
        }
}

