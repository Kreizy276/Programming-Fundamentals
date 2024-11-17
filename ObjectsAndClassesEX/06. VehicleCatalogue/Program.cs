using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Vehicle> vehicles = new();

            while(command != "End")
            {
                string[] data = command.Split();

                string type = Capitalize(data[0]);
                string model = data[1];
                string color = data[2];
                int hp = int.Parse(data[3]);

                Vehicle vehicle = new()
                {
                    Type = type,
                    Model = model,
                    Color = color,
                    Horsepower = hp
                };
                vehicles.Add(vehicle);
                command = Console.ReadLine();
            }

            command = Console.ReadLine();
            
            while(command != "Close the Catalogue")
            {
                foreach(Vehicle vehicle in vehicles)
                {
                    if (command == vehicle.Model)
                    {
                        Console.WriteLine($"Type: {vehicle.Type}");
                        Console.WriteLine($"Model: {vehicle.Model}");
                        Console.WriteLine($"Color: {vehicle.Color}");
                        Console.WriteLine($"Horsepower: {vehicle.Horsepower}");
                    }
                }
                command = Console.ReadLine();
            }

            var cars = vehicles.Where(v => v.Type == "Car").ToList();
            var trucks = vehicles.Where(v => v.Type == "Truck").ToList();

            double carAvgHP = cars.Any() ? cars.Average(v => v.Horsepower) : 0;
            double truckAvgHP = trucks.Any() ? trucks.Average(v => v.Horsepower) : 0;

            Console.WriteLine($"Cars have average horsepower of: {carAvgHP:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {truckAvgHP:f2}.");
        }

        static string Capitalize(string command)
        {
            return char.ToUpper(command[0]) + command.Substring(1).ToLower();
        }
    }

    class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }
    }
}
