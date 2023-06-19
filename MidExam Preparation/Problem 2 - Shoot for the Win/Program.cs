using System;
using System.Linq;

namespace Problem_2___Shoot_for_the_Win
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]targets = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string command;
            int counter = 0;
            while ((command = Console.ReadLine()) != "End")
            {
                int shotIndex = int.Parse(command);
                if (shotIndex < 0 || shotIndex>=targets.Length)
                {
                    continue;
                }
                int shotNumber = targets[shotIndex];
                targets[shotIndex] = -1;
                counter++;
                for(int i =  0; i < targets.Length; i++)
                {
                    if (i == shotIndex)
                    {
                        continue;
                    }
                    if (targets[i]==-1)
                    {
                        continue;
                    }
                    if (targets[i] <= shotNumber)
                    {
                        targets[i] +=shotNumber;
                    }
                    else if (targets[i] > shotNumber)
                    {
                        targets[i] -= shotNumber;
                    }
                }

            }Console.WriteLine($"Shot targets: {counter} -> {string.Join(" ", targets)}");
        }
    }
}
