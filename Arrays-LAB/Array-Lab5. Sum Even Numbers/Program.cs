using System;
using System.Linq;

namespace Array_Lab5._Sum_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();// прочитам числа от конзолата, разделени с интервал
            int [] arrayNumbers = numbers.Split().Select(int.Parse).ToArray();// разделям ги по интервала, парсвам към int и пълня масив.
            int sumEvenNumbers = 0;
            for (int i = 0; i < arrayNumbers.Length; i++) //обхождам масива
            {
                if (arrayNumbers[i]%2==0)// проверявам дали числото е четно
                {
                    sumEvenNumbers += arrayNumbers[i]; // прибавям в сумата на четните числа
                }
            }Console.WriteLine(sumEvenNumbers);
        }
    }
}
