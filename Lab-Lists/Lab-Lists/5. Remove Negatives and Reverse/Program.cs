using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();  
           // List<int> result = new List<int>();
            //foreach (int i in list)
            //{
            //    if (i>=0)
            //    {
            //        result.Add(i);
            //    }
            //}
            list.RemoveAll(x => x < 0 );// премахни всеки елемент, който отговаря на условието да е по-малък от нула
            list.Reverse();
            if (list.Count > 0)
            {
                Console.WriteLine(string.Join(" ",list));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
