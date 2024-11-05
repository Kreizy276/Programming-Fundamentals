using System;
using System.Collections.Generic;

namespace _06._StoreBoxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] data = command.Split();

                string serialNumber = data[0];
                string itemName = data[1];
                int itemQuantity = int.Parse(data[2]);
                double itemPrice = double.Parse(data[3]);

                Box box = new Box
                {
                    SerialNumber = serialNumber,
                    Item = new Item
                    {
                        Name = itemName,
                        Price = itemPrice
                    },
                    ItemQuantity = itemQuantity,
                    PriceForBox = itemQuantity * itemPrice
                };

                boxes.Add(box);
                command = Console.ReadLine();
            }

            boxes.Sort((a, b) => b.PriceForBox.CompareTo(a.PriceForBox));
          
            foreach (Box box in boxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForBox:f2}");
            }
        }
    }

    class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public double PriceForBox { get; set; }
    }
}
