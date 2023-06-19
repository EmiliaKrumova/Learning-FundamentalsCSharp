using System;
using System.Linq;

namespace _9._Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenghtOfArrays = int.Parse(Console.ReadLine());// дължина на масива
            string command = Console.ReadLine(); // команда
            int bigestSumOfOnes = 0;// най-голямa сума 
            int longestSequence = 0;
            int leftMostStartingIndex = 0;// най - малък индекс на първата единица
            int[] clone = new int[lenghtOfArrays];
            int bestSequenceIndex = 0;
            bool isBestSequence = false;
            while (command != "Clone them!")// До команда клонирай------------------------------------------------------------
            {
                int[] sequence = command.Split('!', StringSplitOptions.RemoveEmptyEntries)// масив сплитнат по удивителни знаци
                    .Select(int.Parse)
                    .ToArray();
                int currSumOfOnes = 0;// текущата сума
                int currLenghtOfSequence = 1; // дължна на поредицата
                int indexFoundFirstOne = 0;
                for (int i = 0; i < sequence.Length; i++)//-------------------------------------------------------
                {
                    int currNum = sequence[i];// сегашното число
                    int nextNum =0;
                    if (i<sequence.Length - 1)
                    {
                         nextNum = sequence[i + 1];//следващото число 
                    }
                                      
                    
                    if (currNum == 1) // ако числото е единица
                    {
                        currSumOfOnes++;// увеличавам текущата сума
                        
                        if (currNum == nextNum)
                        {
                            currLenghtOfSequence++;// увеличавам дължината
                        }
                    }
                    if (currLenghtOfSequence > longestSequence)
                    {
                        isBestSequence= true;
                        longestSequence = currLenghtOfSequence;
                        if (indexFoundFirstOne >= i)
                        {
                            indexFoundFirstOne = i;// индекс на който съм намерила първата единица (това работи само първия път!!!)
                        }
                        else
                        {
                            isBestSequence = false;
                        }
                        if (indexFoundFirstOne <= leftMostStartingIndex) // ако индекса е по-наляво, го сложи за най-ляв
                        {
                            leftMostStartingIndex = indexFoundFirstOne;
                            if (currSumOfOnes > bigestSumOfOnes && isBestSequence)// !!!! Tози код трябва да иде по-надолу
                            {
                                bigestSumOfOnes = currSumOfOnes;
                            }
                            if (currSumOfOnes >= bigestSumOfOnes)
                            {
                                
                                Array.Copy(sequence, 0, clone, 0, clone.Length);
                                bestSequenceIndex++;
                                // търся начин да копирам масива, заедно с нулите, който отговаря на условията
                                continue;
                                
                            }
                            bestSequenceIndex++;
                            Array.Copy(sequence, 0, clone, 0, clone.Length);
                            continue;
                        }
                        else
                        {
                            isBestSequence= false;
                        }
                        Array.Copy(sequence, 0, clone, 0, clone.Length);
                        bestSequenceIndex++;
                    }else
                    {
                        isBestSequence = false;
                    }


                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bigestSumOfOnes}.");
            Console.WriteLine(String.Join(" ", clone));


            //ТОЗИ ВАРИАНТ ДАВА 20 ТОЧКИ!!!!
        }
    }
}
