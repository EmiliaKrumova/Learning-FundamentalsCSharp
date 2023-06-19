using System;
using System.Linq;

namespace _4._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();// чета масив от числа
            int rotations = int.Parse(Console.ReadLine());// брой на завъртанията
            for (int i=0; i<rotations; i++)// според броя на завъртанията
            {
                int temp = numbers[0];// запази в тази променлива числото от 0 индекс
                for (int j=0;j<numbers.Length-1;j++) // върти до броя на числата
                {
                    numbers[j] = numbers[j + 1]; //вземи следващото число и го сложи на предния индекс ( числото от [1] на [0], числото от [2] го сложи на [1] и т.н 
                }
                numbers[numbers.Length-1] = temp;// сложи на последното място предварително запазеното число

            }
            for (int k = 0; k<numbers.Length; k++) // завърти масива и го изпиши
            {
                Console.Write($"{numbers[k]} ");
            }
        }
    }
}
