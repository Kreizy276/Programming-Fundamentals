using System;
using System.Linq;

namespace _04._ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            arr = arr.Skip(rotations % arr.Length).Concat(arr.Take(rotations % arr.Length)).ToArray();

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
