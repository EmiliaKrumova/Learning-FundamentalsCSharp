using System;

namespace Problem_1___SoftUni_Reception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int empl1 = int.Parse(Console.ReadLine());
            int empl2 = int.Parse(Console.ReadLine());
            int empl3 = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int hours = 0;


            while (students > 0)
            {

                hours++;
                if (hours % 4 == 0)
                {

                    continue;
                }
                else
                {
                    students -= empl1 + empl2 + empl3;
                }

            }

            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
