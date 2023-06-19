using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Memory_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).ToList();
            string command;
            int moves = 0;
            while ((command = Console.ReadLine())!="end")
            {
                moves++;
                string[] comArgs = command.Split(" ");
                int index1 = int.Parse(comArgs[0]);
                int index2 = int.Parse(comArgs[1]);
                bool isValid = true;
                if (index1 < 0 || index1 >= list.Count || index2 < 0 || index2 >= list.Count)
                {
                    isValid = false;
                }

                if (index1 == index2 || !isValid )
                {
                    string elementToAdd = $"-{moves}a";
                    list.Insert(list.Count/2, elementToAdd);
                    list.Insert(list.Count / 2, elementToAdd);
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }else if (list[index1] == list[index2])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {list[index1]}!");
                    if (index1> index2)
                    {
                        list.RemoveAt(index1);
                        list.RemoveAt(index2);
                    }
                    else
                    {
                        list.RemoveAt(index2);
                        list.RemoveAt(index1);
                    }
                }else if (list[index1] != list[index2])
                {
                    Console.WriteLine("Try again!");
                }
                if (list.Count == 0)
                {
                    Console.WriteLine($"You have won in {moves} turns!");
                    break;
                }
            } if (list.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", list));
            }
        }

       
    }
}
