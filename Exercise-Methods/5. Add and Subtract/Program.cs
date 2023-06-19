using System;

namespace _5._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int sum = SumOfIntegers(firstNum, secondNum);
            int finalresult = SubstractIntegers(sum, thirdNum);
            Console.WriteLine(finalresult);
            
            
        }

        private static int SubstractIntegers(int sum, int thirdNum)
        {
           
            int substract = sum - thirdNum;
            return substract;
        }

        private static int SumOfIntegers(int firstNum, int secondNum)
        {
            int sum = firstNum + secondNum;
            return sum;
            
        }

    }
}
