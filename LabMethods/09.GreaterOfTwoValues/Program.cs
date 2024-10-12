using System;

namespace _09.GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(num1, num2));
                    break;
                case "char":
                    char ch1 = char.Parse(Console.ReadLine());
                    char ch2 = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(ch1, ch2)); 
                    break;
                case "string":
                    string str1 = Console.ReadLine();
                    string str2 = Console.ReadLine();
                    Console.WriteLine(GetMax(str1, str2));
                    break;

            }
        }

        static int GetMax(int x, int y)
        {
            return x > y ? x : y;
        }

        static char GetMax(char ch1, char ch2)
        {
            return ch1 > ch2 ? ch1 : ch2;
        }

        static string GetMax(string str1, string str2)
        {
            int result = String.Compare(str1, str2);

            return result < 0 ? str2 : str1;
        }
    }
}
