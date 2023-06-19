using System;
using System.Linq;
using System.Security;

namespace _7._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split()
                .Select(int.Parse)
                .ToArray();
            bool isSequence = false;
            int longestSequence = 1;
            int numbeToPrint = 0;
            int currentSequence = 1;



            for (int index = 0; index < numbers.Length; index++)
            {
                int currentNumber = numbers[index];
                int nextNumberInArray = default;


                if (isSequence == false)
                {
                    currentSequence = 1;

                }

                if (index < numbers.Length - 1)
                {
                    nextNumberInArray = numbers[index + 1];
                }
                else
                {
                    break;
                }


                if (currentNumber == nextNumberInArray)
                {
                    isSequence = true;
                    currentSequence++;

                }
                else
                {
                    isSequence = false;
                    continue;
                }
                if (currentSequence > longestSequence)
                {
                    longestSequence = currentSequence;
                    numbeToPrint = numbers[index];
                }
            }

            int[] finalArr = new int[longestSequence];
            for (int i = 0; i < longestSequence; i++)
            {
                finalArr[i] = numbeToPrint;
            }
            Console.WriteLine(String.Join(" ", finalArr));
        }
    }
}
