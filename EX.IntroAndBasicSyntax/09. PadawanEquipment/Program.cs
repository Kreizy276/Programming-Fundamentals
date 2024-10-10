//Inputs
float amountOfMoney = float.Parse(Console.ReadLine());
int countOfStudents = int.Parse(Console.ReadLine());
float priceOfLightsaber = float.Parse(Console.ReadLine());
float priceOfRobe = float.Parse(Console.ReadLine());
float priceOfBelt = float.Parse(Console.ReadLine());

//Calculations
double sum = 0;
int freeBelts = countOfStudents / 6;
double roundedSabers = Math.Ceiling(countOfStudents * 1.1); 
sum = roundedSabers * priceOfLightsaber + priceOfRobe * countOfStudents + (countOfStudents - freeBelts) * priceOfBelt; 
double roundedNum = Math.Round(sum, 2);

//Checking if John has enough money
if(roundedNum <= amountOfMoney)
{
    Console.WriteLine($"The money is enough - it would cost {roundedNum:f2}lv.");
}
else
{
    double neededMoney = roundedNum - amountOfMoney;
    Console.WriteLine($"John will need {neededMoney:f2}lv more.");
}