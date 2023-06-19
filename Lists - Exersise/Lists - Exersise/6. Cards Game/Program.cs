using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> player1Cards = Console.ReadLine() // карти на първия играч
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)// карти на втория играч
                .Select(int.Parse)
                .ToList();
            List<int> player2Cards = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            
            while(player1Cards.Count != 0 && player2Cards.Count != 0)// докато и двамата имат поне по 1 карта
            {
                int currCardPlayer1 = player1Cards[0];// текущата карта от тестето на първия
                int currCardPlayer2 = player2Cards[0];// текущата карта от тестето на втория


                if (currCardPlayer1 > currCardPlayer2)// ако картата на първия > картата на втория
                {
                    player1Cards.Add(currCardPlayer2);// към тестето на първия добави картата на втория накрая
                    player1Cards.Add (currCardPlayer1);// след нея добави и неговата си "печеливша" карта
                    


                }else if (currCardPlayer1 < currCardPlayer2)
                {
                    player2Cards.Add(currCardPlayer1);
                    player2Cards.Add(currCardPlayer2);
                    
                }
                player1Cards.RemoveAt(0);// премахни от нулевия индекс картите, които вече са разиграни
                player2Cards.RemoveAt(0);
               
            }
            int sum1 = player1Cards.Sum();// сумирай картите на първия
            int sum2 = player2Cards.Sum();// на втория
            if (player1Cards.Count <= 0)// ако първия е останал без карти ->
            {
                Console.WriteLine($"Second player wins! Sum: {sum2}");// втория печели
            }
            else
            {
                Console.WriteLine($"First player wins! Sum: {sum1}");
            }


           
        }
    }
}
