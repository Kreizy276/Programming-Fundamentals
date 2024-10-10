int n = int.Parse(Console.ReadLine());

int sum = 1;

for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write($"{sum} ");
    }
    sum += 1;
    Console.WriteLine();
}