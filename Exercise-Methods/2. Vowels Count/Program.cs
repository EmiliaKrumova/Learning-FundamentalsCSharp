using System;

namespace _2._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            int countOfVowels = 0;

           Console.WriteLine(CountOfVowelsMetod(input, countOfVowels));

        }

        private static int CountOfVowelsMetod(string input, int countOfVowels)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'o' || input[i] == 'u' || input[i] == 'i')
                {
                    countOfVowels++;
                }
            }

            return countOfVowels;
        }
    }
}
