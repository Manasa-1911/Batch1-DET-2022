using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class SetLinq
    {
        public static void Main()
        {
            SampleDistinct();
            SampleExcept();
            SampleIntersect();
            SampleUnion();
        }
        static void SampleDistinct()
        {
            int[] numbers = { 3, 1, 4, 3, 6, 1, 8, 4 };
            var result = numbers.Distinct();
            Console.WriteLine("Distinct numbers are");
            foreach(int num in result)
            {
                Console.WriteLine(num);
            }
        }

        static void SampleExcept()
        {
            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 2, 4, 5 };

            var result=numbers1.Except(numbers2);
            Console.WriteLine("Output for except function");
            foreach(int num in result)
            {
                Console.WriteLine(num);
            }
        }

        static void SampleIntersect()
        {

            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 2, 4, 5 };

            var result = numbers1.Intersect(numbers2);
            Console.WriteLine("Output for Intersect function");
            foreach (int num in result)
            {
                Console.WriteLine(num);
            }
        }

        static void SampleUnion()
        {
            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 4, 5, 6 };

            var result = numbers1.Union(numbers2);
            Console.WriteLine("Output for Union function");
            foreach (int num in result)
            {
                Console.WriteLine(num);
            }
        }
    }
}
