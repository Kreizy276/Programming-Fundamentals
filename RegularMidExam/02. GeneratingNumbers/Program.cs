using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace _02._GeneratingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while(command != "END")
            {
                List<int> numbers = new();
                List<string> text = new();
                CommandFormation(ref numbers, ref text, ref command);
                string action = string.Join(' ', text);

                switch (action)
                {
                    case "add to start":
                        AddNumbersToList(numbers, list);
                        break;
                    case "remove greater than":
                        RemoveGreaterThan(numbers, list);
                        break;
                    case "replace":
                        ReplaceNumber(list, numbers);
                        break;
                    case "remove at index":
                        RemoveAtIndex(list, numbers);
                        break;
                    case "find even":
                        List<int> evenNums = new();
                        FindEven(list, evenNums);
                        Console.WriteLine(string.Join(' ', evenNums));
                        break;
                    case "find odd":
                        List<int> oddNums = new();
                        FindOdd(list, oddNums);
                        Console.WriteLine(string.Join(' ', oddNums));
                        break;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", list));
        }

        static void CommandFormation(ref List<int> numbers, ref List<string> text, ref string command)
        {
            string[] commands = command.Split();

            foreach(var item in commands)
            {
                if(int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    text.Add(item);
                }
            }
        }

        static void AddNumbersToList(List<int> numbers, List<int> list)
        {
            for(int i = numbers.Count; i > 0; i--)
            {
                list.Insert(0, numbers[i - 1]);
            }
        }

        static void RemoveGreaterThan(List<int> numbers, List<int> list)
        {
            list.RemoveAll(x => x > numbers[0]);

            /*for(int i = 0; i < list.Count; i++)
            {
                if (list[i] > numbers[0])
                {
                    list.RemoveAt(i);
                    i--;
                }
            }*/
        }

        static void ReplaceNumber(List<int> list, List<int> numbers)
        {
            int indexToReplace = list.IndexOf(numbers[0]);

            if(indexToReplace != -1)
            {
                list[indexToReplace] = numbers[1];
            }
        }

        static void RemoveAtIndex(List<int> list, List<int> numbers)
        {
            if (numbers[0] >= 0 && numbers[0] < list.Count)
            {
                list.RemoveAt(numbers[0]);
            }
        }

        static void FindEven(List<int> list, List<int> evenNums)
        {
            foreach(var number in list)
            {
                if(number % 2 == 0)
                {
                    evenNums.Add(number);
                }
            }
        }
        static void FindOdd(List<int> list, List<int> oddNums)
        {
            foreach (var number in list)
            {
                if (number % 2 != 0)
                {
                    oddNums.Add(number);
                }
            }
        }
    }
}
