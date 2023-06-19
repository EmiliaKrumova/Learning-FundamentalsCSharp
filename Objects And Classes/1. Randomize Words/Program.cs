using System;

namespace _1._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            Random random1 = new Random();
            for(int i  = 0; i < input.Length; i++)
            {
                string word = input[i];
               int randomNumber = random1.Next(0,input.Length);
                string randomword = input[randomNumber];
                input[i] = randomword;
                input[randomNumber] = word;

                
            }
            Console.WriteLine(string.Join(Environment.NewLine, input));
        }
    }
}
