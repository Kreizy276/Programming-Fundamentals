int num = int.Parse(Console.ReadLine());
int multiplier = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = multiplier; i <= 10; i++)
{
    sum = num * i;
    Console.WriteLine($"{num} X {i} = {sum}");
    sum = 0;
}

if (multiplier > 10)
{
    sum = num * multiplier;
    Console.WriteLine($"{num} X {multiplier} = {sum}");
}