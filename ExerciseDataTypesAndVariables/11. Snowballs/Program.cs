int n = int.Parse(Console.ReadLine());

double bestSum = double.MinValue;
double bestSnow = 0;
double bestTime = 0;
double bestQuality = 0;

for (int i = 1; i <= n; i++)
{
    int snowballSnow = int.Parse(Console.ReadLine());
    int snowballTime = int.Parse(Console.ReadLine());
    int snowballQuality = int.Parse(Console.ReadLine());

    double sum = Math.Pow((double)snowballSnow / snowballTime, snowballQuality);

    if(bestSum < sum)
    {
        bestSum = sum;
        bestSnow = snowballSnow;
        bestTime = snowballTime;
        bestQuality = snowballQuality;
    }
}

Console.WriteLine($"{bestSnow} : {bestTime} = {bestSum} ({bestQuality})");