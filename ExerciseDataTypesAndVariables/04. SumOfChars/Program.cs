using System;

namespace _04._SumOfChars
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for(int i = 1; i <= n; i++)
            {
                char letter = char.Parse(Console.ReadLine());

                int convert = Convert.ToInt32(letter);

                sum += convert;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
