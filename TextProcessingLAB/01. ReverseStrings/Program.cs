using System;
using System.Linq;
using System.Text;

namespace _01._ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            while (text != "end")
            {
                string reversedString = new string(text.Reverse().ToArray());
                Console.WriteLine($"{text} = {reversedString}");
                text = Console.ReadLine();
            }
        }

        /*static StringBuilder ReverseString(string text, StringBuilder reversedString)
        {
            string reversed = new string(reversedString.ToString().Reverse().ToArray());
            return new StringBuilder(reversed);
        }*/
    }
}
