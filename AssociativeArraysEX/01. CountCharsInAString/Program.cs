using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> charCount = new();

            string[] words = Console.ReadLine().Split().ToArray();

            //foreach every word in word to characters and if the character in the character array doesnt contains said key we add it
            foreach (string s in words)
            {
                char[] lowerCase = s.ToCharArray();
                foreach(char c in lowerCase)
                {
                    if (!charCount.ContainsKey(c))
                    {
                        charCount.Add(c, 1);
                    }
                    else
                    {
                        charCount[c]++;
                    }
                }
            }
            
            foreach(var kvp in charCount)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
