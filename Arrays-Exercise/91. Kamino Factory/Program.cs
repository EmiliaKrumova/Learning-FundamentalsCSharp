using System;
using System.Linq;
using System.Numerics;

namespace _91._Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenghtOfDNA = int.Parse(Console.ReadLine()); // дължината на масива
            string command = Console.ReadLine(); // команда
            int bestSequenceIndex = 0;// брояч на поредиците
            int curentSeqIndex = 0;// текущ номер на поредица
            int bigestSum = 0;// най-голяма сума
            int leftmostIndex = lenghtOfDNA; // най ляв индекс
            int longestSubsequence = 0;// най-дълга поредица от единици
            //bool isBestSequence = false;// булева
            int[] clonedDnaSequence = new int[lenghtOfDNA];// масив "клонинг"
            //_______________________________________________________________________________________________

            while (command != "Clone them!")
            {
                curentSeqIndex++;
                int[] currentDnaSequence = command.Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray(); // разделям масива по удивителна

                int currSum = 0;// текуща сума
                int currLength = 1;// текуща дължина
                int currentLeftIndex = currentDnaSequence.Length;
                //---------------------------------------------------------------------------------------------------------

                for (int i = 0; i < currentDnaSequence.Length; i++)
                {
                    int currNum = currentDnaSequence[i];//текущото число
                    int currIndex = i;// текущия индекс

                    if (currNum == 1)// ако сегашното число е 1
                    {
                        currSum += currentDnaSequence[i]; //увеличи текущата сума с 1
                        
                        //if(currSum>bigestSum)
                        //{
                        //    bigestSum= currSum;
                        //}                        
                        if (i < currentDnaSequence.Length - 1) // проверка дали не съм извън масива
                        {
                            int nextNum = currentDnaSequence[i + 1];
                            if (nextNum == currNum)// ако следващото число е 1
                            {
                                currLength += 1;// увеличи текущата дължина с 1
                                if (currIndex <= currentLeftIndex)
                                {
                                    currentLeftIndex = currIndex;
                                }
                            }
                        }
                    }
                    else
                    {
                        continue;// ако числото е 0 - продължи итерациите
                    }

                }
                if (currLength >= longestSubsequence)// ако текущата дължина е по-голяма или = на най-дългата поредица
                {
                    if (currLength > longestSubsequence)
                    {
                       // isBestSequence= true;
                        bigestSum = currSum;
                        longestSubsequence=currLength;
                        leftmostIndex = currentLeftIndex;
                        Array.Copy(currentDnaSequence, 0, clonedDnaSequence, 0, lenghtOfDNA);// клонирам
                        bestSequenceIndex = curentSeqIndex;

                    }else if (currLength == longestSubsequence)
                    {
                        if (currentLeftIndex<leftmostIndex)
                        {
                            //isBestSequence= true;
                            bigestSum= currSum;
                            longestSubsequence= currLength;
                            leftmostIndex= currentLeftIndex;
                            Array.Copy(currentDnaSequence, 0, clonedDnaSequence, 0, lenghtOfDNA);// клонирам
                            bestSequenceIndex = curentSeqIndex;
                        }else if(currentLeftIndex == leftmostIndex)
                        {
                            if (bigestSum < currSum)
                            {
                                //isBestSequence= true;
                                bigestSum= currSum;
                                longestSubsequence= currLength;
                                leftmostIndex= currentLeftIndex;
                                Array.Copy(currentDnaSequence, 0, clonedDnaSequence, 0, lenghtOfDNA);// клонирам
                                bestSequenceIndex= curentSeqIndex;
                            }
                          
                        }
                     
                    }
             
                }
             
                command = Console.ReadLine();
            }
            
               
                Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bigestSum}.");
                Console.WriteLine(String.Join(" ", clonedDnaSequence));


           


        }
    }
}
