using System;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.IO;

namespace _3._House_Party
{
    //    Create a program that keeps track of the guests that are going to a house party.On the first line, of input you are
    //going to receive the number of commands that will follow.

    //On the next lines, you are going to receive some of the following: "{name} is going!"

    //• You have to add the person, if they are not on the guestlist already.
    //• If the person is on the list print the following to the console: "{name} is already in the list!"

    //"{name} is not going!"
    //• You have to remove the person, if they are on the list.
    //• If not, print out: "{name} is not in the list!"
    //Finally, print all of the guests, each on a new line
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();
            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split(' ');
                string name = command[0];
                if (command.Length == 3)
                {

                    if (names.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                        continue;
                    }

                    names.Add(name);
                    //Console.WriteLine(string.Join(" ", names));

                }
                else if (command.Length == 4)
                {

                    if (names.Contains(name))
                    {
                        names.Remove(name);

                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }



                }

            }
            Console.WriteLine(string.Join(Environment.NewLine, names));// принтиране на всеки елемент на нов ред на лист
        }
    }
}
