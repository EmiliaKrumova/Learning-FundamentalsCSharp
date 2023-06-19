using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._GaussTrick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();// прочитам лист от числа
            List<int> bumbers = new List<int>();// празен лист
            
            if (list.Count % 2 == 0)// ако съдържа четен брой числа
            {
                SumFirstAndLastNum(list, bumbers); // метод който сумира първо + последно; второ + предпоследно.........
            }
            else // ако листа е е нечетен брой числа
            {
                SumFirstAndLastNum(list, bumbers);// метода
                bumbers.Add(list[list.Count / 2]);// добави накрая на новия лист числото, което остава в средата и няма с кое друго да бъде сумирано 1,2, [3], 4, 5 
                
            }
            Console.WriteLine(string.Join(" ", bumbers));
        }

        private static List<int> SumFirstAndLastNum(List<int> list, List<int> bumbers)
        {
            for (int i = 0; i < list.Count / 2; i++) // въртя до дължината делено на 2, защото реално с половината завъртания ще обходя всичките числа - огледално
            {                                                                        //[1 2 3 4 5]
                bumbers.Add(list[i] += list[list.Count - 1 - i]); // към първото прибави последното 1 + 5 , 2 + 4.....

            }
            return bumbers;
        }
    }
}
