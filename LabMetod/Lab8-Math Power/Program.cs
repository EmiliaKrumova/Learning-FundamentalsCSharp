using System;
using System.Numerics;

namespace Lab8_Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseNumber =double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(PowerOfNumber(baseNumber,power));
            

        }
        static double PowerOfNumber(double baseNumber, int power)
        {
            double result = 0d;
            result = Math.Pow(baseNumber, power);
               
            return result;
        }
    }
}
