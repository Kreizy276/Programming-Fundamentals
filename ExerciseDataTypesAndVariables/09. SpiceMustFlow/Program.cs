int startingYield = int.Parse(Console.ReadLine());

int days = 0;
int consuming = 0;
int sum = 0;

while (startingYield >= 100)
{
    consuming = startingYield - 26;
    startingYield -= 10;
    days++;
    sum += consuming;
}
if(sum >= 26)
{
    sum -= 26;
}

Console.WriteLine(days);
Console.WriteLine(sum);
