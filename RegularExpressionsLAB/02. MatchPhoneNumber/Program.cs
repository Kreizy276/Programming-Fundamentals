using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<=^|\s)\+359 ((\d{1} \d{3} \d{4})|(\d{1}-\d{3}-\d{4}))\b";
            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);

            var matchedPhones = matches.Cast<Match>().Select(match => match.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}