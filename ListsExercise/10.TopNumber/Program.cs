using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new();

            int n = int.Parse(Console.ReadLine());

            for(int i = 1 ; i <= n; i++)
            {
                if (IsTopNumber(i))
                {
                    list.Add(i);
                }
            }

            foreach(int number in list)
            {
                Console.WriteLine(number);
            }
        }

        static bool IsTopNumber(int i)
        {            
            int x = i;
            int digits = 0;
            int sum = 0;

            while(x != 0)
            {
                digits = x % 10;
                x /= 10;
                sum += digits;
            }
            return sum % 8 == 0 && ContainsOddDigit(i);
        }

        static bool ContainsOddDigit(int i)
        {
            bool isOdd = false;
            int x = i;
            int digits = 0;
            while(x != 0)
            {
                digits = x % 10;
                if(digits % 2 != 0)
                {
                    isOdd = true;
                    break;
                }
                x /= 10;
            }
            return isOdd;
        }
    }
}
