using System;

namespace _02._VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            Console.WriteLine(Vowels(word));
        }

        static int Vowels(string word)
        {
            int vowels = 0;

            word = word.ToLower();
            char[] characters = word.ToCharArray();


            for(int i = 0; i < characters.Length; i++)
            {
                switch (characters[i])
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        vowels++;
                        break;
                }
            }               
            return vowels;
        }
    }
}
