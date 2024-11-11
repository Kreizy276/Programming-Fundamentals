using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace _03._HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); 
            List<string> guests = new List<string>(); 

            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                string[] parts = command.Split(); 
                string name = parts[0];

                if (command.Contains("is going!"))
                {
                    if (guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guests.Add(name);
                    }
                }
                else if (command.Contains("is not going!"))
                {
                    if (guests.Contains(name))
                    {
                        guests.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }

            foreach (string guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
