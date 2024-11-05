using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace _05._Student2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Students> students = new();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] data = command.Split();

                string firstName = data[0];
                string lastName = data[1];
                int age = int.Parse(data[2]);
                string homeTown = data[3];

                Students list = new()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    HomeTown = homeTown,
                };
                students.Add(list);

                command = Console.ReadLine();
            }

            string town = Console.ReadLine();
            foreach (Students student in students)
            {
                if(IsStudentExisting(students, firstName, ))

                if (town == student.HomeTown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

        static Students GetStudent(List<Students> students, string firstName, string lastName)
        {
            Students existingStudent = null;

            foreach (Students student in students)
            {
                if(student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }

            return existingStudent;
        }

        static bool IsStudentExisting(List<Students> students, string firstName, string lastName)
        {
            foreach(Students student in students)
            {
                if(firstName == student.FirstName && lastName == student.LastName)
                {
                    return true;
                }
            }
            return false;
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
