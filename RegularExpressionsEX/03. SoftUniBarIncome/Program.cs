using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03._SoftUniBarIncome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @"%(?<Customer>[A-Z][a-z]+)%<(?<Product>\w+)>(\w+)?\|(?<Count>\d+)\|\1?(?<Price>\d+(\.\d+)?)\$";

            List<Customer> customers = new();

            string input;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match match = Regex.Match(input, regex);

                if (match.Success)
                {
                    Customer newCustomer = new Customer(
                        match.Groups["Customer"].Value,
                        match.Groups["Product"].Value,
                        int.Parse(match.Groups["Count"].Value),
                        decimal.Parse(match.Groups["Price"].Value)
                    );

                    customers.Add(newCustomer);
                }
            }

            decimal totalIncome = 0;
            foreach (Customer customer in customers)
            {
                decimal sum = customer.Count * customer.Price;
                Console.WriteLine($"{customer.CustomerName}: {customer.ProductName} - {sum:f2}");
                totalIncome += sum;
            }
            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }

    class Customer
    {
        public string CustomerName { get; set; }
        public string ProductName { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }

        public Customer(string name, string productName, int count, decimal price)
        {
            CustomerName = name;
            ProductName = productName;
            Count = count;
            Price = price;
        }
    }
}
