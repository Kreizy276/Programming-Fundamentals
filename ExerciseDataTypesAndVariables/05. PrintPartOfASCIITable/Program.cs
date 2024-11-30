using System;

namespace _05._PrintPartOfASCIITable
{
    internal class Program
    {
        static void Main()
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            for(int i = n1; i <= n2; i++)
            {
                char convert = Convert.ToChar(i);

                Console.Write($"{convert} ");
            }
        }
    }
}
