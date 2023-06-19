using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3___Man_O_War
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShip = Console.ReadLine().Split('>').Select(int.Parse).ToList();
            List<int> warShip = Console.ReadLine().Split('>').Select(int.Parse).ToList();
            int maxHealth = int.Parse(Console.ReadLine());
            string command;
            while((command = Console.ReadLine()) != "Retire")
            {
                string[] comArgs = command.Split(" ");
                string realCmd = comArgs[0];
                
               // IsValid(pirateShip, index);
                if (realCmd == "Fire")
                {
                    int index = int.Parse(comArgs[1]);
                    if (!IsValid(warShip, index))
                    {
                        continue;
                    }
                    int damage = int.Parse(comArgs[2]);
                    warShip[index]-=damage;
                    if (warShip[index] <= 0)
                    {
                        Console.WriteLine("You won! The enemy ship has sunken.");
                        return;
                    }

                }
                else if (realCmd == "Defend")
                {
                    int index = int.Parse(comArgs[1]);
                    int endIndex = int.Parse(comArgs[2]);
                    int damage = int.Parse(comArgs[3]);
                    if (!IsValid(pirateShip, index)|| !IsValid(pirateShip, endIndex))
                    {
                        continue;
                    }
                    else
                    {
                        for(int i = index; i <= endIndex; i++)
                        {
                            pirateShip[i] -= damage;
                            if (pirateShip[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }
                    }

                }
                else if (realCmd == "Repair")
                {
                    int index = int.Parse(comArgs[1]);
                    if (!IsValid(pirateShip,index))
                    {
                        continue;
                    }
                    else
                    {
                       int health = int.Parse(comArgs[2]);
                        pirateShip[index] += health;
                        if (pirateShip[index] > maxHealth)
                        {
                            pirateShip[index]=maxHealth;
                        }
                    }

                }
                else if ((realCmd == "Status"))
                {
                    double needRepair = maxHealth / 5.0;
                    int counterOfBadSections = 0;
                    for(int i = 0; i < pirateShip.Count; i++)
                    {
                        if (pirateShip[i] < needRepair)
                        {
                            counterOfBadSections++;
                        }

                    }
                    Console.WriteLine($"{counterOfBadSections} sections need repair.");

                }



            } 
            int sumOfPirateShip = pirateShip.Sum();
            int sumOfWarShip = warShip.Sum();
            Console.WriteLine($"Pirate ship status: {sumOfPirateShip}");
            Console.WriteLine($"Warship status: {sumOfWarShip}");


        }

        private static bool IsValid(List<int> ship, int index)
        {
            bool isValidIndex = true;
            if (index < 0 || index >= ship.Count)
            {
                isValidIndex = false;
            }
            return isValidIndex;
        }
    }
}
