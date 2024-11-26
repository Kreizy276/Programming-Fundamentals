using System;
using System.Collections.Generic;

namespace _05._TeamworkProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> teams = new();

            for(int i = 1 ; i <= n; i++)
            {
                string command = Console.ReadLine();
                string[] data = command.Split('-');

                string creator = data[0];
                string teamName = data[1];
            }
        }
    }

    class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }
    }
}
