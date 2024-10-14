using System;
using System.Collections.Generic;

namespace _04._ListOfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> list = new();

            for(int i = 0; i < n; i++)
            {
                string prodcut = Console.ReadLine();
                list.Add(prodcut);
            }

            SortList(list);
        }

        static void SortList(List<string> list)
        {
            list.Sort();
            int order = 1;

            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{order}.{list[i]}");
                order++;
            }
        }
    }
}
