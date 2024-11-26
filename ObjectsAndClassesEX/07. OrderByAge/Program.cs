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

                Person existingPerson = people.Find(p => p.ID == id);

                if (existingPerson != null)
                {
                    existingPerson.Name = name;
                    existingPerson.Age = age;
                }
                else
                {
                    Person person = new()
                    {
                        Name = name,
                        ID = id,
                        Age = age
                    };
                    people.Add(person);
                }
                command = Console.ReadLine();
            }
            people.Sort((x, y) => x.Age.CompareTo(y.Age));

            foreach(Person person in people)
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
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
