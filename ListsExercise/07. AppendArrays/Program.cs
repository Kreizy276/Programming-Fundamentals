using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] segments = input.Split('|');

            int[] arr = segments.Reverse().SelectMany(segment => segment.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)).ToArray();

            Console.WriteLine(string.Join(' ', arr));
        }
    }
}
