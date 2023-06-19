using System;

namespace Arrays_Lab2._Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());// получавам големината на масива от конзолата
            int [] numbersArray =  new int [n]; // създавам масив, който е с големина числото от конзолата (n)
            for (int i=0; i<n; i++)         // въртя цикъл от 0 до числото n (по този начин ще си наслагам числата по индексите)
            {
                int currentNumber = int.Parse(Console.ReadLine());// чета n на брой числа от конзолата
                numbersArray[i] = currentNumber;                // на съответния индекс на цикъла, слагам число в масива т.е ако i=0 --> числото от конзолата ще иде на индекс 0 в масива и т.н....
            }

            // За да ги отпечатам в ОБРАТЕН РЕД!
            for (int j= numbersArray.Length-1; j>=0; j--)       // Въртя цикъл от дължината на масива - 1 до 0, ОБРАТЕН ЦИКЪЛ!!!
            {
                Console.Write($"{numbersArray[j]} ");       // ПРИНТИРАМ НА ЕДИН РЕД ВСЯКО ЧИСЛО, РАЗДЕЛЕНО С ИНТЕРВАЛ.
            }
            
        }
    }
}
