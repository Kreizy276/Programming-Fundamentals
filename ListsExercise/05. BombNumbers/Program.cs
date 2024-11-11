using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _05._BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] specialNumAndPower = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int specialNumber = specialNumAndPower[0];
            int power = specialNumAndPower[1];

            for(int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] == specialNumber)
                {
                    int start = Math.Max(i - power, 0);
                    int end = Math.Min(i + power, numbers.Count - 1);
                    numbers.RemoveRange(start, end - start + 1);
                    i = start - 1;
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
