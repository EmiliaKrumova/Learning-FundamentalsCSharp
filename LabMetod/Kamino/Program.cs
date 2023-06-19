using System;
using System.Linq;

namespace Kamino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = int.Parse(Console.ReadLine());// дължина на масива

            int longestSequence = default;// най-дълга поредица
            int[] longestSequanceArray = new int[arrayLength];// празен масив
            int biggestSum = default;// най-голяма сума
            int sampleCounter = default;// брояч за масиви
            int bestSampleNumber = default;// най-добър масив
            int sequenceStart = default;// най-ляв индекц

            string end;
            while ((end = Console.ReadLine()) != "Clone them!")
            {
                int[] current = new int[arrayLength];// текущ масив

                current = end.Split("!").Select(int.Parse).ToArray();

                int counter = 1;// брояч за дължина на поредицата
                int currentSum = current[0]; //текуща сума
                int currentSequenceStart = default;// най-ляв индекс
                sampleCounter++;

                for (int i = 1; i < current.Length; i++)
                {
                    currentSum += current[i];

                    if (current[i - 1] == current[i] && current[i] != 0)
                    {
                        counter++;
                        currentSequenceStart = i - 1;// тук какво ще стане ако са 3 единици???
                    }
                }

                if (counter > longestSequence) // Проверявам дължината на поредицата ако е по-голяма записвам новата като най-голяма
                {
                    longestSequanceArray = current;
                    longestSequence = counter;
                    biggestSum = currentSum;
                    bestSampleNumber = sampleCounter;
                    sequenceStart = currentSequenceStart;
                }
                else if (counter == longestSequence)  //Ако са равни
                {

                    if (currentSequenceStart < sequenceStart)  //Проверявам от кой индекс започват ако новата започва от по-рано я записвам като най-голяма
                    {
                        longestSequanceArray = current;
                        longestSequence = counter;
                        biggestSum = currentSum;
                        bestSampleNumber = sampleCounter;
                        sequenceStart = currentSequenceStart;

                    }
                    else if (currentSequenceStart == sequenceStart && currentSum > biggestSum) // ако почват от един и същ индекс проверявам коя има по голям сбор
                    {
                        longestSequanceArray = current;
                        longestSequence = counter;
                        biggestSum = currentSum;
                        bestSampleNumber = sampleCounter;
                        sequenceStart = currentSequenceStart;
                    }
                }
            }
            Console.WriteLine($"Best DNA sample {bestSampleNumber} with sum: {biggestSum}.");
            Console.Write(string.Join(" ", longestSequanceArray));
        }
    }
}
