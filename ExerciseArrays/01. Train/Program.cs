using System;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // initializing how long this loop will run
            int n = int.Parse(Console.ReadLine());

            // creating array with the size of n (example: n = 3 then the array will have the length of 3 elements)
            int[] passengers = new int[n];
            int totalPass = 0;

            // assinging how many passengers this train will have and assinging them to the array while calculating the total of passengers in the train
            for(int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                passengers[i] = num;
                totalPass += passengers[i];
            }
            Console.WriteLine(string.Join(" ", passengers));
            Console.WriteLine(totalPass);
        }
    }
}
