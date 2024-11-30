using System;
using System.Linq;

namespace _04._ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();

            string[] reversedString = arr.Reverse().ToArray();

            for(int i = 0; i < reversedString.Length; i++)
            {
                Console.Write($"{reversedString[i]} ");
            }
        }
    }
}
