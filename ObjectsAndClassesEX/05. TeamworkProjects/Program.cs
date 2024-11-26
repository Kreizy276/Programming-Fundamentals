using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._TeamworkProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> teams = new();

            // Register teams
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('-');
                string creator = input[0];
                string teamName = input[1];

                if (teams.Any(t => t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teams.Any(t => t.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    teams.Add(new Team(teamName, creator));
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }

            // Add members to teams
            string command;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] input = command.Split("->");
                string user = input[0];
                string teamName = input[1];

                Team team = teams.FirstOrDefault(t => t.Name == teamName);

                if (team == null)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (teams.Any(t => t.Members.Contains(user)) || teams.Any(t => t.Creator == user))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }
                else
                {
                    team.Members.Add(user);
                }
            }

            // Separate valid and disbanded teams
            List<Team> validTeams = teams.Where(t => t.Members.Count > 0).ToList();
            List<Team> disbandedTeams = teams.Where(t => t.Members.Count == 0).ToList();

            // Sort and print valid teams
            foreach (var team in validTeams.OrderByDescending(t => t.Members.Count).ThenBy(t => t.Name))
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.Creator}");
                foreach (var member in team.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            // Print disbanded teams
            Console.WriteLine("Teams to disband:");
            foreach (var team in disbandedTeams.OrderBy(t => t.Name))
            {
                Console.WriteLine(team.Name);
            }
        }
    }

    class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }

        public Team(string name, string creator)
        {
            Name = name;
            Creator = creator;
            Members = new List<string>();
        }
    }
}