using System;
using System.Linq;

namespace _5._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0;i< numbers.Length;i++)
            {
                int temp = numbers[i];// временна променлива да ми пази първото число
                bool isBigger = true ; // булева, в момента то е най-голямо
                for (int j = i+1 ;j < numbers.Length;j++)// започвам да сравнявам със следващото число.... до края на масива
                {
                    if(temp> numbers[j])// ако временната е по-голяма
                    {
                        isBigger= true;
                    }else
                    {
                        isBigger= false;
                        break;// !! тук ако не прекъснеш цикъла, може да даде фалшиво положителен резултат
                        
                    }
                    
                    if (temp == numbers[numbers.Length - 1])
                    {
                        if (temp < 0)
                        {
                            isBigger = false;
                        }
                    }
                }
                if (isBigger)
                {
                    Console.Write($"{temp} "); 
                }
            }
        }
    }
}
