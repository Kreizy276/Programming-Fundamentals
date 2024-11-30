using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _05._NetherRealms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Demon> demons = new();

            string text = Console.ReadLine();
            string[] demonNames = text.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach(string demonName in demonNames)
            {
                Demon newDemon = new()
                {
                    Name = demonName,
                    Health = GetHealth(demonName),
                    Damage = GetDamage(demonName),
                };

                demons.Add(newDemon);
            }

            demons.Sort((a,b) =>  a.Name.CompareTo(b.Name));

            foreach(Demon demon in demons)
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:f2} damage");
            }
        }

        private static int GetHealth(string demonName)
        {
            string regexName = @"[^0-9+\-*/.]";

            int health = 0;
            foreach (Match match in Regex.Matches(demonName, regexName))
            {
                char charConv = char.Parse(match.Value);
                health += charConv;
            }
            return health;
        }

        private static decimal GetDamage(string demonName)
        {
            string regexDamage = @"([\+\-]?\d+(\.\d+)?)";
            string alterDamage = @"[\*\/]";

            decimal damage = 0;
            foreach (Match match in Regex.Matches(demonName, regexDamage))
            {
                damage += decimal.Parse(match.Value);
            }

            foreach(Match match in Regex.Matches(demonName, alterDamage))
            {
                if(match.Value == "*")
                {
                    damage *= 2;
                }
                else if(match.Value == "/")
                {
                    damage /= 2;
                }
            }
            return damage;
        }
    }
    class Demon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public decimal Damage { get; set; }
    }
}
