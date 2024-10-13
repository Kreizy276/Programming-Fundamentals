using System;

namespace _01._SmallestOfTheThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            Console.WriteLine(SmallestNumber(n1, n2, n3)); 
        }

        static int SmallestNumber(int n1, int n2, int n3)
        {
            int smallestNum = n1;

            if(n2 < smallestNum)
            {
                smallestNum = n2;
            }
            if(n3 < smallestNum)
            {
                smallestNum = n3;
            }

            return smallestNum;
        }
    }
}
