using System;
using System.Collections.Generic;

namespace _05._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courseStudent = new();

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] data = input.Split(" : ");

                string course = data[0];
                string student = data[1];

                if (!courseStudent.ContainsKey(course))
                {
                    courseStudent.Add(course, new List<string> { student });
                }
                else
                {
                    courseStudent[course].Add(student);
                }
                input = Console.ReadLine();
            }

            foreach (var kvp in courseStudent)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
                foreach(var student in kvp.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
