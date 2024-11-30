using System;

namespace _03._Elevator
{
    internal class Program
    {
        static void Main()
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            double demoCourses = 0;
            demoCourses = (double)numOfPeople / capacity;
            double courses = Math.Ceiling(demoCourses);

            if (courses <= 0)
            {
                courses++;
                Console.WriteLine(courses);
            }
            else
            {
                Console.WriteLine(courses);
            }
        }
    }
}
