using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class CSFeatures
    {
        public static void Main()
        {
            //Lamda syntax
            //Action<string> action = (string name) => { Console.WriteLine($"Hai {name}"); };
            //Action<string, string> action1 = (string s1, string s2) =>
            //{
            //    Console.WriteLine($"Hai{s1}," +
            //    $"you said {s2}");
            //};
            //Action<int,string,string> action2 = (int id,string name,string address) =>
            //{
            //    Console.WriteLine($"Id={id}, Name={name}, Address={address}");
                    
            //};

            Func<int, int, long> Multiply = (x, y) =>
            {
                return x * y;
            };
            long result = Multiply(20, 20);
            Console.WriteLine(result);

            //action.Invoke("Manasa");
            //action1.Invoke("Manasa", "am in Bangalore");
            //action2(22825, "Manasa", "Bangalore");
        }
    }
}
