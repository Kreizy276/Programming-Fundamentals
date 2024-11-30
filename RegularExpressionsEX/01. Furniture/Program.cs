using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @">>(?<Name>[A-Za-z]+)<<(?<Price>\d+\.?\d+)!(?<Quantity>\d+)";
            List<Furniture> furnitures = new();

            string input;
            while ((input = Console.ReadLine()) != "Purchase")
            {
                MatchCollection matches = Regex.Matches(input, regex);

                foreach (Match match in matches)
                {
                    Furniture newFurniture = new(match.Groups["Name"].Value, decimal.Parse(match.Groups["Price"].Value), int.Parse(match.Groups["Quantity"].Value));

                    furnitures.Add(newFurniture);
                }
            }

            decimal sum = 0;
            Console.WriteLine("Bought furniture: ");
            foreach (Furniture furniture in furnitures)
            {
                Console.WriteLine(furniture.Name);
                sum += furniture.Price * furniture.Quantity;
            }
            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }

    class Furniture
    {
        public string Name;
        public decimal Price;
        public int Quantity;

        public Furniture(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }
}
