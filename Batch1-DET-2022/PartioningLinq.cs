using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class PartioningLinq
    {
        public static void Main()
        {
            SampleSkip();
            SampleSkipWhile();
            SampleTake();
            SampleTakeWhile();
        }
        static void SampleSkip()
        {
            string[] words = { "one", "two", "three", "four", "five", "six" };

            var result = words.Skip(4);

            Console.WriteLine("Skips the first 4 words:");
            foreach (string word in result)
                Console.WriteLine(word);
        }

        static void SampleSkipWhile()
        {
            string[] words = { "one", "two","three", "four", "five", "six" };

            var result = words.SkipWhile(w => w.Length == 3);

            Console.WriteLine("Skips words while the condition is met:");
            foreach (string word in result)
                Console.WriteLine(word);
        }

        static void SampleTake()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = numbers.Take(5);

            Console.WriteLine("Takes the first 5 numbers only:");
            foreach (int number in result)
                Console.WriteLine(number);
        }

        static void SampleTakeWhile()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = numbers.TakeWhile(n => n < 5);

           Console.WriteLine("Takes numbers one by one, and stops when condition is no longer met:");
            foreach (int number in result)
               Console.WriteLine(number);
        }
    }
}
