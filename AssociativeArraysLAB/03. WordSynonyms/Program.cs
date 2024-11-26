using System;
using System.Collections.Generic;
using System.Threading;

namespace _03._WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> wordSynonym = new();

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!wordSynonym.ContainsKey(word))
                {
                    wordSynonym[word] = new List<string>();
                }

                wordSynonym[word].Add(synonym);
            }

            foreach(KeyValuePair<string, List<string>> pair in wordSynonym)
            {
                Console.WriteLine($"{pair.Key} - {string.Join(", ", pair.Value)}");
            }
        }
    }
}
