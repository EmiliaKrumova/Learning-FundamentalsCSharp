using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Fold_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int arrLength = array.Length;
            int k = arrLength / 4;
            List<int> firstRow = new List<int>();
            for (int i = k - 1; i >= 0; i--)
            {
                firstRow.Add(array[i]);

            }
            for (int i = arrLength - 1; i >= 3 * k; i--)
            {
                firstRow.Add(array[i]);
            }
            List<int> secondRow = new List<int>();
            for (int i = k; i < 3 * k; i++)
            {
                secondRow.Add(array[i]);
            }

            List<int> sumRow = new List<int>();
            for (int i = 0; i < firstRow.Count; i++)
            {
                int sum = firstRow[i] + secondRow[i];
                sumRow.Add(sum);
            }
            Console.WriteLine(String.Join(" ", sumRow));
        }
    }
}
