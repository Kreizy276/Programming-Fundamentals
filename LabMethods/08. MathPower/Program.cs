using System;

namespace _08._MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseN = double.Parse(Console.ReadLine());
            double powerN = double.Parse(Console.ReadLine());

            Console.WriteLine(MathPower(baseN, powerN));
        }

        static double MathPower(double x, double y)
        {
            double result = 1;

            for(int i = 1; i <= y; i++)
            {
                result *= x;
            }

            return result;
        }
    }
}
