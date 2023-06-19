using System;

namespace _1._Smallest_of_Three_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 3;
            int smalestNum = int.MaxValue;
            smalestNum = SmalestNumFounded(count, smalestNum);
            Console.WriteLine(smalestNum);
        }

        private static int SmalestNumFounded(int count, int smalestNum)
        {
            for (int i = 0; i < count;i++)
            {
                int currNum = int.Parse(Console.ReadLine());
                if (currNum < smalestNum)
                {
                    smalestNum = currNum;
                }
            }

            return smalestNum;
        }
    }
}
