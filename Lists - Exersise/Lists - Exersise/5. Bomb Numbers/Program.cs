using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();// получавам масив от числа
            int[] bombAndPower = Console.ReadLine() // числото(бомба) и колко числа около него са "поразени" от силата на бомбата
                .Split()
                .Select(int.Parse)
                .ToArray();
            int bombNumber = (bombAndPower[0]); //бомба
            int bombPower = (bombAndPower[1]);// "сила" на бомбата
            
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == bombNumber) // намирам число, съвпадащо с бомбата
                {
                    int bombIndex = i;// индекса на бомбата е настоящия индекс
                    int startBoomIndex = ExplodeBomb(list, bombPower, bombIndex);// начален индекс на взрива
                    i = startBoomIndex - 1;// заради инкрементирането на фор цикъла, трябва да върна едно назад, за да не пропусна в търсенето на евентуална нова бомба един елемент

                }
            }
            int sumOfList = list.Sum();// готов метод за сумиране на лист

            Console.WriteLine(sumOfList);
           
        }

        private static int ExplodeBomb(List<int> list, int bombPower, int bombIndex)
        {
            int startBoomIndex = bombIndex - bombPower;// началния индекс е индекса, на който се намира бомбата - силата на бомбата(колко числа ще засегне наляво в листа)
            if (startBoomIndex < 0)// ако излезе извън листа
            {
                startBoomIndex = 0;// началния индекс на взрива е 0
            }
            int endBoomIndex = bombIndex + bombPower;// крайния индекс е индекса на бмбата + силата й (колко числа надясно ще "гръмнат"
            if (endBoomIndex > list.Count)// ако крайния индекс излезе извън листа->
            {
                endBoomIndex = list.Count - 1;// слагам последния индекс на масива за краен индекс
            }
            int elementsToBoom = endBoomIndex - startBoomIndex + 1;// колко елемента общо ще "гръмнат" + самата бомба
            list.RemoveRange(startBoomIndex, elementsToBoom);// премахни от оригиналния лист, броя на гръмналите елементи и самата бомба, като започнеш от стартовия индекс
            return startBoomIndex;// върни стартовия индекс, за да завърти наново цикъла
        }
    }

      
}
