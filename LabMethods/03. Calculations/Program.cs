using System;

namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();   
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            

            switch(operation)
            {
                case "add":
                    Addition(num1, num2);
                    break;
                case "multiply":
                    Multiplication(num1, num2);
                    break;
                case "subtract":
                    Subtraction(num1, num2);
                    break;
                case "divide":
                    Division(num1, num2);
                    break;

            }
        }

        static void Addition(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine(sum);
        }

        static void Multiplication(int num1, int num2)
        {
            int sum = num1 * num2;
            Console.WriteLine(sum);
        }

        static void Subtraction(int num1, int num2)
        {
            int sum = num1 - num2;
            Console.WriteLine(sum);
        }

        static void Division(int num1, int num2)
        {
            double sum = num1 / num2;
            Console.WriteLine(sum);
        }
    }
}
