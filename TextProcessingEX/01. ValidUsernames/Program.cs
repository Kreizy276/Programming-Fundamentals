using System;
using System.Linq;

namespace _01._ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ").ToArray();

            foreach(string username in usernames)
            {
                if(IsValidOrNot(username))
                {
                    Console.WriteLine(username);
                }
            }
        }

        static bool IsValidOrNot(string username)
        {
            if (!(username.Length >= 3 && username.Length <= 16))
            return false;

            return (username.All(character => char.IsLetterOrDigit(character) || character == '-' || character == '_'));
        }
    }
}
