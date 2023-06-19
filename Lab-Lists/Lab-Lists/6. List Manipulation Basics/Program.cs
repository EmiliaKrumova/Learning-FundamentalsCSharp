using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace _6._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command;
            bool isModified = false;
            while(( command = Console.ReadLine())!= "end")
            {
                string realcommand = command.Split()[0];
                if (realcommand == "Add")
                {
                    int number = int.Parse(command.Split()[1]);
                    list.Add(number);
                    isModified = true;
                }else if(realcommand == "Remove")
                {
                    int number = int.Parse((command.Split()[1]));
                    list.Remove(number);
                    isModified = true;
                }else if(realcommand == "RemoveAt")
                {
                    int index = int.Parse((command.Split()[1]));
                    for(int i = 0; i < list.Count; i++)
                    {
                        if (i==index)
                        {
                            list.RemoveAt(i);
                        }
                    }
                    isModified = true;
                }else if (realcommand == "Insert")
                {
                    int number = int.Parse((command).Split()[1]);
                    int index = int.Parse((command).Split()[2]);
                    list.Insert(index, number);
                    isModified = true;
                }else if (realcommand == "Contains")
                {
                    int number = int.Parse((command).Split()[1]);
                    bool contains = list.Contains(number);
                    if (contains)
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }else if ((realcommand == "PrintEven"))
                {
                    foreach(int x in list)
                    {
                        if (x %2 == 0)
                        {
                            Console.Write(x + " ");
                        }
                                                      

                    }Console.WriteLine();
                }else if(realcommand == "PrintOdd")
                {
                    foreach (int x in list)
                    {
                        if (x % 2 != 0)
                        {
                            Console.Write(x + " ");
                        }


                    }
                    Console.WriteLine();
                }else if((realcommand == "GetSum"))
                {
                    int sum = 0;
                    foreach(int x in list)
                    {
                        sum += x;
                    }
                    Console.WriteLine(sum);
                }else if(((realcommand == "Filter")))
                {
                    string condition = command.Split()[1];
                    int number = int.Parse(command.Split()[2]);
                    switch (condition)
                    {
                        case "<":
                            for (int i = 0; i < list.Count; i++)
                            {
                               if(list[i] < number)
                                {
                                    Console.Write(list[i] + " ");
                                }
                            }
                            Console.WriteLine() ;
                            
                            break;
                        case ">":
                            for (int i = 0; i < list.Count; i++)
                            {
                                if (list[i] > number)
                                {
                                    Console.Write(list[i] + " ");
                                }
                            }
                            Console.WriteLine();
                            break;
                        case "<=":
                            for (int i = 0; i < list.Count; i++)
                            {
                                if (list[i] <= number)
                                {
                                    Console.Write(list[i] + " ");
                                }
                            }
                            Console.WriteLine();
                            break;
                        case ">=":
                            for (int i = 0; i < list.Count; i++)
                            {
                                if (list[i] >= number)
                                {
                                    Console.Write(list[i] + " ");
                                }
                            }
                            Console.WriteLine();
                            break;
                    }
                }
            } if (isModified)
            {
                Console.WriteLine(string.Join(" ", list));
            }
            
        }
    }
}
//• Contains {number} – check if the list contains the number and if so - print "Yes", otherwise print
//"No such number".
//• PrintEven – print all the even numbers, separated by a space.
//• PrintOdd – print all the odd numbers, separated by a space.
//• GetSum – print the sum of all the numbers.
//• Filter {condition} { number} – print all the numbers that fulfill the given condition. The condition 
//will be either '<', '>', ">=", "<="
