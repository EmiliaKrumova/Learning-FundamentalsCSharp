using System;

namespace Lab7_Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringToRepeat = Console.ReadLine();
            int timesToRepeat = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatedString(stringToRepeat, timesToRepeat));
            
        }
        private static string RepeatedString (string stringToRepeat, int timesToRepeat)

        {
            string result = string.Empty;
            for (int i = 0; i < timesToRepeat; i++)
            {
                result += stringToRepeat;
            }
           // Console.WriteLine(result);
            return result;
        }
    }
}
