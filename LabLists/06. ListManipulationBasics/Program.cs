using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace _06._ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while(true)
            {               
                if(command == "end")
                {
                    break;
                }

                string[] arr = command.Split();
                int number = int.Parse(arr[1]);

                switch(arr[0])
                {
                    case "Add":
                        AddToList(list, number);
                        break;
                    case "Remove":
                        RemoveFromList(list, number);
                        break;
                    case "RemoveAt":
                        RemoveAtFromList(list, number);
                        break;
                    case "Insert":
                        int index = int.Parse(arr[2]);
                        InsertToList(list, number, index);
                        break;                
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', list));
        }

        static List<int> AddToList(List<int> list, int number)
        {
            list.Add(number);
            return list;
        }

        static List<int> RemoveFromList(List<int> list, int number)
        {
            list.Remove(number);
            return list;
        }

        static List<int> RemoveAtFromList(List<int> list, int number)
        {
            list.RemoveAt(number);
            return list;
        }

        static List<int> InsertToList(List<int> list, int number, int index)
        {
            list.Insert(index, number);
            return list;
        }
    }
}
