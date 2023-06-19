using System;
using System.Linq;

namespace _10._LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOfField = int.Parse(Console.ReadLine());// големина на полето
            int[] initialIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();// къде са калинките в началото [1 0 1]
            string command;// = Console.ReadLine();// как ще се движат (0 дясно 1)
            int[] field = new int[sizeOfField];// начертано празно поле [][][]
            foreach (int i in initialIndexes) // за всеки индекс в празното поле
            { 
                if (i >= 0&& i< field.Length)// ако индекса е валиден
                {
                    field[i] = 1; // поставям калинка - начална позиция
                }
                
            }
            
            while ((command = Console.ReadLine()) != "end") // докато е различна от енд
            {
                string[]commandToArr = command.Split();// разделям командата на части
                //string initialIndexOfCurrBug = commandToArr[0];// начален индекс на калинката
                int initialIndexInt = int.Parse(commandToArr[0]); //начален индекс на калинката парсвам към число
                string direction = commandToArr[1];// посока на движение
                //string flyOfBug = commandToArr[2];// колко полета ще лети
                int flyOfBugInt = int.Parse(commandToArr[2]);//  колко полета ще прелети калинката и парсвам полетата към число

                if (direction == "right")// ако лети надясно
                {
                    flyOfBugInt *= 1; // умножавам с положително число
                }
                else
                {
                    flyOfBugInt *= -1;// ако лети наляво, с отрицателно число
                }
                if (initialIndexInt<0 || initialIndexInt >= field.Length)// ако първоначалния индекс на калинката е извън полето
                {
                    // невалиден идекс на калинката
                   // command = Console.ReadLine();
                    continue;
                }
                if (field[initialIndexInt] == 0)
                {
                    //ако няма калинка на полето -> няма кой да излети
                   // command = Console.ReadLine();
                    continue;
                }
                field[initialIndexInt] = 0;// ако индекса е валиден и има калинка на него - калинката излита и на нейния текущ идекс вече няма нищо.
                int nextIndexOfBug = initialIndexInt + flyOfBugInt;
                while (nextIndexOfBug>=0 && nextIndexOfBug < field.Length && field[nextIndexOfBug]==1)
                        // докато следващия индекс е валиден и е в полето и ако на него има друга калинка....
                {
                     nextIndexOfBug += flyOfBugInt;// калинката продължава да лети по полето, докато намери празно или докато излети от полето
                }
                if (nextIndexOfBug < 0 || nextIndexOfBug >= field.Length)// проверявам  дали е излетяла извън полето
                {
                   // command = Console.ReadLine();// да прочете следваща команда

                    continue;
                }
                else
                {
                    field[nextIndexOfBug] = 1;// ако все още се намира в полето се приземява на новия индекс.
                }






                   // command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(' ', field));// изкарай финалното поле
        }
    }
}
