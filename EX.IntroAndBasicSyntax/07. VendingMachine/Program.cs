string command = Console.ReadLine();

double sum = 0;
double price = 0;

while (command != "Start")
{
    double coin = double.Parse(command);
    switch (coin)
    {
        case 0.1:
        case 0.2:
        case 0.5:
        case 1:
        case 2:
            sum += coin;
            break;
        default:
            Console.WriteLine($"Cannot accept {coin}");
            break;
    }
    command = Console.ReadLine();
}

string command2 = Console.ReadLine();
while (command2 != "End")
{
    switch (command2)
    {
        case "Nuts":
            price = 2;
            if(sum < price)
            {
                Console.WriteLine("Sorry, not enough money");
            }
            else
            {
                sum -= price;
                Console.WriteLine("Purchased nuts");
            }
            break;
        case "Water":
            price = 0.7;
            if (sum < price)
            {
                Console.WriteLine("Sorry, not enough money");
            }
            else
            {
                sum -= price;
                Console.WriteLine("Purchased water");
            }
            break;
        case "Crisps":
            price = 1.5;
            if (sum < price)
            {
                Console.WriteLine("Sorry, not enough money");
            }
            else
            {
                sum -= price;
                Console.WriteLine("Purchased crisps");
            }
            break;
        case "Soda":
            price = 0.8;
            if (sum < price)
            {
                Console.WriteLine("Sorry, not enough money");
            }
            else
            {
                sum -= price;
                Console.WriteLine("Purchased soda");
            }
            break;
        case "Coke":
            price = 1;
            if (sum < price)
            {
                Console.WriteLine("Sorry, not enough money");
            }
            else
            {
                sum -= price;
                Console.WriteLine("Purchased coke");
            }
            break;
        default:
            Console.WriteLine("Invalid product");
            break;
    }

    command2 = Console.ReadLine();
}

Console.WriteLine($"Change: {sum:f2}");