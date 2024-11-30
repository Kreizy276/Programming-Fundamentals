using System;

namespace Lab;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double sum = n / 1000d;
        Console.WriteLine($"{sum:f2}");
    }
}