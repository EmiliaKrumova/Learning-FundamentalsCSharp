using System;

namespace Add_Ex_6BalancedBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte countOfLinesInput = byte.Parse(Console.ReadLine());
            bool isBalanced = false;
            int countOfOpenedBrackets = 0;
            int countOfClosedBrackets = 0;
          
            for (byte i = 0; i < countOfLinesInput; i++)
            {
                string currentLine = Console.ReadLine();               

                if (currentLine == "(")
                {
                    countOfOpenedBrackets++;                    
                }
                else if (currentLine == ")")
                {
                    countOfClosedBrackets++;
                    if (countOfClosedBrackets-countOfOpenedBrackets!=0)
                    {
                        Console.WriteLine("UNBALANCED");// Това е много важна проверка!!!
                        return;
                    }                    
                }               
            }
            if (countOfClosedBrackets == countOfOpenedBrackets && countOfOpenedBrackets > 0)
            {
                isBalanced = true;
            }
            if (isBalanced)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
