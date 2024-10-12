using System;

namespace _06._CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double area = Area(length, width);
            Console.WriteLine(area);
        }

        static double Area(double a, double b)
        {
            return a * b;
        }
    }
}
