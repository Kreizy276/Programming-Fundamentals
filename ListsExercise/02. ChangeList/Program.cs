using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while(command != "end")
            {
                string[] commands = command.Split();

                switch (commands[0])
                {
                    case "Delete":
                        int number = int.Parse(commands[1]);
                        DeleteFromList(number, list);
                        break;
                    case "Insert":
                        number = int.Parse (commands[1]);
                        int index = int.Parse(commands[2]);
                        InsertToList(list, number, index);
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ', list));
        }

        static void DeleteFromList(int number, List<int> list)
        {
            list.RemoveAll(x => x == number);
        }

        static void InsertToList(List<int> list, int number, int index)
        {
            list.Insert(index, number);
        }
    }
}
