using System;

namespace _07._WaterOverflow
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for(int i = 1; i <= n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if(sum + x > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    sum += x;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
