using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal neededExperience = decimal.Parse(Console.ReadLine());
            int countOfBattles = int.Parse(Console.ReadLine());
            decimal gainedExperience = 0;
            int counter = 0;
            
            for(int battles = 1; battles <= countOfBattles; battles++)
            {
                decimal experience = decimal.Parse(Console.ReadLine());
                gainedExperience += experience;
                counter++;
                if(battles%3== 0)
                {
                    gainedExperience += experience * 0.15m;
                }else if (battles % 15 == 0)
                {
                    gainedExperience += experience * 0.05m;
                }
                else if(battles%5== 0)
                {
                    gainedExperience -= experience * 0.10m;
                }
                if (gainedExperience >= neededExperience)
                {
                    break;
                    
                }
            }
            if (gainedExperience >= neededExperience)
            {
                Console.WriteLine($"Player successfully collected his needed experience for {counter} battles.");
            }
            else
            {
                decimal diff = neededExperience- gainedExperience;
                Console.WriteLine($"Player was not able to collect the needed experience, {diff:f2} more needed");
            }
        }
    }
}
