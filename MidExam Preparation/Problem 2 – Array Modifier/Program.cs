using System;
using System.Collections.Immutable;
using System.Linq;

namespace Problem_2___Array_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string command;
            while((command = Console.ReadLine()) != "end")
            {
                string[] comArgs = command.Split(" ");
                string realCommand = comArgs[0];
                if(realCommand == "swap")
                {
                    int index1 = int.Parse(comArgs[1]);
                    int index2 = int.Parse(comArgs[2]);
                    int firstInt = integers[index1];
                    int secondInt = integers[index2];
                    for(int i = 0; i < integers.Length; i++)
                    {
                        if(i == index2)
                        {
                            integers[i] = firstInt;
                            
                        }
                        if(i== index1)
                        {
                            integers[i] = secondInt;
                        }
                    }
                }else if (realCommand == "multiply")
                {
                    int index1 = int.Parse(comArgs[1]);
                    int index2 = int.Parse(comArgs[2]);
                    int firstInt = integers[index1];
                    int secondInt = integers[index2];
                    int multiply = firstInt * secondInt;
                    integers[index1] = multiply;

                }else if(realCommand == "decrease")
                {
                    for(int i = 0; i < integers.Length ; i++)
                    {
                        integers[i] -= 1;
                    }
                }



                //Console.WriteLine(string.Join(" ", integers));
                //"swap {index1} {index2}"

            }
            Console.WriteLine(string.Join(", ", integers));
        }
    }
}
