using System;

namespace _03._CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch1 = char.Parse(Console.ReadLine());
            char ch2 = char.Parse(Console.ReadLine());

            CharactersInRange(ch1, ch2);
        }

        static void CharactersInRange(char ch1, char ch2)
        {
            char character = default;
            char copyCh1 = ch1;
            char copyCh2 = ch2;

            if(ch1 < ch2)
            {
                ch1 = ch2;
            }

            for(int i = ch1; i <= ch2; i++)
            {
                character = (char)i;
                Console.Write($"{character} ");
            }
        }
    }
}
