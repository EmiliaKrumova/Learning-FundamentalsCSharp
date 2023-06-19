using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfInts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();// прочитам инт масив [1 2 3 4 5]
            string command;// създавам стринг за командата (exchange 1)
            while ((command = Console.ReadLine()) != "end") // прочитам командата и ако не е енд
            {
                string[] cmdAgr = command.Split(' ');
                string realCommand = cmdAgr[0];// разделям командата на истинската команда (exchange)
                
                

                
                if (realCommand == "exchange")
                {
                    int index = int.Parse(cmdAgr[1]);// индекса от който трябва да разменям числата в масива
                    
                    if (index < 0 || index >= arrayOfInts.Length) // проверка индекса дали излиза от масива
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    arrayOfInts = ExchangeArrayMetod(arrayOfInts, index);// презаписвам в оригиналния масив новите стойности от променения масив
                    //Console.WriteLine(String.Join(" ", arrayOfInts));// изписвам променения масив
                }
                else if(realCommand == "max")// ако командата е макс
                {
                    string secondCmd = cmdAgr[1];// взимам втора команда (четно или нечетно)
                    int foundedIndex = MaxEvenOddIndex(arrayOfInts, secondCmd);// намерения индекс от метода
                    if (foundedIndex < 0)// ако не съм намерила четно или съответно нечетно число в масива - индекса ще си остане -1
                    {
                        Console.WriteLine("No matches");// изписвам, че няма съвпадения
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(foundedIndex);// ако съм намерила число, отговарящо на условието, изписвам неговия индекс в масива
                    }
                   
                }
                else if(realCommand=="min")
                {
                    string minCmd = cmdAgr[1];
                    int foundedIndex = MinEvenOddIndex(arrayOfInts, minCmd);
                    if(foundedIndex < 0)
                    {
                        Console.WriteLine("No matches");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(foundedIndex);
                    }
                }
                else if (realCommand=="first")
                {
                    int count = int.Parse(cmdAgr[1]);
                    if (count > arrayOfInts.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    string oddOrEvencmd = cmdAgr[2];
                    //int[] foundedFirstNumbers = FirstFoundedOddOrEvenNumbersArray(arrayOfInts, count, oddOrEvencmd);
                   // int [] resizedArr = ResizeOriginalArr(count, foundedFirstNumbers);
                   int[] founded = FirstFoundedOddOrEvenNumbersArray(arrayOfInts, count, oddOrEvencmd);
                    if (founded.Length > 0)
                    {
                        Console.WriteLine($"[{String.Join(", ", founded)}]");
                    }
                    else
                    {
                        Console.WriteLine("[]");
                    }
                }
                else if (realCommand == "last")
                {
                    int count = int.Parse(cmdAgr[1]);
                    if(count > arrayOfInts.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    string oddOrEvenCommand = cmdAgr[2];
                    int[] lastFounded = LastElements(arrayOfInts,count, oddOrEvenCommand);
                    if (lastFounded.Length > 0)
                    {
                        Console.WriteLine($"[{String.Join(", ", lastFounded)}]");
                    }
                    else
                    {
                        Console.WriteLine("[]");
                    }

                }



            }
            Console.WriteLine($"[{String.Join(", ", arrayOfInts)}]");
        }
        static int[] LastElements(int[] arrayOfInts,int count,string oddOrEvenCommand)
        {
            int[] lastElements = new int[count];
            int countOfFoundedLastEl = 0;
            if (oddOrEvenCommand == "even")
            {
                int indexOfLastElements = 0;
                for (int i = arrayOfInts.Length - 1; i >= 0; i--)
                {
                    int currNum = arrayOfInts[i];
                    if (currNum % 2 == 0)
                    {
                        lastElements[indexOfLastElements++] = currNum;
                        countOfFoundedLastEl++;

                    }
                    if (indexOfLastElements >= count)
                    {
                        break;
                    }
                }
                
            }
            else if (oddOrEvenCommand == "odd")
            {
                int indexOfLastElements = 0;
                for (int i = arrayOfInts.Length - 1; i >= 0; i--)
                {
                    int currNum = arrayOfInts[i];
                    if (currNum % 2 != 0)
                    {
                        lastElements[indexOfLastElements++] = currNum;
                        countOfFoundedLastEl++;

                    }
                    if (indexOfLastElements >= count)
                    {
                        break;
                    }
                }
                
            }
            int[] modifiedArr = new int[countOfFoundedLastEl];
            for (int i = 0; i < countOfFoundedLastEl; i++)
            {
                modifiedArr[i] = lastElements[i];
                if (modifiedArr[i] == 0)
                {
                    break;
                }
            }
            int []reversedArr = new int[modifiedArr.Length];
            int indexOfReversed = 0;
            for(int i = modifiedArr.Length-1;i >= 0;i--)
            {
                reversedArr[indexOfReversed++] = modifiedArr[i];
            }
            return reversedArr;
        }

        static int[] ResizeOriginalArr(int count, int[] foundedFirstNumbers)
        {
            int[] modifiedArr = new int[count];
            for (int i = 0; i < count; i++)
            {
                modifiedArr[i] = foundedFirstNumbers[i];
                if (modifiedArr[i] == 0)
                {
                    break;
                }
            }return modifiedArr;
        }

        static int[] FirstFoundedOddOrEvenNumbersArray(int[] arrayOfInts, int count, string oddOrEvencmd)
        {
            int[] firstOddOrEvenArr = new int[count];
            int countOfFoundedElements = 0;

            if (oddOrEvencmd == "even")
            {
                int firstOddEvenIndex = 0;
                for (int i = 0; i < arrayOfInts.Length; i++)
                {
                    if (arrayOfInts[i] % 2 == 0)
                    {
                        firstOddOrEvenArr[firstOddEvenIndex] = arrayOfInts[i];
                        firstOddEvenIndex++;
                        countOfFoundedElements++;

                    }
                    if (firstOddEvenIndex >= firstOddOrEvenArr.Length)
                    {
                        break;
                    }

                }

            }

            else if (oddOrEvencmd == "odd")
            {
                int firstOddEvenIndex = 0;
                for (int i = 0; i < arrayOfInts.Length; i++)
                {
                    if (arrayOfInts[i] % 2 != 0)
                    {
                        firstOddOrEvenArr[firstOddEvenIndex] = arrayOfInts[i];
                        firstOddEvenIndex++;
                        countOfFoundedElements++;

                    }
                    if (firstOddEvenIndex == firstOddOrEvenArr.Length)
                    {
                        break;
                    }
                }
            }
            int[] modifiedArr = new int[countOfFoundedElements];
            for (int i = 0; i < countOfFoundedElements; i++)
            {
                modifiedArr[i] = firstOddOrEvenArr[i];
                if (modifiedArr[i] == 0)
                {
                    break;
                }
            }
            return modifiedArr;// return firstOddOrEvenArr;
        }

        static int MinEvenOddIndex(int[] arrayOfInts, string minCmd)
        {
            int minNum = int.MaxValue;
            int indexOfMinNum = -1;
            if (minCmd == "even")
            {
                for (int i = 0; i < arrayOfInts.Length; i++)
                {
                    int currNum = arrayOfInts[i];
                    if (currNum <= minNum && currNum % 2 == 0)
                    {
                        minNum = currNum;
                        indexOfMinNum = i;
                    }
                }
            }
            else if (minCmd == "odd")
            {
                for (int i = 0; i < arrayOfInts.Length; i++)
                {
                    int currNum = arrayOfInts[i];
                    if (currNum <= minNum && currNum % 2 != 0)
                    {
                        minNum = currNum;
                        indexOfMinNum = i;
                    }
                }
            }return indexOfMinNum;
        }

        static int MaxEvenOddIndex(int[] arrayOfInts, string secondCmd)// метод, който ще връща число, което е индекса на масива и отговаря на условие да бъде най-голямото четно/ най-голямото нечетно
        {
            int maxNum = int.MinValue;// слагам мин стойност на инт-а
            int maxNumIndex = -1;// индекса в началото ще е невалиден и ако не намеря число метода ще върне -1

            if (secondCmd == "even")// ако търся четно
            {
                for (int i = 0; i < arrayOfInts.Length; i++)// въртя масива
                {
                    int currNum = arrayOfInts[i];// текущото число е равно на число от масива на индекс...

                    if (currNum % 2 == 0 && currNum >= maxNum)// ако текущото е четно и е по-голямо от максималното
                    {
                        maxNum = currNum;// сегашното е максимално
                        maxNumIndex = i;// взимам текущия индекс и го запазвам

                    }
                }
            }
            else if (secondCmd == "odd")
            {
                for (int i = 0; i < arrayOfInts.Length; i++)
                {
                    int currNum = arrayOfInts[i];
                    if (currNum % 2 != 0 && currNum >= maxNum)
                    {
                        maxNum = currNum;
                        maxNumIndex = i;

                    }
                }
            }
            return maxNumIndex;// връщам запазения индекс на най-голямото число в променливата foundedIndex

        }

         static int[] ExchangeArrayMetod(int[] arrayOfInts, int index)
        {
            int[] exchangedArray = new int[arrayOfInts.Length];// създавам празен масив от инт[0 0 0 0 0]
            int exchangedArrIndex = 0;// индекса на празния масив[0]
            for (int i = index + 1; i < arrayOfInts.Length; i++)// въртя от следващия индекс на този, който ми е даден до края на оригиналния масив (index 1+1)
            {
                exchangedArray[exchangedArrIndex] = arrayOfInts[i]; // пълня новия масив от индекс 0 [3 4 5 0 0]
                exchangedArrIndex++;// увеличавам индекса на новия масив [0++]


            }
            for (int i = 0; i <= index; i++)// взимам числата от началото на оригиналния масив до индекса включително и ги слагам в края на новия [1 2....]
            {
                exchangedArray[exchangedArrIndex] = arrayOfInts[i];//[3 4 5 1 0] [3 4 5 1 2]

                exchangedArrIndex++;
            }
            return exchangedArray;
        }
    }
}
