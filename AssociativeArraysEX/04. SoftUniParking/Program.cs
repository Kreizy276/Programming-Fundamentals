using System;
using System.Collections.Generic;

namespace _04._SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> usernamePlate = new();

            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();
                string[] data = input.Split();

                string command = data[0];
                string username = data[1];

                switch (command)
                {
                    case "register":
                        string licensePlateNumber = data[2];

                        if (usernamePlate.ContainsKey(username))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                        }
                        else
                        {
                            usernamePlate.Add(username, licensePlateNumber);
                            Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                        }
                        break;
                    default:
                        if (!usernamePlate.ContainsKey(username))
                        {
                            Console.WriteLine($"ERROR: user {username} not found");
                        }
                        else
                        {
                            usernamePlate.Remove(username);
                            Console.WriteLine($"{username} unregistered successfully");
                        }
                        break;
                }
            }
            foreach(var kvp in usernamePlate)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
