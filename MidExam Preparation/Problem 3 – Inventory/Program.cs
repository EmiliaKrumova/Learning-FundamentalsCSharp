using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3___Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<string> items = Console.ReadLine().Split(", ").ToList();
            string command;
            while ((command = Console.ReadLine())!= "Craft!")
            {
                string[] comArg = command.Split(" - ");
                string realCom = comArg[0];
                if(realCom == "Collect")
                {
                    string item = comArg[1];
                    if (items.Contains(item))
                    {
                        continue;
                    }
                    else
                    {
                        items.Add(item);
                    }

                }else if(realCom == "Drop")
                {
                    string item = comArg[1];
                    if (items.Contains(item))
                    {
                        items.Remove(item);
                    }
                    else
                    {
                        continue;
                    }

                }else if (realCom == "Combine Items")
                {
                    string[] oldAndNew = comArg[1].Split(":");
                    string newItem = oldAndNew[1];
                    string oldItem = oldAndNew[0];
                    if(items.Contains(oldItem))
                    {
                        int index = items.IndexOf(oldItem);
                        items.Insert(index+1, newItem);
                    }
                    else
                    {
                        continue;
                    }

                }else if ((realCom == "Renew"))
                {
                    string item = comArg[1];
                    if (items.Contains(item))
                    {
                        items.Remove(item);
                        items.Add(item);
                    }
                    else
                    {
                        continue;
                    }
                }

            } Console.WriteLine(string.Join(", ", items));
        }
    }
}
