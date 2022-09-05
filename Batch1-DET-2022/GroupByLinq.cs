using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class GroupByLinq
    {
        public static void Main()
        {
            String_GroupBy();
            String_GroupByCount();
        }
        private static void String_GroupBy()
        {
            List<string> words = new List<string> { "basket", "blueberry", "chipanze", "abacus", "banana", "apple", "cheeze" };
            var wordGroups = from w in words
                             group w by w[0] into g
                             select new { FirstLetter = g.Key, Words = g };

            foreach (var item in wordGroups)
            {
                Console.WriteLine("Words start with the" + "letter '{0}':", item.FirstLetter);

                foreach (var w in item.Words)
                {
                    Console.WriteLine(w);
                }
            }
        }

        private static void String_GroupByCount()
        {
            List<string> words = new List<string> { "basket", "blueberry", "chipanze", "abacus", "banana", "apple", "cheeze" };
            var wordGroups = from w in words
                             group w by w.Length into g
                             select new { Noofwords = g.Key, Words = g };

            foreach (var item in wordGroups)
            {
                Console.WriteLine("Words start with the " + "count '{0}':", item.Noofwords);

                foreach (var w in item.Words)
                {
                    Console.WriteLine(w);
                }
            }
        }
    }
}
