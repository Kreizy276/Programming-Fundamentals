using System;
using System.Text.RegularExpressions;

namespace _01._MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patter = @"\b([A-Z][a-z]+) ([A-Z][a-z]+)";
            string input = Console.ReadLine();

            MatchCollection result = Regex.Matches(input, patter);

            foreach (Match match in result)
            {
                Console.Write($"{match} ");
            }
        }
    }
}
