using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int magicNumber = int.Parse(Console.ReadLine());

            int firstN = 0;
            int secondN = 0;

            for(int i = 0; i < numbers.Count - 1; i++)
            {
                for(int j = i + 1; j < numbers.Count; j++)
                {
                    firstN = numbers[i];
                    secondN = numbers[j];

                    if(firstN + secondN == magicNumber)
                    {
                        Console.WriteLine($"{firstN} {secondN}");
                    }
                }
            }
        }
    }
}
