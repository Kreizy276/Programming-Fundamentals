using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> counts = new();

            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            foreach(double number in numbers)
            {
                if (!counts.ContainsKey(number))
                {
                    counts.Add(number, 0);
                }

                counts[number]++;
            }

            foreach((double number, int count) in counts)
            {
                Console.WriteLine($"{number} -> {count}");
            }
        }
    }
}
