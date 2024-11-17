using System;
using System.Collections.Generic;

namespace _07._OrderByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new();

            string command = Console.ReadLine();

            while(command != "End")
            {
                string[] data = command.Split();

                string name = data[0];
                string id = data[1];
                int age = int.Parse(data[2]);

                Person person = new()
                {
                    Name = name,
                    ID = id,
                    Age = age
                };
                people.Add(person);
            }
        }
    }

    class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
}
