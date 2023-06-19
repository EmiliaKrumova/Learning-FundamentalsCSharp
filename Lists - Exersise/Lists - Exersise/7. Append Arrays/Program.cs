using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> bigList = Console.ReadLine()// чета началния стринг масив и го разделям по |
                .Split('|')
                .ToList();
           List <int> finalList = new List<int>();// правя си нов, празен инт лист
            for(int i = bigList.Count-1; i >= 0; i--)// въртя от дясно на ляво големия стринг
            {
               
                List<int> substring  = bigList[i]// всеки елемент от големия стринг го взимам като лист от числа, като премахвам излишните интервали (иначе можеше да се реши и само със стринг променлива)
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                finalList.AddRange( substring);// добавям елемента към финалния лист
            }
            
          
            
            Console.WriteLine(string.Join(" ", finalList));
        }
    }
}
