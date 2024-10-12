using System;

namespace _10._MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int absoluteValue = Math.Abs(n); 

            int result = GetMultipleOfEvenAndOdds(absoluteValue);
            Console.WriteLine(result);
        }

        static int GetMultipleOfEvenAndOdds(int n)
        {
            int evenSum = 0;
            int oddSum = 0;

            while (n > 0)
            {
                int digits = n % 10;
                n /= 10;

                if (digits % 2 == 0)
                {
                    evenSum = GetSumOfEvenDigits(digits, evenSum);
                }
                else
                {
                    oddSum = GetSumOfOddDigits(digits, oddSum);
                }
            }

            return evenSum * oddSum; 
        }

        static int GetSumOfEvenDigits(int digits, int evenSum)
        {
            return evenSum + digits; 
        }

        static int GetSumOfOddDigits(int digits, int oddSum)
        {
            return oddSum + digits; 
        }
    }
}
