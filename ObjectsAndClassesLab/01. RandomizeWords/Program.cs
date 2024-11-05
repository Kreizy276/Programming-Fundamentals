using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();
            Random rnd = new Random();

            for(int i = 0; i < list.Count; i++)
            {
                int j = rnd.Next(0, list.Count - 1);
                string temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }
            foreach(string word in list)
            {
                Console.WriteLine(word);
            }
        }
    }
}
