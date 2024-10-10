string name = Console.ReadLine();
int age = int.Parse(Console.ReadLine());
double avGrade = double.Parse(Console.ReadLine());

Console.WriteLine($"Name: {name}, Age: {age}, Grade: {avGrade:f2}");