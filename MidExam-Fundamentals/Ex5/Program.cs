namespace Hunting_Games_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int numberOfPlayers = int.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double water = double.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());

            double remainingWater = water * numberOfPlayers * days;
            double remainingFood = food * numberOfPlayers * days;

            for (int i = 1; i <= days; i++)
            {
                double energyConsumption = double.Parse(Console.ReadLine());
                

                if (i % 2 == 0)
                {
                    energy -= energyConsumption;
                    energy += energy * 0.05;
                    remainingWater -= remainingWater * 0.3;
                }
                else if (i % 3 == 0)
                {
                    energy -= energyConsumption;
                    remainingFood -= remainingFood / numberOfPlayers;
                    energy *= 1.1;
                }
                else
                {
                    energy -= energyConsumption;
                }

                if (energy <= 0)
                {
                    break;
                }


            }

            if (energy >= 0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {energy:F2} energy!");
            }
            else
            {
                Console.WriteLine($"You will run out of energy. You will be left with {remainingFood:F2} food and {remainingWater:F2} water.");
            }

        }

    }
}

