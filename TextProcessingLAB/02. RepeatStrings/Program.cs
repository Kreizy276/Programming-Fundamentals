using System;
using System.Linq;
using System.Text;

namespace _02._RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new();

            string[] text = Console.ReadLine().Split().ToArray();

            foreach(string word in text)
            {
                int length = word.Length;
                for (int j = 0; j < length; j++) 
                {
                    sb.Append(word);
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
