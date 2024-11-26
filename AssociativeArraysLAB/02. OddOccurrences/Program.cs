using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();

            Dictionary<string, int> occurrences = new();

            foreach (string word in words)
            {
                string lowerCase = word.ToLower();

                if (!occurrences.ContainsKey(lowerCase))
                {
                    occurrences[lowerCase] = 1;
                }
                else
                {
                    occurrences[lowerCase]++;
                }
            }

            foreach((string word, int count) in occurrences)
            {
                if(count % 2 != 0)
                {
                    Console.Write($"{word} ");
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
