using System;
using System.Collections.Generic;

namespace _05._NetherRealms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regexName = @"[A-Za-z]+";
            string regexDamage = @"(?<number>\d+(\.\d+)?)";

            List<Demon> demons = new();

            string text = Console.ReadLine();
            string[] demonNames = text.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach(string demon in demonNames)
            {
                Demon newDemon = new()
                {
                    Name = demon,
                    Health = GetHealth(),
                    Damage = GetDamage(),
                };

                demons.Add(newDemon);
            }
        }

        private static int GetHealth()
        {
            int health = 0;
            return health;
        }

        private static int GetDamage()
        {
            int damage = 0;
            return damage;
        }
    }

    class Demon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
    }
}
