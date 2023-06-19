using System;
using System.Linq;

namespace Arrays_Lab4._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string items = Console.ReadLine(); // прочитам ред с елементи от конзолата
            string[]array= items.Split().ToArray(); // правя нов масив, като разделям елементите със Split(по интервал) ToArray - пълня масива
            for(int i = array.Length-1; i>=0; i--) //обратен цикъл започващ от последния елемент
            {
                Console.Write($"{array[i]} ");// печат на всеки елемент в обратен ред
            }
        }
    }
}
