using System;
using System.Collections.Generic;

namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> productPrice = new();
            Dictionary<string, int> productQuantity = new();
            string command = Console.ReadLine();

            while (command != "buy")
            {
                string[] data = command.Split();

                string product = data[0];
                double price = double.Parse(data[1]);
                int quantity = int.Parse(data[2]);

                if(!productPrice.ContainsKey(product))
                {
                    productPrice[product] = price;
                    productQuantity[product] = quantity;
                }
                else
                {
                    productPrice[product] = price; 
                    productQuantity[product] += quantity; 
                }
                command = Console.ReadLine();
            }

            foreach(var product in productPrice)
            {
                string name = product.Key;
                double totalPrice = product.Value * productQuantity[name];
                Console.WriteLine($"{name} -> {totalPrice:f2}");
            }
        }
    }
}
