using System;

namespace _02._PoundsToDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double sum = n * 1.31;
            Console.WriteLine($"{sum:f3}");
        }
    }
}
