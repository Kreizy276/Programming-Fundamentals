while (true)
{
    int n = int.Parse(Console.ReadLine());

    if ( n % 2 != 0)
    {
        Console.WriteLine("Please write an even number.");
    }
    else
    {
        Console.WriteLine($"The number is: {Math.Abs(n)}");
        break;
    }
}