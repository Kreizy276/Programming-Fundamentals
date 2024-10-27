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
            List<string> names = new();

            int n = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            for(int i = 1; i <= n; i++)
            {
                if (command == $"{command} is going!")
                {
                    AddToList(names, command);
                }
                if(command == $"{command} is not going!")
                {
                    names.Remove(command);
                }
            }
        }

        static void AddToList(List<string> names, string command)
        {

        }

        static void CheckList(List<string> names, string command)
        {
            string check = "";
            for(int i = 0; i < names.Count; i++)
            {
                if(names[i] == command)
                {
                    check = names[i];
                }
            }
        }

        static void RemoveFromList(List<string> names, string command)
        {
            
        }
    }
}
