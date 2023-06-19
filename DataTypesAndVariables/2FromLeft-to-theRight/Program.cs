using System;
using System.Transactions;

namespace _2FromLeft_to_theRight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfLines = int.Parse(Console.ReadLine());
            
            for(int i = 0;i< countOfLines;i++)
            {
                bool isSpaceFounded = false;
               string twoNumbersWithSpace = Console.ReadLine();
                long sum1 = 0;
                long sum2 = 0;
                string leftNumber = String.Empty;
                string rightNumber = String.Empty;
                for (int k = 0; k<twoNumbersWithSpace.Length;k++)
                {
                    char currentLetter = twoNumbersWithSpace[k];
                    if (currentLetter == 32)
                    {
                        isSpaceFounded = true;

                    }
                    else if (currentLetter == 45)
                    {
                        continue;

                    }else if (currentLetter ==46)
                    {
                        continue;
                    }
                    else if (!isSpaceFounded)
                    {
                        long currentDigit = long.Parse(currentLetter.ToString());
                        sum1 += currentDigit;
                        leftNumber += currentDigit;

                    }
                    else if (isSpaceFounded)
                    {
                        long currentDigit = long.Parse(currentLetter.ToString());
                        sum2 += currentDigit;
                        rightNumber += currentDigit;

                    }
                    

                }
                long leftNumberInInt = long.Parse(leftNumber.ToString());
                long rightNumberInInt = long.Parse(rightNumber);
                if (leftNumberInInt > rightNumberInInt)
                {
                    Console.WriteLine(sum1);
                }
                else
                {
                    Console.WriteLine(sum2);
                }
            }
        }
    }
}
