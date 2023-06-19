using System;
using System.Linq;

namespace Arrays_Lab7._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string array1String = Console.ReadLine();
            string array2String = Console.ReadLine();// получавам масиви с еднаква дължина
            int[]array1 = array1String.Split().Select(int.Parse).ToArray();
            int[]array2 = array2String.Split().Select(int.Parse).ToArray();
            int sumOfItems = 0;
            bool AreEqualArrays = false;
            for(int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])// сравнявам всеки един индекс от двата масива
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    AreEqualArrays = false;
                    break;
                }else
                {
                    sumOfItems += array1[i];
                    AreEqualArrays = true;
                }
            }
            if (AreEqualArrays)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sumOfItems}");
            }
        }
    }
}
