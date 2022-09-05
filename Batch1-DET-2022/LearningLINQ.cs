using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class LearningLINQ
    {
        public static void Main()
        {
            
                //1. Data source
                List<int> numbers = new List<int>();
                numbers.Add(101);
                numbers.Add(100);
                numbers.Add(102);
                numbers.Add(104);

            //2.Query Creation
            //ex for deffered execution
            var numQuery = from num in numbers
                           where num > 102
                           select num;

            //Lamda exp


            //early execution
            //var numQuery = (from num in numbers
            //               select num).ToList();

            numbers.Add(200);

                //3. Query Execution

                foreach(int num in numQuery)
                {
                    Console.WriteLine("{0} ",num);
                }
                Console.ReadLine();
            }

        }
    }

