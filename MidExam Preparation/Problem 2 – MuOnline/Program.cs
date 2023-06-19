using System;
using System.Threading;

namespace Problem_2___MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int bitcoins = 0;
            string[] dungeonsRooms = Console.ReadLine().Split('|');
            int roomCounter = 0;
            foreach(string room in dungeonsRooms)
            {
                string[] currRoom = room.Split(" ");
                roomCounter++;
                
                string command = currRoom[0];
                int amount = int.Parse(currRoom[1]);    
                if(command== "potion")
                {
                    if (health + amount > 100)
                    {
                        Console.WriteLine($"You healed for {100-health} hp.");
                        health = 100;
                    }
                    else
                    {
                        health += amount;
                        Console.WriteLine($"You healed for {amount} hp.");
                    }
                    Console.WriteLine($"Current health: {health} hp.");
                }else if(command== "chest")
                {
                    bitcoins += amount;
                    Console.WriteLine($"You found {amount} bitcoins.");
                }
                else
                {
                    health-= amount;
                    if(health > 0)
                    {
                        Console.WriteLine($"You slayed {command}.");

                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {roomCounter}");
                        break;
                    }
                }

            }if (health > 0)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}
