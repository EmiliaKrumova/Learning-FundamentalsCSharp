using System.Diagnostics;

namespace _2._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            string wordToPrint = string.Empty;

            foreach (string word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    wordToPrint += word;
                }
            }
            Console.WriteLine(wordToPrint);
            
        }
    }
}