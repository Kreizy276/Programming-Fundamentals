using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Student> studentGrade = new();

            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentGrade.ContainsKey(student))
                {
                    studentGrade.Add(student, new Student(student));
                }

                studentGrade[student].Grades.Add(grade);
            }

            foreach(Student student in studentGrade.Values)
            {
                double averageGrade = student.Grades.Average();
                if(averageGrade >= 4.5)
                {
                    Console.WriteLine($"{student.Name} -> {averageGrade:F2}");
                }
            }
        }
    }

    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }

        public Student(string name)
        {
            Name = name;
            Grades = new List<double>();
        }
    }
}
