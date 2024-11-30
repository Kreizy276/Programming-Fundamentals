namespace _11._RefactorVolumeOfPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());

            double volume = 0;

            volume = (1.0 / 3) * length * width * height;

            Console.Write($"Pyramid Volume: {volume:f2}");
        }
    }
}
