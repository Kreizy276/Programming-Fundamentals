namespace _01._IntergerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstInt = int.Parse(Console.ReadLine());
            int secondInt = int.Parse(Console.ReadLine());
            int thirdInt = int.Parse(Console.ReadLine());
            int fourthInt = int.Parse(Console.ReadLine());

            int sum = firstInt + secondInt;
            sum /= thirdInt;
            sum *= fourthInt;

            Console.WriteLine(sum);
        }
    }
}
