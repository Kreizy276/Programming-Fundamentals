﻿using System;

namespace _01._DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[7] {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

            int input = int.Parse(Console.ReadLine());

            if(input >= 1 && input <= 7)
            {
                Console.WriteLine(days[input - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
