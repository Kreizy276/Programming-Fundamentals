using System;
using System.Collections.Generic;

namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Students> students = new();

            for(int i = 1; i <= n; i++)
            {
                string text = Console.ReadLine();

                string[] data = text.Split();
                string firstName = data[0];
                string lastName = data[1];
                float grade = float.Parse(data[2]);

                Students student = new Students()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Grade = grade
                };
                students.Add(student);
            }

            students.Sort((a, b) => b.Grade.CompareTo(a.Grade));

            foreach(Students student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }

    class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Grade { get; set; }
    }
}
