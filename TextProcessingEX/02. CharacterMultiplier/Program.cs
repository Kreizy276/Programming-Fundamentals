using System;
using System.Data.SqlTypes;
using System.Linq;

namespace _02._CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            int result = CharacterMultiplier(input[0], input[1]);
            Console.WriteLine(result);
        }

        static int CharacterMultiplier(string first, string second)
        {
            int biggestString = Math.Max(first.Length, second.Length);
            int sum = 0;

            for(int i = 0; i < biggestString; i++)
            {
                if(i < first.Length && i < second.Length)
                {
                    sum += first[i] * second[i];
                }
                else if (i < first.Length)
                {
                    sum += first[i];
                }
                else if(i < second.Length)
                {
                    sum += second[i];
                }
            }
            return sum;
        }
    }
}
