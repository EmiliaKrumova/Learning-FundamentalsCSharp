using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3___Moving_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command;
           
            while((command = Console.ReadLine()) != "End")
            {
                string[] comArgs = command.Split(" ");
                string realComand = comArgs[0];
                int index = int.Parse(comArgs[1]);
                bool isValidIndex = (index >= 0 && index<targets.Count);
                if(realComand== "Shoot")
                {
                    if(isValidIndex)
                    {
                        int power = int.Parse(comArgs[2]);
                        targets[index] -= power;
                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                   // Console.WriteLine(string.Join(" ", targets));
                }else if (realComand== "Add")
                {
                    int value = int.Parse(comArgs[2]);
                    if(isValidIndex)
                    {
                        targets.Insert(index,value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }else if(realComand== "Strike")
                {
                    int radius = int.Parse(comArgs[2]);
                    int rangeStart = index - radius;
                    int rangeEnd = index + radius;
                    bool isValidRange = (rangeStart >= 0 && rangeStart< targets.Count && rangeEnd>=0 &&rangeEnd<targets.Count);
                    if(isValidRange)
                    {
                        targets.RemoveRange(rangeStart,radius*2+1);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                        continue;
                    }
                }


            }Console.WriteLine(string.Join("|", targets));
        }
    }
}
