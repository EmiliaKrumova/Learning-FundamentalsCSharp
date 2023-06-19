using System;

namespace Add_Ex_4_RefactoringPrimeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfNumbers = int.Parse(Console.ReadLine());

            for (int currentNumber = 2; currentNumber <= countOfNumbers; currentNumber++)

            {

                bool IsPrime = true;

                for (int divisor = 2; divisor < currentNumber; divisor++)

                {

                    if (currentNumber % divisor == 0)

                    {

                        IsPrime = false;

                        break;

                    }

                }

                Console.WriteLine("{0} -> {1}", currentNumber, IsPrime.ToString().ToLower());
            }
        }
    }
}
