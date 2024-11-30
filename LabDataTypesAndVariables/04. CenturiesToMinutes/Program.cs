namespace _04._CenturiesToMinutes
{
    internal class Program
    {
        static void Main()
        {
            int century = int.Parse(Console.ReadLine());
            double daysInYear = 365.2422;

            int years = century * 100;
            double daysDemo = years * daysInYear;
            int days = (int)daysDemo;
            int hours = days * 24;
            int minutes = hours * 60;

            Console.WriteLine($"{century} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
