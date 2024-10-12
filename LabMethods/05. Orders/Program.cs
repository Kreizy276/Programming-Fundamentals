using System;

namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            Order(product, quantity);
        }

        static void Order(string product, int quantity)
        {
            double price = 0;
            double totalPrice = 0;

            switch (product)
            {
                case "coffee":
                    price = 1.5;
                    totalPrice = price * quantity;
                    Console.WriteLine($"{totalPrice:f2}");
                    break;
                case "water":
                    price = 1;
                    totalPrice = price * quantity;
                    Console.WriteLine($"{totalPrice:f2}");
                    break;
                case "coke":
                    price = 1.4;
                    totalPrice = price * quantity;
                    Console.WriteLine($"{totalPrice:f2}");
                    break;
                case "snacks":
                    price = 2;
                    totalPrice = price * quantity;
                    Console.WriteLine($"{totalPrice:f2}");
                    break;
            }

        }
    }
}
