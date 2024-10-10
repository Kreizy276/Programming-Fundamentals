string username = Console.ReadLine();
string password = username.Reverse().ToString();

string guess = "";
int count = 0;

char[] charArray = username.ToCharArray(); //creating array
Array.Reverse(charArray); // reversing string
string reversed = new string(charArray); // creating new string to a new var
// Console.WriteLine(reversed); // printing reversed string

//Guessing the password
while (guess != reversed)
{
    guess = Console.ReadLine(); // input what password might be
    count++; // counter for how many attempts
    //checks if the user did 4 tries
    if(count == 4)
    {
        Console.WriteLine($"User {username} blocked!"); //if it does it prints this
        break;
    }
    if(guess != reversed)
    {
        Console.WriteLine("Incorrect password. Try again."); //if the password is not guessed right it prints this
    }
    else
    {
        Console.WriteLine($"User {username} logged in."); // if the password is guessed right it prints this
    }
}