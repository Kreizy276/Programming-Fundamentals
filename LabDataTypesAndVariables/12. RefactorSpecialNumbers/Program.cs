namespace _12._RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = 1; i <= num; i++)
            {

                int x = i % 10;
                int y = i / 10;
                result = x + y;

                bool isSpecial = result == 5 || result == 7 || result == 11;
                Console.WriteLine(isSpecial ? $"{i} -> True" : $"{i} -> False");
                result = 0;
            }

        }
    }
}
