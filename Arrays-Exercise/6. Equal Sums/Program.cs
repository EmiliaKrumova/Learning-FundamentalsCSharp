using System;
using System.Linq;

namespace _6._Equal_Sums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();// масив от инт
            int leftSum = 0; // лява сума
            int rightSum = 0;// дясна сума
            bool isEqual = false;// лява сума=дясна сума

            for (int index = 0; index < numbers.Length; index++)// обход по целия масив
            {
                int currentNumber = numbers[index]; //текущо число
                for(int j = 0; j<index; j++) // разделям оригиналния масив и обхождам само отляво на числото
                {
                    leftSum += numbers[j];// трупам в лява сума
                }
                for( int k = index+1;k<numbers.Length;k++)// обхождам само отдясно на числото
                {
                    rightSum += numbers[k];// трупам в дясна сума
                }
                if (leftSum==rightSum)// ако са еднакви сумите
                {
                    isEqual = true;
                    Console.WriteLine(index); break;// отпечатвам индекса на текущото число
                }
                else// ако не са еднакви, занулявам сумите, за да завърти цикъла наново
                {
                    leftSum = 0;
                    rightSum = 0;
                }
                
            }
          
            if (!isEqual)// ако не се намери за всички числа случай с еднакви суми, трябва да изпише "не"
            {
                Console.WriteLine("no");
            }
        }
    }
}
