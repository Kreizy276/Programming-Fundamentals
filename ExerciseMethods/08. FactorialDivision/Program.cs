using System;

namespace _08._FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            double result = FactorialResult(n1, n2);

            Console.WriteLine($"{result:f2}"); 
        }

        static double FactorialResult(int n1, int n2)
        {
            double fact1 = 1;
            double fact2 = 1;

            for(int i = 1; i <= n1; i++)
            {
                fact1 *= i;
            }

            for(int i = 1 ; i <= n2; i++)
            {
                fact2 *= i;
            }

            return FactorialCalculation(fact1, fact2);
        }

        static double FactorialCalculation(double fact1, double fact2)
        {
            return fact1 / fact2;
        }
    }
}
