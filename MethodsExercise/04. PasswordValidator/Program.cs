using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            List<char> list = password.ToList();

            bool isValid = true;

            if (!PasswordLength(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isValid = false;
            }
            if (!PasswordCharacters(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isValid = false;
            }
            if (!PasswordDigits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
                isValid = false;
            }

            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool PasswordLength(string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }

        static bool PasswordCharacters(string password)
        {
            foreach(char c in password)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        static bool PasswordDigits(string password)
        {
            int digits = 0;

            foreach(char c in password)
            {
                if (char.IsDigit(c))
                {
                    digits++;
                }
            }
            return digits >= 2;
        }
    }
}
