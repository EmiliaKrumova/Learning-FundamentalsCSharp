using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3___Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            double sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            double average = sum / numbers.Count;
            List<int> numbersOverAverage = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > average)
                {
                    numbersOverAverage.Add(numbers[i]);
                }
            }
            List<int> descending = numbersOverAverage.OrderByDescending(x => x).ToList();


            int descendingCount = descending.Count();
            List<int> firstFive = new List<int>();
            if (descendingCount <=5) 
            
            {

                for(int i = 0; i  < descendingCount; i++) 
                {
                    firstFive.Add(descending[i]);
                }
            }else
            {
                for (int i = 0; i < 5; i++)
                {

                    firstFive.Add(descending[i]);

                }
            }





            
            
            
            //
            if(firstFive.Count > 0)
            {
                Console.WriteLine(string.Join(" ", firstFive));
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
