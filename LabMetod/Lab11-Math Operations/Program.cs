using System;

namespace Lab11_Math_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            double secondNum = double.Parse(Console.ReadLine());
            Console.WriteLine(Calculator(firstNum,@operator, secondNum));
        }
        static double Calculator(double firstNum,string @operator, double secondNum)
        {
            double resultOfCalculation = 0;
            if (@operator == "+")
            {
                resultOfCalculation = firstNum + secondNum;
            }else if (@operator == "-")
            {
                resultOfCalculation = firstNum - secondNum;
            }else if (@operator == "*")
            {
                resultOfCalculation = firstNum * secondNum;
            }else if (@operator == "/")
            {
                resultOfCalculation = firstNum / secondNum;
            }
            return resultOfCalculation;
        }
    }
}
