using System;
using System.Text;

namespace _04._TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] banArray = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (string ban in banArray)
            {
                int length = ban.Length;
                while (text.Contains(ban))
                {
                    foreach(char ch in ban)
                    {
                        text = text.Replace(ch, '*');
                    }
                }
            }
            Console.WriteLine(text);
        }
    }
}
