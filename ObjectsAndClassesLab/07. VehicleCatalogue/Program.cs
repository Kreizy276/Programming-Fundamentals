using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalog catalogue = new Catalog();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] data = command.Split('/');

                string type = data[0];
                string brand = data[1];
                string model = data[2];
                int number = int.Parse(data[3]);

                switch (type)
                {
                    case "Truck":
                        Truck truck = new Truck()
                        {
                            Brand = brand,
                            Model = model,
                            Weight = number
                        };
                        catalogue.Trucks.Add(truck);
                        break;
                    case "Car":
                        Car car = new Car()
                        {
                            Brand = brand,
                            Model = model,
                            HorsePower = number
                        };
                        catalogue.Cars.Add(car);
                        break;
                }
                command = Console.ReadLine();
            }

            var sortedCars = catalogue.Cars.OrderBy(c => c.Brand).ToList();
            var sortedTrucks = catalogue.Trucks.OrderBy(t => t.Brand).ToList();

            if (sortedCars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (var car in sortedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (sortedTrucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (var truck in sortedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }

    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

    class Catalog
    {
        public List<Truck> Trucks { get; set; } = new List<Truck>();
        public List<Car> Cars { get; set; } = new List<Car>();
    }
}
