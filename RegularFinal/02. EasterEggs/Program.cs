using System;
using System.Text.RegularExpressions;

namespace _02._EasterEggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[@#]+(?<Color>[a-z]{3,})[@#]+[^a-zA-Z0-9]*\/+(?<Amount>\d+)\/+";

            string eggs = Console.ReadLine();

            MatchCollection matches = Regex.Matches(eggs, pattern);

            foreach (Match match in matches)
            {
                string color = match.Groups["Color"].Value;
                string amount = match.Groups["Amount"].Value;
                Console.WriteLine($"You found {amount} {color} eggs!");
            }
        }
    }
}
