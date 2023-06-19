using System;

namespace _2._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int lines = int.Parse(Console.ReadLine());
            int[]triangle= new int[lines];// масив с дължина линиите на триъгълника
            for (int rows = 0; rows < lines; rows++)  //първо въртя докато редовете са равни на броя на линиите

            {
                int curentNum = 1;// върха на триъгълника е винаги 1
               // triangle[lines-1] = 1;
                for(int col = 0; col<=rows; col++)// въртя по колоните, докато са равни на редовете +1
                {
                    Console.Write($"{curentNum} "); // когато индекс колона е по-малък или равен на индекс ред... ( на ред 2 има 2 колони; на ред 3 има 3 колони)....
                  curentNum = curentNum * (rows - col) / (col + 1);// числото се смята по тази формула???
                }
                Console.WriteLine();
            }
        }
    }
}
