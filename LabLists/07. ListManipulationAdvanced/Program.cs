using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (true)
            {
                if (command == "end")
                {
                    break;
                }

                string[] arr = command.Split();

                switch (arr[0])
                {
                    case "Contains":
                        int number = int.Parse(arr[1]);
                        ContainsNumber(list, number);
                        break;
                    case "PrintEven":
                        PrintEven(list);
                        break;
                    case "PrintOdd":
                        PrintOdd(list);
                        break;
                    case "GetSum":
                        GetSum(list);
                        break;
                    case "Filter":
                        string comparisonOP = arr[1];
                        int number2 = int.Parse(arr[2]);
                        Filter(list, comparisonOP, number2); 
                        break;
                }
                command = Console.ReadLine();
            }
        }

        static void ContainsNumber(List<int> list, int number)
        {
            bool result = list.Contains(number);

            Console.WriteLine(result ? "Yes" : "No such number");
        }

        static void PrintEven(List<int> list)
        {
            var evenNums = list.Where(x => x % 2 == 0).ToList();
            Console.WriteLine(string.Join(' ', evenNums));
        }

        static void PrintOdd(List<int> list)
        {
            var oddNums = list.Where(x => x % 2 != 0).ToList();
            Console.WriteLine(string.Join(' ', oddNums));
        }

        static void GetSum(List<int> list)
        {
            int sum = list.Sum();
            Console.WriteLine(sum);
        }

        static void Filter(List<int> list, string comparisonOP, int number2)
        {
            List<int> newList = new();

            switch(comparisonOP)
            {
                case "<":
                    newList = list.Where(x => x < number2).ToList();
                    break;
                case ">":
                    newList = list.Where(x => x > number2).ToList();
                    break;
                case ">=":
                    newList = list.Where(x => x >= number2).ToList();
                    break;
                case "<=":
                    newList = list.Where(x => x <= number2).ToList();
                    break;
            }
            Console.WriteLine(string.Join(' ', newList));
        }
    }
}
