using System;

namespace Add_Ex_5DecryptingMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte key = byte.Parse(Console.ReadLine()); 
            byte numberOfChars = byte.Parse(Console.ReadLine());
            string decriptedMessage = String.Empty;
            for (int i = 0;i< numberOfChars;i++)
            {
                char currentChar = char.Parse(Console.ReadLine());
                int currentCharToInt = (int)currentChar;
                int realChar = currentCharToInt + key;
                decriptedMessage += (char)realChar;
                
            }
            Console.WriteLine(decriptedMessage);
        } 
    }
}
