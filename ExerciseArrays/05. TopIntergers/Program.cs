using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._TopIntergers
{
   internal class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> topIntegers = new();

            int maxRight = int.MinValue;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] > maxRight)
                {
                    topIntegers.Add(numbers[i]);
                    maxRight = numbers[i];
                }
            }

            topIntegers.Reverse();

            Console.WriteLine(string.Join(" ", topIntegers));
        }
    }
}
