using System;

namespace _05._AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            Console.WriteLine(SubtractFromResult(n1, n2, n3)); 
        }

        static int AddFirstTwo(int n1, int n2)
        {
            return n1 + n2;
        }

        static int SubtractFromResult(int n1, int n2, int n3)
        {
            return AddFirstTwo(n1, n2) - n3;
        }
    }
}
