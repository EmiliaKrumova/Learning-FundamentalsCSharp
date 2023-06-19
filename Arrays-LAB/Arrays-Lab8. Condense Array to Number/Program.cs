using System;
using System.Linq;

namespace Arrays_Lab8._Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]integers = (Console.ReadLine()).Split().Select(int.Parse).ToArray(); // чета масива
            

            
            while (integers.Length > 1) // до  дължината на масива
            {
                int[] condensed = new int[integers.Length - 1]; // създавам втори масив с дължина= на дължината на предния -1
                //!!! реално втория масив ще е винаги с един елемент по-малък
                for (int i = 0; i < integers.Length-1; i++)//въртя първия масив
                {
                    condensed[i] = (integers[i] + integers[i + 1]);// всяко число от първия масив, го събирам със съседното до него (а,б,в--.а+б,б+в)
                    //Console.WriteLine(integers[i]);
                   // Console.WriteLine(condensed[i]);

                }
                integers = condensed;// след цикъла приравнявам първия масив на втория, реално по този начин му намалявам дължината с 1 на всяко завъртане на while
                
                //Console.WriteLine(condensed.Length);

            }
            Console.WriteLine(integers[0]);// накрая принтирам единствения елемент, който е останал в масива
            
        }
    }
}
