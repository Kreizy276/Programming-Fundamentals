using System;

namespace _07._RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int repeating = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatingString(a, repeating)); 
        }

        static string RepeatingString(string str, int n)
        {            
            string newLine = "";

            for (int i = 1; i <= n; i++)
            {
                newLine += str;
            }

            return newLine;
        }
    }
}
