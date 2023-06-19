using System;
using System.Linq;

namespace Problem_3___Hearth_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] houses = Console.ReadLine().Split('@').Select(int.Parse).ToArray();
            string command;
            int index = 0;
            while ((command = Console.ReadLine()) != "Love!")
            {
                string[] comArg = command.Split();
                int jumpLenght = int.Parse(comArg[1]);
                index += jumpLenght;
                if (index>=houses.Length)
                {
                    index= 0;
                }
                if (houses[index] == 0)
                {
                    Console.WriteLine($"Place {index} already had Valentine's day.");
                    continue;
                }
                
                else if (houses[index] - 2 >= 0)
                {
                    houses[index] -= 2;
                    if (houses[index] == 0)
                    {
                        Console.WriteLine($"Place {index} has Valentine's day.");
                    }
                }

            }
            Console.WriteLine($"Cupid's last position was {index}.");
             if (houses.All(x => x == 0))
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                int sadHousesCounter = 0;
                for(int i = 0; i < houses.Length; i++)
                {
                    if (houses[i] > 0)
                    {
                        sadHousesCounter++;
                    }

                }
                Console.WriteLine($"Cupid has failed {sadHousesCounter} places.");
            }
        }
    }
}
