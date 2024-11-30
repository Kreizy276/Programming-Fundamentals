using System;
using System.Linq;

namespace _07._EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;
            int i = 0;
            bool isEqual = true;

            for(i = 0; i < arr1.Length; i++)
            {
                if(arr1[i] != arr2[i])
                {
                    isEqual = false;
                    break;
                }
                else
                {
                    sum += arr1[i];
                } 
            }
            Console.WriteLine(isEqual ? $"Arrays are identical. Sum: {sum}" : $"Arrays are not identical. Found difference at {i} index");
        }
    }
}
