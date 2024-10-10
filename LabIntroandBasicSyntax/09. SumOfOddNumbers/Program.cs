int num = int.Parse(Console.ReadLine());
int i = 0;
int sum = 0;
int x = 0;

for(i = 0; i < num; i++)
{
    x = 2 * i + 1;
    Console.WriteLine(x);
    sum += x;
}

Console.WriteLine($"Sum: {sum}");