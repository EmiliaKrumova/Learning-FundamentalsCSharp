using System;
using System.Linq;

namespace Arrays_Lab3._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string arrayNumbersInString = Console.ReadLine();// получавам произволни числа, разделени с интервал
            string[] splitNumbers = arrayNumbersInString.Split(" ",StringSplitOptions.RemoveEmptyEntries); 
            // правя си стринг масив, в който разделям  (Split)  числата по () --> интервала
            // допълнително с метода StringSplitOptions.RemoveEmptyEntries - проверявам дали е възможно да има повече от един интервал " , "
           double[]arrayNumbers = splitNumbers.Select(double.Parse).ToArray(); 
            // селектирам и парсвам към double и едновременно ги слагам в масив от тип double
            for(int i = 0;i< arrayNumbers.Length;i++)
            {
                //if (arrayNumbers[i] == -0)
                //{
                //    Console.WriteLine($"{arrayNumbers[i]} => 0");
                //    break;
                //}
                Console.WriteLine($"{arrayNumbers[i]} => {(int)(Math.Round(arrayNumbers[i],MidpointRounding.AwayFromZero))}");

                // MidpointRounding.AwayFromZero е метод, който се използва с Math.Round за закръгляне на числата например 3,5 в посока обратна на нулата по абсцисата. 3,5 = 4;
                //                                 -3,5 = -4
                // !!! кастнах към int в резултата, поради проблем че с инпут -0 изкарваше резултат -0
            }
            
            
        }
    }
}
