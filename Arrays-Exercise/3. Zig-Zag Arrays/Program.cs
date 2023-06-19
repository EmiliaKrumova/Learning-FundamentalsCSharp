using System;
using System.Linq;

namespace _3._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputLines = int.Parse(Console.ReadLine());// броя на редовете
            int[] firstArr = new int[numberOfInputLines]; //празен първи масив с големина=броя на редовете
            int[] secondArr = new int[numberOfInputLines];//празен втори масив с големина=броя на редовете
            for (int j = 0; j < numberOfInputLines; j++)// цикъл до броя на редовете 0,1,2,3,
            {
                int[] numbersInString = Console.ReadLine().Split().Select(int.Parse).ToArray(); // 1ви ред сплит на двете числа
                for (int i = 0; i < numbersInString.Length; i++) // цикъл да завъртя двете числа
                {
                    if (j%2==0 && i%2==0) // ако е на четен ред, на четен индекс, пълни 1-я масив
                    {
                        firstArr[j] = numbersInString[i];//
                    }else if (j%2==0 && i%2!=0)// ако е на четен ред на нечетен индекс - пълни 2-я масив
                    {
                        secondArr[j] = numbersInString[i];
                    }else if (j%2!=0 && i % 2 != 0) //ако е на нечетен ред, на нечетен индекс, пълни 1-я масив
                    {
                        firstArr[j] = numbersInString[i];
                    } else if (j%2!=0 && i%2==0)// ако е на нечетен ред, на четен индекс, пълни 2 - я масив
                    {
                        secondArr[j] = numbersInString[i];
                    }
                }
            }
            for (int k = 0; k<firstArr.Length; k++) // прочети и изпиши 1 масив
            {
                Console.Write($"{firstArr[k]} ");
               
                
            }Console.WriteLine(); // прочети и изпиши 2 масив
            for (int k = 0; k <secondArr.Length; k++)
            {
                Console.Write($"{secondArr[k]} ");
            }
        }
    }
}
