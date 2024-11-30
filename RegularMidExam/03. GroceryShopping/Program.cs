using System;
using System.Collections.Generic;
using System.Linq;

namespace GroceryShopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split('|').ToList();
            string command = Console.ReadLine();

            while (command != "Shop!")
            {
                string[] parts = command.Split('%');

                switch (parts[0])
                {
                    case "Important":
                        string importantProduct = parts[1];
                        Important(list, importantProduct);
                        break;
                    case "Add":
                        string addProduct = parts[1];
                        Add(list, addProduct);
                        break;
                    case "Swap":
                        string product1 = parts[1];
                        string product2 = parts[2];
                        Swap(list, product1, product2);
                        break;
                    case "Remove":
                        string removeProduct = parts[1];
                        Remove(list, removeProduct);
                        break;
                    case "Reversed":
                        list.Reverse();
                        break;
                }

                command = Console.ReadLine();
            }

            PrintList(list);
        }

        static void Important(List<string> list, string product)
        {
            if (list.Contains(product))
            {
                list.Remove(product);
            }
            list.Insert(0, product);
        }

        static void Add(List<string> list, string product)
        {
            if (!list.Contains(product))
            {
                list.Add(product);
            }
            else
            {
                Console.WriteLine("The product is already in the list.");
            }
        }

        static void Swap(List<string> list, string product1, string product2)
        {
            if (list.Contains(product1) && list.Contains(product2))
            {
                int index1 = list.IndexOf(product1);
                int index2 = list.IndexOf(product2);
                list[index1] = product2;
                list[index2] = product1;
            }
            else
            {
                string missingProduct = !list.Contains(product1) ? product1 : product2;
                Console.WriteLine($"Product {missingProduct} missing!");
            }
        }

        static void Remove(List<string> list, string product)
        {
            if (list.Contains(product))
            {
                list.Remove(product);
            }
            else
            {
                Console.WriteLine($"Product {product} isn't in the list.");
            }
        }

        static void PrintList(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {list[i]}");
            }
        }
    }
}
