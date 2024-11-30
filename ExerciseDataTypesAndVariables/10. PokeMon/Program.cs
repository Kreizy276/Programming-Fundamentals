int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());

int copyN = n;
int poke = 0;

while (n >= m)
{
    n -= m;
    poke++;
    if(n == copyN / 2 && y != 0)
    {
        n /= y;
    }
}

Console.WriteLine(n);
Console.WriteLine(poke);