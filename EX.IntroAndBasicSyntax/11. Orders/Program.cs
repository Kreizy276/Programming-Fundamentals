int numOrders = int.Parse(Console.ReadLine());

double price = 0;

for (int i = 1 ; i <= numOrders; i++)
{
    double pricePerCapsule = double.Parse(Console.ReadLine());
    int days = int.Parse(Console.ReadLine());
    int capsules = int.Parse(Console.ReadLine());

    double sum = (days * capsules) * pricePerCapsule;
    price += sum;

    Console.WriteLine($"The price for the coffee is: ${sum:f2}");

    sum = 0;
}

Console.WriteLine($"Total: ${price:f2}");