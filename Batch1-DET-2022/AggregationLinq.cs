using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class AggregationLinq
    {
        public static void Main()
        {
            SampleAggregate();
            SampleAverage();
            SampleCount();
            SampleMax();
            SampleMin();
            SampleSum();
        }
        private static void SampleAggregate()
        {
            var numbers = new int[] { 2,3,4,1,7 };

            var result = numbers.Aggregate((a ,b)=> a * b);
            
            Console.WriteLine("Aggregated numbers by multiplication:");
           Console.WriteLine(result);
        }

        static void SampleAverage()
        {
            int[] numbers = { 5,2,3,1 };

            var result = numbers.Average();

            Console.WriteLine("Average is:");
           Console.WriteLine(result);
        }

        static void SampleCount()
        {
            string[] names = { "Manasa", "Chandana", "Ananya" };
            var result=names.Count();
            Console.WriteLine("Counting no of names");
            Console.WriteLine(result);
        }

        static void SampleMax()
        {
            int[] numbers = { 10, 3, 11, 9, 6, 4 };
            var result=numbers.Max();
            Console.WriteLine("The Maximum number is");
            Console.WriteLine(result);
        }

        static void SampleMin()
        {
            int[] numbers = { 10, 3, 11, 9, 6, 4 };
            var result = numbers.Min();
            Console.WriteLine("The Minimum number is");
            Console.WriteLine(result);
        }

        static void SampleSum()
        {
            int[] numbers = { 5, 10, 15 };
            var result= numbers.Sum();
            Console.WriteLine("Sum of numbers");
            Console.WriteLine(result);
        }

    }
}
