using System;

namespace _02._SumDigits
{
    internal class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            int copyN = num;
            int sum = 0;

            while(copyN > 0)
            {
                int digits = copyN % 10;
                copyN /= 10;

                sum += digits;

            }            
            Console.WriteLine(sum);
        }
    }
}
