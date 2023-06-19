using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool isDivisibleBy8 = false;
            bool isOddDigit = false;

            for (int i = 1; i <= number; i++)
            {
                int originalNumber = i;
                isDivisibleBy8 = false;
                isOddDigit = false;
                int sumOfDigits = 0;
                ChekIsOddNumber(ref isOddDigit, ref originalNumber, ref sumOfDigits);
                isDivisibleBy8 = IsDivisibleByEight(isDivisibleBy8, sumOfDigits);
                if (isDivisibleBy8 && isOddDigit)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool IsDivisibleByEight(bool isDivisibleBy8, int sumOfDigits)
        {
            if (sumOfDigits % 8 == 0)
            {
                isDivisibleBy8 = true;

            }

            return isDivisibleBy8;
        }

        private static void ChekIsOddNumber(ref bool isOddDigit, ref int originalNumber, ref int sumOfDigits)
        {
            while (originalNumber > 0)
            {
                int currDigit = originalNumber % 10;
                if (currDigit % 2 != 0)
                {
                    isOddDigit = true;
                }
                sumOfDigits += currDigit;
                originalNumber /= 10;

            }
        }
    }
}
