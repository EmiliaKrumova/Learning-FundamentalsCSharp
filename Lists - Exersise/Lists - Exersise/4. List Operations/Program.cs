using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

//Add {number} – add the given number to the end of the list
//• Insert {number} { index} – insert the number at the given index
//• Remove {index} – remove the number at the given index
//• Shift left {count} – first number becomes last. This has to be repeated the specified number of times
//• Shift right {count} 

namespace _4._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] comArg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string realComand = comArg[0];
                bool IsValidIndex = true;
                if (realComand == "Add")
                {
                    int numberToAdd = int.Parse(comArg[1]);
                    numbers.Add(numberToAdd);
                    // Console.WriteLine(string.Join(" ",numbers));

                }
                else if (realComand == "Insert")
                {
                    int number = int.Parse(comArg[1]);
                    int index = int.Parse(comArg[2]);
                    IsValidIndex = ValidationOfIndex(numbers, IsValidIndex, index);
                    if (!IsValidIndex)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.Insert(index, number);

                }
                else if (realComand == "Remove")
                {
                    int index = int.Parse(comArg[1]);
                    IsValidIndex = ValidationOfIndex(numbers, IsValidIndex, index);
                    if (!IsValidIndex)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.RemoveAt(index);

                }
                else if ((realComand == "Shift"))
                {
                    string direction = comArg[1];
                    int countOfShifts = int.Parse(comArg[2]);
                    int optimizatedShifts = countOfShifts % numbers.Count;
                    if (direction == "left")
                    {
                        for (int i = 0; i < optimizatedShifts; i++)
                        {
                            numbers.Add(numbers[0]);
                            numbers.Remove(numbers[0]);
                            //Console.WriteLine(string.Join(" ",numbers));
                        }

                    }
                    else if (direction == "right")
                    {
                        for (int i = 0; i < optimizatedShifts; i++)
                        {
                            numbers.Insert(0, numbers[numbers.Count - 1]);
                            numbers.RemoveAt(numbers.Count - 1);

                        }
                    }

                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        private static bool ValidationOfIndex(List<int> numbers, bool IsValidIndex, int index)
        {
            if (index < 0 || index >= numbers.Count)
            {
                IsValidIndex = false;
            }

            return IsValidIndex;
        }
    }
}
