int lostGames = int.Parse(Console.ReadLine());
float headsetPrice = float.Parse(Console.ReadLine());
float mousePrice = float.Parse(Console.ReadLine());
float keyboardPrice = float.Parse(Console.ReadLine());
float displayPrice = float.Parse(Console.ReadLine());

double sum = 0;

/*for (int i = 1; i <= lostGames; i++)
{
    if (i % 12 == 0)
    {
        sum += headsetPrice;
        sum += mousePrice;
        sum += keyboardPrice;
        sum += displayPrice;
    }
    else if (i % 6 == 0)
    {
        sum += headsetPrice;
        sum += mousePrice;
        sum += keyboardPrice;
    }
    else if (i % 3 == 0)
    {
        sum += mousePrice;
    }
    else if (i % 2 == 0)
    {
        sum += headsetPrice;
    }
}*/

for(int i = 1; i <= lostGames; i++)
{
    if(i % 2 == 0)
    {
        sum += headsetPrice;
    }
    if (i % 3 == 0)
    {
        sum += mousePrice;
    }
    if (i % 6 == 0)
    {
        sum += keyboardPrice;
    }
    if (i % 12 == 0)
    {
        sum += displayPrice;
    }
}

Console.WriteLine($"Rage expenses: {sum:f2} lv.");