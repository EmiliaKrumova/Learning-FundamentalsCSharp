using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstlist = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondlist = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> finalList = new List<int>();
            if(firstlist.Count >= secondlist.Count)
            {
                for(int i = 0; i < secondlist.Count; i++)
                {
                    finalList.Add(firstlist[i]);
                    finalList.Add(secondlist[i]);
                }
                finalList.Skip(secondlist.Count);
                for (int i = secondlist.Count; i < firstlist.Count; i++)
                {
                    finalList.Add(firstlist[i]);
                }

            }
            else
            {
                for (int i = 0; i < firstlist.Count; i++)
                {
                    finalList.Add(firstlist[i]);
                    finalList.Add(secondlist[i]);
                }
                finalList.Skip(firstlist.Count);
                for(int i = firstlist.Count;i < secondlist.Count; i++)
                {
                    finalList.Add(secondlist[i]);
                }
            }
            Console.WriteLine(string.Join(" ", finalList));
        }
    }
}
