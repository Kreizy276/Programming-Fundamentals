using System;
using System.Linq;

namespace _01._PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string data;
            while((data = Console.ReadLine()) != "Complete")
            {
                string[] commandParts = data.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = commandParts[0];

                switch (command)
                {
                    case "Make":
                        string caseCommand = commandParts[1];
                        int index = int.Parse(commandParts[2]);
                        if (index >= 0 && index < password.Length)
                        {
                            if (caseCommand == "Upper")
                            {
                                password = MakeUpper(password, index);
                                Console.WriteLine(password);
                            }
                            else if (caseCommand == "Lower")
                            {
                                password = MakeLower(password, index);
                                Console.WriteLine(password);
                            }
                        }

                        break;
                    case "Insert":
                        index = int.Parse(commandParts[1]);
                        string character = commandParts[2];
                        if (index >= 0 && index <= password.Length)
                        {
                            password = InsertCharacter(password, index, character);
                            Console.WriteLine(password);
                        }
                        break;
                    case "Replace":
                        char oldChar = commandParts[1][0];
                        int value = int.Parse(commandParts[2]);

                        if (password.Contains(oldChar))
                        {
                            password = ReplaceCharacter(password, oldChar, value);
                            Console.WriteLine(password);
                        }
                        break;
                    case "Validation":
                        if(password.Length < 8)
                        {
                            Console.WriteLine("Password must be at least 8 characters long!");
                        }
                        if(!password.All(character => char.IsLetterOrDigit(character) || character == '_'))
                        {
                            Console.WriteLine("Password must consist only of letters, digits and _!");
                        }
                        if (!password.Any(char.IsUpper))
                        {
                            Console.WriteLine("Password must consist at least one uppercase letter!");
                        }
                        if(!password.Any(char.IsLower))
                        {
                            Console.WriteLine("Password must consist at least one lowercase letter!");
                        }
                        if (!password.Any(char.IsDigit))
                        {
                            Console.WriteLine("Password must consist at least one digit!");
                        }
                        break;
                    default:
                        break;

                }
            }
        }

        static string MakeUpper(string password, int index)
        {
            char character = password[index];

            return password.Remove(index, 1).Insert(index, char.ToUpper(character).ToString());
        }

        static string MakeLower(string password, int index)
        {
            char character = password[index];

            return password.Remove(index, 1).Insert(index, char.ToLower(character).ToString());
        }

        static string InsertCharacter(string password, int index, string character)
        {
            return password.Insert(index, character);
        }

        static string ReplaceCharacter(string password, char oldChar, int value)
        {
            char newChar = (char)(oldChar + value);

            return password.Replace(oldChar, newChar);
        }
    }
}
