using System;

namespace Lab1_Sign_of_Integer_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            numberValue(number);
            
            
        }
        static void numberValue(int number)
        {
            if (number == 0)
            {
                Console.WriteLine($"The number {number} is zero. ");

            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive");
            }
           
        }
    }
}
