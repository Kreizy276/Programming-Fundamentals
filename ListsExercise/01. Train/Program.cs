using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> passengersInWagon = Console.ReadLine().Split().Select(int.Parse).ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while(command != "end")
            {
                string[] commands = command.Split();

                if (commands[0] == "Add")
                {
                    int passToAdd = int.Parse(commands[1]);
                    passengersInWagon.Add(passToAdd);
                }
                if(commands[0] != "Add")
                {
                    int passToAdd = int.Parse(commands[0]);
                    for(int i = 0; i < passengersInWagon.Count; i++)
                    {
                        if(passengersInWagon[i] + passToAdd <= maxCapacity)
                        {
                            passengersInWagon[i] += passToAdd;
                            break;
                        }
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', passengersInWagon));
        }
    }
}
