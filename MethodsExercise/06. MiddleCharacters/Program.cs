using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace _06._MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            List<char> list = str.ToList();
            int middle = list.Count / 2;

            if(list.Count % 2 != 0)
            {
                Console.WriteLine(list[middle]);
            }
            else
            {
                Console.WriteLine($"{list[middle - 1]}{list[middle]}");
            }   
        }
    }
}
