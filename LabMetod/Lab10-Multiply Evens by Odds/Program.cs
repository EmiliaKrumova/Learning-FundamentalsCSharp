using System;

namespace Lab10_Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int absNumber = Math.Abs(number);
            int sumOfEven = GetSumOfEvenDigits(absNumber);
            int sumOfOdds = GetSumOfOddDigits(absNumber);
            int finalresult = GetMultipleOfEvenAndOdds(sumOfEven, sumOfOdds);
            Console.WriteLine(finalresult);

        }
        static int GetSumOfEvenDigits(int absNumber)
        {
            int sumEvens = 0;
            int num = absNumber;
            
            while (num > 0)
            {
               int currNum = num % 10;
                if (currNum %2 == 0) 
                {
                    sumEvens += currNum;
                }
                num /= 10;
                
                
                
            }
            return sumEvens;
        }
        static int GetSumOfOddDigits(int absNumber)
        {
            int sumOdds = 0;
            int num = absNumber;

            while (num > 0)
            {
                int currNum = num % 10;
                if (currNum % 2 != 0)
                {
                    sumOdds += currNum;
                }
                num /= 10;

               
                
            }
            return sumOdds;
        }
        static int GetMultipleOfEvenAndOdds(int a, int b)

        {
            //int a = GetSumOfOddDigits(absNumber);
            //int b = GetSumOfEvenDigits((int)b);
            int result = a * b;
            return result;
        }
    }
}
