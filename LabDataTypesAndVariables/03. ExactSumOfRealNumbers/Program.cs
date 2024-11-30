namespace _03._ExactSumOfRealNumbers
{
    internal class Program
    {
        static void Main()
        {
            string n = Console.ReadLine();
            decimal num = decimal.Parse(n);
            decimal sum = 0;

            for(int i = 1; i <= num; i++)
            {
                decimal num2 = decimal.Parse(Console.ReadLine());
                sum += num2;
            }
            Console.WriteLine(sum);
        }
    }
}