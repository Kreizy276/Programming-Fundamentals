using System;
using System.Linq;

namespace _08._CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] condensed = new int[arr.Length];

            while (arr.Length > 1)
            {
                condensed = new int[arr.Length - 1];

                for(int i = 0;  i < condensed.Length; i++)
                {
                    condensed[i] = arr[i] + arr[i + 1];
                }
                arr = condensed;
            }
            Console.WriteLine(arr[0]);
        }
    }
}
