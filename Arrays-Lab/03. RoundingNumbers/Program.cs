using System;
using System.Linq;

namespace _03._RoundingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray(); // creating array of numbers that reads and splits with space parsing to double and adding them to the array

            int[] roundedNumbers = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                double currentNumber = numbers[i];
                roundedNumbers[i] = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);

                Console.WriteLine($"{currentNumber} => {roundedNumbers[i]}");
            }
        }
    }
}
