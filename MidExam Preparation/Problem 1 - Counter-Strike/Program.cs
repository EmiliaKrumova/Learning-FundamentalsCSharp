using System;

namespace Problem_1___Counter_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            string command;
            int counterOfEnemies = 0;
            while((command =  Console.ReadLine()) != "End of battle")
            {
                int distance = int.Parse(command);
                if(energy<distance)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {counterOfEnemies} won battles and {energy} energy");
                    return; ;
                }
                energy-= distance;
                counterOfEnemies++;
                if (counterOfEnemies%3==0)
                {
                    energy += counterOfEnemies;
                }

            }
            Console.WriteLine($"Won battles: {counterOfEnemies}. Energy left: {energy}");
        }
    }
}
