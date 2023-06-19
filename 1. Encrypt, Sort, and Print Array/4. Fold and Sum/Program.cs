using System;
using System.Linq;

namespace _4._Fold_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ' ,StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int arrLength = array.Length;
            int k = arrLength / 4;
            int[] leftEdge= new int[2*k];
            //int[] rightEdge= new int[arrLength/4];
            int[]center = new int[2*k];
           // int leftStopIndex = arrLength/4-1;
            //int rightStopIndex = arrLength / 2 * 3;
            for(int i = 0;i<array.Length;i++)
            {
                for(int j = 0; j< leftEdge.Length/2; j++)
                {
                    leftEdge[j] = array[i];
                }
                for(int j = leftEdge.Length/2;j>0;j--)
                {
                    leftEdge[j] = array[i];
                }
                
               

            }
           
        }
    }
}
