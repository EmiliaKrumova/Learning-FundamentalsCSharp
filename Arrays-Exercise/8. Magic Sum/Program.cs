﻿using System;
using System.Linq;

namespace _8._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToArray();
            int neededSum = int.Parse(Console.ReadLine());
            for(int i = 0;i< numbers.Length;i++)
            {
                for(int j = i+1; j<numbers.Length;j++)
                {
                    int currentSum = numbers[j] + numbers[i];
                    if (currentSum == neededSum)
                    {
                        Console.WriteLine($"{numbers[i]} {numbers[j]}");
                    }
                }
            }
        }
    }
}
