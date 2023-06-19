using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;



//            Create a program, that reads a list of integers from the console and receives commands to manipulate the list.
//Your program may receive the following commands:
//• Delete { element} – delete all elements in the array, which are equal to the given element.
//• Insert { element}
//            { position} – insert the element at the given position.
//You should exit the program when you receive the "end" command.Print all numbers in the array, separated by a
//single whitespace.

namespace _2._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string  command;
            while ((command = Console.ReadLine())!="end") 
            {
                string[] comandArg = command.Split();
                string realCmd = comandArg[0];
                if (realCmd == "Delete")
                {
                    int elementToDelete = int.Parse(comandArg[1]);
                    for(int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == elementToDelete)
                        {
                            numbers.RemoveAt(i);
                        }

                    }
                }
                else if (realCmd == "Insert")
                {
                    int elementToInsert = int.Parse(comandArg[1]);
                    int indexToInsert = int.Parse(comandArg[2]);
                    numbers.Insert(indexToInsert, elementToInsert);

                }
                

            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
