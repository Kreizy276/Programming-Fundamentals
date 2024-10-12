using System;

namespace _04._PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Triangle(1, i);
            }

            for (int i = n - 1; i >= 1; i--)
            {
                Triangle(1, i);
            }
        }

        static void Triangle(int start, int end)
        {
            for(int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
