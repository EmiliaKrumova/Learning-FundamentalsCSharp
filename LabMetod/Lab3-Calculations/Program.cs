using System;

namespace Lab3_Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string calculation = Console.ReadLine();
            if (calculation == "add")
            {
                sum(calculation);
            }else if (calculation == "subtract")
            {
                substract(calculation);
            }else if(calculation == "multiply")
            {
                multiply(calculation);
            }else if (calculation == "divide")
            {
                divide(calculation);
            }


        }
        static void sum (string calculation)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int result = firstNum + secondNum;
            Console.WriteLine(result);
        }
        static void substract(string calculation)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int result = firstNum - secondNum;
            Console.WriteLine(result);
        }
        static void multiply(string calculation)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int result = firstNum * secondNum;
            Console.WriteLine(result);
        }
        static void divide(string calculation)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int result = firstNum / secondNum;
            Console.WriteLine(result);
        }
    }
}
