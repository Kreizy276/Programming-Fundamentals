using System;
using System.Collections.Generic;

namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Students> students = new();
            string command = Console.ReadLine();

            while(command != "end")
            {
                string[] data = command.Split();

                Students list = new()
                {
                    FirstName = data[0],
                    LastName = data[1],
                    Age = int.Parse(data[2]),
                    HomeTown = data[3],
                };
                students.Add(list);

                command = Console.ReadLine();
            }

            string town = Console.ReadLine();
            foreach(Students student in students)
            {
                if(town ==  student.HomeTown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }

    class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}
