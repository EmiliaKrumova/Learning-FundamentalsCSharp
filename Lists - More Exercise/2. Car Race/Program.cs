namespace _2._Car_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            //The time of the left racer is (29 + 13 + 9) * 0.8 (because of the zero) + 13 = 53.8
            //The time of the right racer is (82 + 12 + 14) * 0.8 + 21 = 107.4

            List<int> list = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            double leftTime = 0;
            double rightTime = 0;
            for(int i = 0; i < list.Count/2; i++)
            {
                if (list[i] == 0)
                {
                    leftTime *= 0.8;
                }
                else
                {
                    leftTime += list[i];
                }
                
            }
            //Console.WriteLine(leftTime);
            //29 13 9 0 13 0 21 0 14 82 12 
            for (int i = list.Count-1;i>list.Count/2; i--)
            
            {
                if (list[i] == 0)
                {
                    rightTime *= 0.8;
                }
                else
                {
                    rightTime += list[i];
                }

            }//Console.WriteLine(rightTime);
            if (leftTime > rightTime)
            {
                Console.WriteLine($"The winner is right with total time: {rightTime}");
            }
            else
            {
                Console.WriteLine($"The winner is left with total time: {leftTime}");
            }
        }
    }
}