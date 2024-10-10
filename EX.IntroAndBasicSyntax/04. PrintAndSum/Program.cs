int start = int.Parse(Console.ReadLine()); // Start of a number seq
int end = int.Parse(Console.ReadLine()); // End of a number seq

int sum = 0;

// Printing the numbers from the start to the end of 2 given numbers and adding them together to a sum
for(int i = start; i <= end; i++) 
{
    Console.Write($"{i} ");
    sum += i;
}

Console.WriteLine(); //New line after the loop

Console.WriteLine($"Sum: {sum}"); // print result