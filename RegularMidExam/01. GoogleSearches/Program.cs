using System;

namespace _01._GoogleSearches
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyPerSearch = double.Parse(Console.ReadLine());
            int numberOfUsers = int.Parse(Console.ReadLine());

            double moneyEarned = 0;
            double totalMoney = 0;

            for(int i = 1 ; i <= numberOfUsers; i++)
            {
                int numberOfSearches = int.Parse(Console.ReadLine());
                if(numberOfSearches <= 1)
                {
                    continue;
                }
                moneyEarned = numberOfSearches * moneyPerSearch;
                if (numberOfSearches > 5)
                {
                    DoubleMoney(ref moneyEarned);
                }
                if (i % 3 == 0)
                {
                    moneyEarned *= 3;
                }
                totalMoney += moneyEarned;
            }

            Console.WriteLine($"Total money earned: {totalMoney:f2}");
        }

        static void DoubleMoney(ref double moneyEarned)
        {
            moneyEarned *= 2;
        }
    }
}
