using System;

namespace _8._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            long factorialfirst = 1;
            long factorialsecond = 1;
            factorialfirst = CalculateFirstFactorial(firstNum, factorialfirst);
            factorialsecond = CalculateFactorialSecond(secondNum, factorialsecond);
            double result = factorialfirst / (double)factorialsecond;
            Console.WriteLine($"{result:F2}");

        }

        private static long CalculateFactorialSecond(int secondNum, long factorialsecond)
        {
            for (int i = 1; i <= secondNum; i++)
            {
                factorialsecond *= i;
            }

            return factorialsecond;
        }

        private static long CalculateFirstFactorial(int firstNum, long factorialfirst)
        {
            for (int i = 1; i <= firstNum; i++)
            {
                factorialfirst *= i;
            }

            return factorialfirst;
        }
    }
}
