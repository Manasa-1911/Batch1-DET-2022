using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class LinqAssignment
    {
        public static void Main()
        {
            ContainsSol();
            StringLen();
            MaxSol();
            IndexSol();
        }
        static void ContainsSol()
        {
            string[] names = { "John", "Peter", "Jacob", "Hary", "Jackson" };
            var result = names.Where(x=>x.Contains("o"));
            foreach (string name in result)
            {
                Console.WriteLine(name);
            }
        }

        static void StringLen()
        {
            string[] names = { "believe", "relief", "receipt", "field" };
            var words = from word in names
                        select word;
            foreach (var word in words)
                Console.WriteLine($"{word}--{word.Length}");
        }

        static void MaxSol()
        {
            string[] names = { "John", "Peter", "Jacob", "Hary", "Jackson" };
            var result = names.OrderBy(x => x.Length).Last();
            Console.WriteLine(result);
        }

        static void IndexSol()
        {
            int[] numbers = { 1, 3, 2, 0 };
            string[] names = { "Csharp", "SQL", "LINQ", "Java" };

            Console.WriteLine(names[0]);



        }
    }
}
