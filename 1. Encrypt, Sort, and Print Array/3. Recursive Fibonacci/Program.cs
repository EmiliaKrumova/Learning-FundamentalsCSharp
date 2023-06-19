using System;

namespace _3._Recursive_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int number = int.Parse(Console.ReadLine());// число от конзолата
            int[]sequence = new int[number+1];// масив с дължина до числото включително
            int bottom = 1;// дъно на рекурсията
            sequence[0] = bottom;// на първите два индекса е дъното (за да няма StackOverflowExeption)
            sequence[1] = bottom;
            if (number >2) 
            {
                for (int i = 2; i < number; i++)// от третия индекс до дължината на масива
                {
                    sequence[i] = sequence[i - 1] + sequence[i - 2]; // текущото число е равно на сбора от предходните две числа
                }
            }
            
            Console.WriteLine(sequence[number-1]);// изписвам предходното число, което се явява последно преди number
        }
    }
}
