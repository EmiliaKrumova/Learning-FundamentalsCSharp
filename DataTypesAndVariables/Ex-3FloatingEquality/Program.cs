using System;

namespace Ex_3FloatingEquality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());
            double differenceBetweenOneAndTwo  = Math.Abs(numberOne-numberTwo);
            if (differenceBetweenOneAndTwo >= 0.000001) 
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}
