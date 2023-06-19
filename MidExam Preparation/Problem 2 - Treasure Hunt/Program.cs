using System;
using System.Collections.Generic;
using System.Linq;

//Gold|Silver|Bronze|Medallion|Cup
//Loot Wood Gold Coins
//Loot Silver Pistol
//Drop 3
//Steal 3
//Yohoho!


namespace Problem_2___Treasure_Hunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> treasure  = Console.ReadLine()
                .Split("|",StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string command;
            while((command = Console.ReadLine()) != "Yohoho!")
            {
                List<string> comArgs = command.Split(" ").ToList();
                string realCmd = comArgs[0];
                if(realCmd == "Loot")
                {
                   // List<string> items = new List<string>(comArgs.Count-3);
                   // items.AddRange(comArgs);
                   comArgs.RemoveAt(0);
                    for(int i = 0; i < comArgs.Count; i++)
                    {
                        if (treasure.Contains(comArgs[i]))
                        {
                            continue;
                        }
                        else
                        {
                            treasure.Insert(0, comArgs[i]);
                        }
                    }
                   // Console.WriteLine(string.Join(" ", treasure));

                }else if(realCmd == "Drop")
                {
                    int index =int.Parse(comArgs[1]);
                    if(index < 0|| index>= treasure.Count)
                    {
                        continue;
                    }
                    else
                    {
                        string itemToAdd = treasure[index];
                        treasure.RemoveAt(index);
                        treasure.Add(itemToAdd);
                    }
                   // Console.WriteLine(string.Join(" ", treasure));

                }
                else if (realCmd == "Steal")
                {
                    int count = int.Parse(comArgs[1]);
                    if (count > treasure.Count) 
                    { 
                        count = treasure.Count;
                    }
                    
                    List<string> itemsToSteal = new List<string>(count);

                    for(int i = 1; i<=count; i++)
                    {
                        itemsToSteal.Add(treasure[treasure.Count-1]);
                        treasure.RemoveAt(treasure.Count - 1);
                    }
                    //for (int i = treasure.Count - 1; i > treasure.Count-1 - count; i--)
                    //{
                    //    itemsToSteal.Add(treasure[i]);
                    //}
                    //if ( treasure.Count >= count)
                    //{                      

                        

                    //    treasure.RemoveRange(treasure.Count-count, count);

                    //}
                    //else
                    //{
                    //    treasure.RemoveRange(0,treasure.Count);
                    //}
                    itemsToSteal.Reverse();
                    Console.WriteLine(string.Join(", ", itemsToSteal));
                   // Console.WriteLine(string.Join(" ", treasure));
                }
            } if(treasure.Count > 0)
            {
                int sumOfChars = 0;
                for(int i = 0; i < treasure.Count; i++)
                {
                    string currItem = treasure[i];
                    int currCountOfChars = currItem.Length;
                    sumOfChars+= currCountOfChars;
                }
                double averageGain =(double)sumOfChars/treasure.Count;
                Console.WriteLine($"Average treasure gain: {averageGain:f2} pirate credits.");


            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }
    }
}
