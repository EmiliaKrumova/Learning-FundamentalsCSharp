using System;
using System.Linq;

namespace Problem_2___The_Lift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleWaitToLift = int.Parse(Console.ReadLine());
            int[] lift = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for(int i = 0;i<lift.Length;i++)
            {
                
                while(lift[i] < 4 && peopleWaitToLift>0)
                {
                    lift[i]++;
                    peopleWaitToLift--;
                    
                   
                    
                }
               

            }
            if (peopleWaitToLift==0 && lift.Any(x => x < 4))
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", lift));
            }else if (peopleWaitToLift > 0)
            {
                Console.WriteLine($"There isn't enough space! {peopleWaitToLift} people in a queue!");
                Console.WriteLine(string.Join(" ", lift));
            }
            else
            {
                Console.WriteLine(string.Join(" ", lift));
            }

        }
    }
}
