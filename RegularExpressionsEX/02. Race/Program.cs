using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regexName = @"[A-Za-z]";
            string regexDigits = @"\d";

            List<string> names = Console.ReadLine().Split(", ").ToList();
            SortedDictionary<string, int> participantKilometers = new();

            int totalKilometers = 0;
            string input;
            while ((input = Console.ReadLine()) != "end of race")
            {
                MatchCollection matchedNames = Regex.Matches(input, regexName);
                string name = string.Concat(matchedNames.Cast<Match>().Select(match => match.Value));

                if (names.Contains(name))
                {
                    MatchCollection matchedDigits = Regex.Matches(input, regexDigits);
                    var digitConv = matchedDigits.Cast<Match>().Select(x => int.Parse(x.Value)).ToList();
                    totalKilometers = digitConv.Sum();

                    if (participantKilometers.ContainsKey(name))
                    {
                        participantKilometers[name] += totalKilometers;
                    }
                    else
                    {
                        participantKilometers[name] = totalKilometers;
                    }
                }
            }

            var topRacers = participantKilometers.OrderByDescending(km => km.Value).Take(3).ToList();

            string[] positions = { "1st", "2nd", "3rd" };

            for (int i = 0; i < topRacers.Count; i++)
            {
                var racer = topRacers[i];
                Console.WriteLine($"{positions[i]} place: {racer.Key}");
            }
        }
    }
}
