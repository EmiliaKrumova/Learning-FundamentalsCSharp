using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2___Shopping_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> groceryList = Console.ReadLine().Split('!').ToList();
            string command;
            while((command = Console.ReadLine()) != "Go Shopping!")
            {
                string[] comArgs = command.Split(" ");
                string action = comArgs[0];
                string product = comArgs[1];
                if(action == "Urgent")
                {
                    if(groceryList.Contains(product))
                    {
                        continue;
                    }
                    groceryList.Insert(0, product);

                }else if(action == "Unnecessary")
                {
                    if (groceryList.Contains(product))
                    {
                        groceryList.Remove(product);
                    }
                    continue;

                }else if (action == "Correct")
                {
                    string secondProduct = comArgs[2];
                    if (groceryList.Contains(product))
                    {
                        int index = groceryList.IndexOf(product);
                        groceryList.RemoveAt(index);
                        groceryList.Insert(index, secondProduct);
                        // или groceryList[index] = secondProduct;
                    }
                    continue;

                }else if((action == "Rearrange"))
                {
                    if (groceryList.Contains(product))
                    {
                        groceryList.Remove(product);
                        groceryList.Add(product);
                    }
                    continue;

                }

            } Console.WriteLine(string.Join(", ", groceryList));
        }
    }
}
