using System;
using System.Linq;

namespace _02._CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creating two arrays
            string input = Console.ReadLine();
            string input2 = Console.ReadLine();
            string[] arr1 = input.Split();
            string[] arr2 = input2.Split();

            //outer loop takes the first elemenent
            for(int i = 0; i < arr2.Length; i++)
            {
                //inner loop compares the element 'i' of array 1 to each element 'j' in array 2
                for(int j = 0; j < arr1.Length; j++)
                {
                    if (arr2[i] == arr1[j])
                    {
                        Console.Write($"{arr2[i]} ");
                    }
                }
            }
        }
    }
}
