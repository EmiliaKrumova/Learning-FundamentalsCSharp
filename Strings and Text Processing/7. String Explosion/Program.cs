using System.Text;

namespace _7._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder output = new StringBuilder();
            int bombpower = 0;
            
            for (int i = 0; i < input.Length; i++)
            {
                char currChar = input[i];
                
                if (currChar == '>')
                {
                    int currBombPower = GetValueOfChar(input[i + 1]);
                    output.Append(currChar);
                    bombpower += currBombPower;


                }
                else
                {
                    if (bombpower > 0)
                    {
                        bombpower--;
                    }
                    else
                    {
                        output.Append(currChar);
                    }
                }
                
               
            }
            Console.WriteLine(output.ToString());
        } static int GetValueOfChar (char c)
        {
            
            return (int)c - 48;
        }
    }
}