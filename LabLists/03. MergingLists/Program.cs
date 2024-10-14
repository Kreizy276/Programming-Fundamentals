using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> list = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<double> list2 = Console.ReadLine().Split().Select(double.Parse).ToList();

            Console.WriteLine(MergingLists(list, list2));
        }

        static string MergingLists(List<double> list, List<double> list2)
        {
            List<double> result = new();

            if(list.Count < list2.Count)
            {
                for (int i = 0; i <= list.Count; i++)
                {
                    i = 0;
                    result.Add(list[i]);
                    list.RemoveAt(i);
                    result.Add(list2[i]);
                    list2.RemoveAt(i);
                    if (list.Count == 0)
                    {
                        for (i = 0; i < list2.Count; i++)
                        {
                            result.Add(list2[i]);
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i <= list2.Count; i++)
                {
                    i = 0;
                    result.Add(list[i]);
                    list.RemoveAt(i);
                    result.Add(list2[i]);
                    list2.RemoveAt(i);
                    if (list2.Count == 0)
                    {
                        for (i = 0; i < list.Count; i++)
                        {
                            result.Add(list[i]);
                        }
                    }
                }
            }
            string print = string.Join(' ', result);
            return print;
        }
    }
}
