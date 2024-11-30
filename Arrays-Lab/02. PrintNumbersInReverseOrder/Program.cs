using System;
using System.Linq;

namespace _02._PrintNumbersInReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int[] arr = new int[num];

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int[] reversed = arr.Reverse().ToArray();

            for(int i = 0; i < reversed.Length; i++)
            {
                Console.Write($"{reversed[i]} ");
            }
        }
    }
}
