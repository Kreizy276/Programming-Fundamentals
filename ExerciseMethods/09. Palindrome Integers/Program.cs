using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;

namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Palindrome(command);
        }

        static void Palindrome(string command)
        {
            while (command != "END")
            { 
                int number = int.Parse(command);
                int copyNumber = number;
                List<int> list = new();

                while(copyNumber > 0)
                {                    
                    int digits = copyNumber % 10;
                    copyNumber /= 10;
                    list.Add(digits);
                }

                int reversedNumber = ReversedNumber(list);

                Console.WriteLine(reversedNumber == number ? "true" : "false");

                command = Console.ReadLine();
            }

            static int ReversedNumber(List<int> list)
            {
                string concat = string.Concat(list.Select(n => n.ToString()));
                return int.Parse(concat);
            }
        }
    }
}
