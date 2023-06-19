using System;
using System.Linq;

namespace _1._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfWagons = int.Parse(Console.ReadLine());
            int[] train = new int[countOfWagons];
            int sumOfPeople = 0;
            for (int i = 0; i< countOfWagons; i++)
            {
                train[i]= int.Parse(Console.ReadLine());
                
            }
            for (int i = 0; i< countOfWagons; i++) 
            {
                Console.Write($"{train[i]} ");
                sumOfPeople += train[i];
            }
            Console.WriteLine();
            Console.WriteLine(sumOfPeople);
        }
    }
}
