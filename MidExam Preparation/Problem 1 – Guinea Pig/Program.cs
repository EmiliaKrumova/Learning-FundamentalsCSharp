using System;

namespace Problem_1___Guinea_Pig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal food = decimal.Parse(Console.ReadLine());
            decimal hay = decimal.Parse(Console.ReadLine());
            decimal cover = decimal.Parse(Console.ReadLine());
            decimal weightOfPig = decimal.Parse(Console.ReadLine());
            int day = 0;
            while(food > 0&& hay>0 && cover>0 && day<30)
            {
                for (int i = 1; i <= 30; i++)
                {
                    day = i;
                    food -= 0.3m;
                    if(food < 0) 
                    {
                       
                        break;
                    }
                    if (i % 2 == 0)
                    {
                        hay -= food * 0.05m;
                    }
                    if(hay < 0)
                    {
                        
                        break;
                    }
                    if (i % 3 == 0)
                    {
                        cover -= weightOfPig / 3.0m;
                    }
                    if(cover < 0)
                    {
                        
                        break;
                    }
                }


            }
            if((food > 0 && hay > 0 && cover > 0))
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {food:f2}, Hay: {hay:f2}, Cover: {cover:f2}.");
            }
            else
            {
                Console.WriteLine("Merry must go to the pet store!");
            }
            

        }
    }
}
