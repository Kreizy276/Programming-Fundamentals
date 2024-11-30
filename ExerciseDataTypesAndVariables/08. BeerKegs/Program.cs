int n = int.Parse(Console.ReadLine());

double sum = 0;
string model;
string biggestModel = "";
double biggestV = 0;

for (int i = 1;  i <= n; i++)
{
    model = Console.ReadLine();
    double radius = double.Parse(Console.ReadLine());
    int height = int.Parse(Console.ReadLine());
    
    sum = Math.PI * Math.Pow(radius, 2) * height;

    if(biggestV < sum)
    {
        biggestModel = model;
        biggestV = sum;
    }
}

Console.WriteLine(biggestModel);