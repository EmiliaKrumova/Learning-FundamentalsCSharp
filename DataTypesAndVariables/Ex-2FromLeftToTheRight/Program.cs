using System;

namespace Ex_2FromLeftToTheRight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfLines = int.Parse(Console.ReadLine());
            

            for (int i = 0;i< countOfLines;i++)
            {
                char delimeter = ' ';
                string numbersString = Console.ReadLine();
                string[] splitNumbers = numbersString.Split(delimeter);
                long firstNumber = long.Parse(splitNumbers[0]);
                long secondNumber = long.Parse(splitNumbers[1]);
                long biggerNumber = secondNumber;
                long sumOfDigits = 0;
                if (firstNumber>secondNumber)
                {
                    biggerNumber = firstNumber;
                }
                
                while(biggerNumber != 0)
                {
                    sumOfDigits += biggerNumber % 10;
                    biggerNumber /= 10;
                    
                }
                Console.WriteLine(Math.Abs(sumOfDigits));
            }
            
            
        }
    }
}
