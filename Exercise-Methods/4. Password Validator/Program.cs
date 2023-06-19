using System;

namespace _4._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            
            if (ValidationForLeastTwoDigits(password) && ValidationPasswordByLength(password) && ValidationForSymbols(password))
            {
                Console.WriteLine("Password is valid");
            }
            if (ValidationPasswordByLength(password) == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (ValidationForSymbols(password) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (ValidationForLeastTwoDigits(password) == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            
        }

        private static bool ValidationForLeastTwoDigits(string password)
        {
            int countOfDigits = 0;
            bool IsValid = false;
            for (int i = 0; i < password.Length; i++)
            {
                char currChar = (char)password[i];
                if (currChar >= 48 && currChar <= 57)
                {
                    countOfDigits++;
                }
            }
            if (countOfDigits > 1)
            {
                IsValid = true;
            }
            else
            {
                IsValid = false;
              
            }

            return IsValid;
        }

        private static bool ValidationForSymbols(string password)
        {
            bool IsValid = false;
            for (int i = 0; i < password.Length; i++)
            {
                char currChar = (char)password[i];
                if (currChar >= 48 && currChar <= 57)
                {
                    IsValid = true;
                }
                else if (currChar >= 65 && currChar <= 90)
                {
                    IsValid = true;
                }
                else if (currChar >= 97 && currChar <= 122)
                {
                    IsValid = true;
                }
                else
                {
                    IsValid = false;
                    break;
                }
            }
            if (IsValid == false)
            {
               
            }

            return IsValid;
        }

        private static bool ValidationPasswordByLength(string password)
        {
            bool IsValid = false;
            if (password.Length >= 6 && password.Length <= 10)
            {
                IsValid = true;
            }
            else
            {
                IsValid = false;
               
            }

            return IsValid;
        }
    }
}
