using System;
using System.Linq;

namespace Arrays_Lab6._Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string integers = Console.ReadLine();
            int[] numbers = integers.Split( ).Select(int.Parse).ToArray();
            int evenSum = 0;
            int oddSum = 0;
            for(int i = 0; i< numbers.Length; i++)
            {
                if (numbers[i] %2==0 )
                {
                    evenSum += numbers[i];
                }else
                {
                    oddSum += numbers[i];
                }
            }
            int difference = evenSum - oddSum;
            Console.WriteLine(difference);
        }
    }
}
