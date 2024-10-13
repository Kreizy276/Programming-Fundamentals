using System;

namespace _06._MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            MiddleCharacter(word);
        }

        static void MiddleCharacter(string word)
        {
            char[] characters = word.ToCharArray();

            if(characters.Length % 2 == 0)
            {
                Console.WriteLine(characters.Length / 2);
            }
        }
    }
}
