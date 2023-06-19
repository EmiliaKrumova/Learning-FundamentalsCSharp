using System;
using System.Linq;

namespace _2._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrFirst = Console.ReadLine().Split().ToArray(); // взимам елементите от масив 1
            string[] arrSecond = Console.ReadLine().Split().ToArray();// взимам елементите от масив 2
            for (int i = 0; i < arrFirst.Length; i++)// въртя първия масив по индексите
            {
                for(int j = 0; j < arrSecond.Length; j++)// за всеки индекс на първия въртя всички индекси на втория
                {
                    if (arrFirst[i] == arrSecond[j])// сравнявам всеки индекс на 1-я масив с всеки индекс на 2-я масив
                    {
                        Console.Write($"{arrFirst[i]} ");// принтирам еднакви стрингове, които съм намерила в двата масива
                    }
                }
            }
        }
    }
}//  !!! За по-голяма коректност, може би трябва да се обърне реда на циклите - т.е първо от втория масив да се завърти фор цикъл, а да се вложи фор за първия масив
