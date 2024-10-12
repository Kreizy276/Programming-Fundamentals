using System;
using System.Linq;

namespace _05._TopIntergers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] extended = new int[arr.Length + 1];

            for(int i = 0; i < extended.Length; i++)
            {
                for(int j = 0; j < extended.Length; j++)
                {
                    if(arr[i] > arr[j + 1])
                    {

                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
