using System;
using System.Text;

namespace _04._CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Decrypt");
            Console.WriteLine("2. Encrypt");

            string choice = Console.ReadLine();
            string result = string.Empty;

            string text;
            switch (choice)
            {
                case "1":
                    Console.Write($"Enter the message to decrypt: ");
                    text = Console.ReadLine();
                    result = Decrypt(text);
                    break;
                case "2":
                    Console.Write($"Enter the message to encrypt: ");
                    text = Console.ReadLine();
                    result = Encrypt(text);
                    break;
            }

            Console.WriteLine(result);
        }

        static string Encrypt(string text)
        {
            StringBuilder sb = new();
            foreach (char ch in text)
            {
                if (char.IsLetter(ch))
                {
                    char offset = char.IsUpper(ch) ? 'A' : 'a';
                    char shiftedCh = (char)((ch - offset + 3) % 26 + offset);
                    sb.Append(shiftedCh);
                }
                else
                {
                    sb.Append(ch);
                }
            }
            return sb.ToString();

        }

        static string Decrypt(string text)
        {
            StringBuilder sb = new();
            foreach (char ch in text)
            {
                if (char.IsLetter(ch))
                {
                    char offset = char.IsUpper(ch) ? 'A' : 'a';
                    char shiftedCh = (char)((ch - offset + 3 - 26) % 26 + offset);
                    sb.Append(shiftedCh);
                }
                else
                {
                    sb.Append(ch);
                }
            }

            return sb.ToString();
        }
    }
}
