using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Sum_Adjacent_Equal_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            
          
                SumAdjacentNumbers(numbers);
                
           
            Console.WriteLine(string.Join(" ", numbers));
        }

        private static List<double> SumAdjacentNumbers(List<double> numbers)// метод за логиката
        {
            for (int i = 0; i < numbers.Count - 1; i++) // въртя до предпоследното
            {
                if (numbers[i] == numbers[i + 1]) // ако текущото число е равно на следващото в листа
                {
                    numbers[i] += numbers[i + 1];// събери двете числа
                    numbers.RemoveAt(i + 1);// премахни второто 
                    i = -1;// върни цикъла отначало
                }
            }
            return numbers;
        }
    }
}
