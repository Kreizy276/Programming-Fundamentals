using System;
using System.Text;

namespace _06._ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new();
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                if (i == text.Length - 1 || text[i] != text[i + 1])
                {
                    sb.Append(text[i]);
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
