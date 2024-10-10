//Input for how many people, what type (student or business or regular) and what day.
int count = int.Parse(Console.ReadLine());
string type = Console.ReadLine();
string day = Console.ReadLine();

double price = 0;
double sum = 0;

//Assigning the prices for each day and type
switch (day)
{
    case "Friday":
        if (type == "Students")
        {
            price = 8.45;
        }
        else if (type == "Business")
        {
            price = 10.90;
        }
        else if (type == "Regular")
        {
            price = 15;
        }
        break;
    case "Saturday":
        if (type == "Students")
        {
            price = 9.8;
        }
        else if (type == "Business")
        {
            price = 15.6;
        }
        else if (type == "Regular")
        {
            price = 20;
        }
        break;
    case "Sunday":
        if (type == "Students")
        {
            price = 10.46;
        }
        else if (type == "Business")
        {
            price = 16;
        }
        else if (type == "Regular")
        {
            price = 22.5;
        }
        break;
}

//Doing the math
sum = price * count;

//Checking for discounts
if (type == "Students" && count >= 30)
{
    sum *= 0.85;
}
else if (type == "Business" && count >= 100)
{
    sum = 0;
    count -= 10;
    sum = price * count;
}
else if (type == "Regular" && count >= 10 && count <= 20)
{
    sum *= 0.95;
}

//Printing results
Console.WriteLine($"Total price: {sum:f2}");