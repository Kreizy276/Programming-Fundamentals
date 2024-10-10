int hours = int.Parse(Console.ReadLine());
int min = int.Parse(Console.ReadLine());

int plus30 = min + 30;
double newMin = 0;

if (plus30 > 59)
{
    hours++;
    if(hours == 24)
    {
        hours -= 24;
    }
    newMin = plus30 % 60;
}
else
{
    newMin = plus30;
}

Console.WriteLine($"{hours}:{newMin:00}");