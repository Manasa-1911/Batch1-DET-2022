using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class QuantifiersLinq
    {
        public static void Main()
        {
            SampleAll();
            SampleAny();
            SampleContains();
        }
        static void SampleAll()
        {
            string[] names = { "Manasa","Monika", "Manvith","Chandana","Ananya"};
            var result = names.All(n => n.StartsWith("M"));
            Console.WriteLine("Does all the names starts with M");
            Console.WriteLine(result);
        }

        static void SampleAny()
        {
            string[] names = { "Manasa","Chandana","Ananya"};
            var result = names.Any(n => n.StartsWith("M"));
            Console.WriteLine("Does all the names starts with M");
            Console.WriteLine(result);
        }

        static void SampleContains()
        {
            string[] names = { "Manasa", "Sandhya", "Priyanka" };
            var result = names.Contains("Manasa");
            Console.WriteLine("Is Manasa name there in the array");
            Console.WriteLine(result);
        }
    }
}
