using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class ElementLinq
    {
        public static void Main()
        {
            SampleElementAt();
            SampleElementAtOrDefault();
            SampleFirst();
            SampleFirstConditional();
            SampleFirstOrDefault();
            SampleLast();
            SampleLastOrDefault();
            SampleLastOrDefaultConditional();
            SampleSingle();
            SampleSingleOrDefault();
        }
        static void SampleElementAt()
        {
            string[] words = { "Apple", "Orange", "Manago" };

            var result = words.ElementAt(1);

            Console.WriteLine("Element at index 1 in the array is:");
            Console.WriteLine(result);
        }

        static void SampleElementAtOrDefault()
        {
            string[] colors = { "Red", "Green", "Blue" };

            var resultIndex1 = colors.ElementAtOrDefault(1);

            var resultIndex10 = colors.ElementAtOrDefault(10);

            Console.WriteLine("Element at index 1 in the array contains:");
            Console.WriteLine(resultIndex1);

            Console.WriteLine("Element at index 10 in the array does not exist:");
            Console.WriteLine(resultIndex10 == null);
        }

        static void SampleFirst()
        {
            string[] fruits = { "Banana", "Apple", "Orange" };

            var result = fruits.First();

           Console.WriteLine("First element in the array is:");
           Console.WriteLine(result);
        }

        static void SampleFirstConditional()
        {
            string[] countries = { "Denmark", "Sweden", "Norway" };

            var result = countries.First(c => c.Length == 6);

           Console.WriteLine("First element with a length of 6 characters:");
           Console.WriteLine(result);
        }

        static void SampleFirstOrDefault()
        {
            string[] countries = { "Denmark", "Sweden", "Norway" };
            string[] empty = { };

            var result = countries.FirstOrDefault();

            var resultEmpty = empty.FirstOrDefault();

           Console.WriteLine("First element in the countries array contains:");
           Console.WriteLine(result);

           Console.WriteLine("First element in the empty array does not exist:");
           Console.WriteLine(resultEmpty == null);
        }

        static void SampleLast()
        {
            int[] numbers = { 7, 3, 5 };

            var result = numbers.Last();

            Console.WriteLine("Last number in array is:");
            Console.WriteLine(result);
        }

        static void SampleLastOrDefault()
        {
            string[] words = { "one", "two", "three" };
            string[] empty = { };

            var result = words.LastOrDefault();

            var resultEmpty = empty.LastOrDefault();

            Console.WriteLine("Last element in the words array contains:");
            Console.WriteLine(result);

            Console.WriteLine("Last element in the empty array does not exist:");
            Console.WriteLine(resultEmpty == null);
        }

        static void SampleLastOrDefaultConditional()
        {
            string[] words = { "one", "two", "three" };

            var result = words.LastOrDefault(w => w.Length == 3);

            var resultNoMatch = words.LastOrDefault(w => w.Length == 2);

            Console.WriteLine("Last element in the words array having a length of 3:");
            Console.WriteLine(result);

            Console.WriteLine("Last element in the empty array having a length of 2 does not exist:");
            Console.WriteLine(resultNoMatch == null);
        }

        static void SampleSingle()
        {
            string[] names1 = { "Peter" };
            string[] names3 = { "Peter", "Joe", "Wilma" };
            string[] empty = { };

            var result1 = names1.Single();

            Console.WriteLine("The only name in the array is:");
            Console.WriteLine(result1);

            try
            {
                // This will throw an exception because array contains no elements
                var resultEmpty = empty.Single();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                // This will throw an exception as well because array contains more than one element
                var result3 = names3.Single();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void SampleSingleOrDefault()
        {
            string[] names1 = { "Peter" };
            string[] names3 = { "Peter", "Joe", "Wilma" };
            string[] empty = { };

            var result1 = names1.SingleOrDefault();

            var resultEmpty = empty.SingleOrDefault();

            Console.WriteLine("The only name in the array is:");
            Console.WriteLine(result1);

            Console.WriteLine("As array is empty, SingleOrDefault yields null:");
            Console.WriteLine(resultEmpty == null);

            try
            {
                // This will throw an exception as well because array contains more than one element
                var result3 = names3.SingleOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
