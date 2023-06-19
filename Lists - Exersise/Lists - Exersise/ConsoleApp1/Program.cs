using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToList();
           int maxCapacity = int.Parse(Console.ReadLine());
            string command;
            while ((command = Console.ReadLine()) != "end") 
            {
               string []commandArg =  command.Split();
                if (commandArg[0] == "Add")
                {
                   int  numberOfPeople = int.Parse(commandArg[1]);
                    wagons.Add(numberOfPeople);
                   

                }
                else
                {
                    int newPassengers = int.Parse(commandArg[0]);
                    for(int i = 0;i<wagons.Count;i++)
                    {
                        if (wagons[i] + newPassengers<= maxCapacity)
                        {
                            wagons[i] = wagons[i] + newPassengers;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
