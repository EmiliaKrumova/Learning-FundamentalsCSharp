using System;

namespace Problem_1___Bonus_Scoring_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int lectures = int.Parse(Console.ReadLine());
            int addBonus = int.Parse(Console.ReadLine());
            decimal totalBonus = 0m;
            decimal maxBonus = 0m;
            decimal finalAttendances = 0;

            for(int student =1;student<=students;student++) 
            { 
              decimal attendances = decimal.Parse(Console.ReadLine());
                totalBonus = attendances / lectures * (5 + addBonus);
                if(totalBonus > maxBonus)
                {
                    maxBonus = totalBonus;
                    finalAttendances=attendances;
                }

            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {finalAttendances} lectures.");


        }
    }
}
