using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Text;

namespace _05._DigitsLettersAndOthers
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            string text = Console.ReadLine();

            StringBuilder digits = new();
            StringBuilder letters = new();
            StringBuilder symbols = new();

            foreach (char ch in text)
            {
                if (char.IsDigit(ch))
                {
                    digits.Append(ch);
                }
                else if(char.IsLetter(ch))
                {
                    letters.Append(ch);
                }
                else
                {
                    symbols.Append(ch);
                }
            }
            Console.WriteLine($"{digits}\n{letters}\n{symbols}");
        }
    }
}
