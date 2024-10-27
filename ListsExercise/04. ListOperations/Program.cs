using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commands = command.Split();

                switch (commands[0])
                {
                    case "Add":
                        int number = int.Parse(commands[1]);
                        AddToList(list, number);
                        break;
                    case "Insert":
                        number = int.Parse(commands[1]);
                        int index = int.Parse(commands[2]);
                        InsertToList(list, number, index);
                        break;
                    case "Remove":
                        index = int.Parse(commands[1]);
                        RemoveFromList(list, index);
                        break;
                    case "Shift":
                        int count = int.Parse(commands[2]);
                        if (commands[1] == "left")
                        {
                            ShiftListLeft(ref list, count);
                        }
                        else if (commands[1] == "right")
                        {
                            ShiftListRight(ref list, count);
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', list));
        }

        static void AddToList(List<int> list, int number)
        {
            list.Add(number);
        }

        static void InsertToList(List<int> list, int number, int index)
        {
            if (index >= 0 && index <= list.Count)
            {
                list.Insert(index, number);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
        }

        static void RemoveFromList(List<int> list, int index)
        {
            if (index >= 0 && index < list.Count)
            {
                list.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
        }

        static void ShiftListLeft(ref List<int> list, int count)
        {
            count %= list.Count;
            list = list.Skip(count).Concat(list.Take(count)).ToList();
        }

        static void ShiftListRight(ref List<int> list, int count)
        {
            count %= list.Count;
            list = list.Skip(list.Count - count).Concat(list.Take(list.Count - count)).ToList();
        }
    }
}
