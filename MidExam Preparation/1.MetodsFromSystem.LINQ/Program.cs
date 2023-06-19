using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _1.MetodsFromSystem.LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4 };


            numbers.Sum();// sum all elements in list 1+2+3+4
            Console.WriteLine(numbers.Sum());


            numbers.Min();// get the smallest number from colection
            Console.WriteLine(numbers.Min());


            numbers.Max();// get the bigest number from colection
            Console.WriteLine(numbers.Max());



            numbers.Average();// gets the average value from colection
            Console.WriteLine(numbers.Average());

            numbers.Skip(2);// skip (2) elements from colection
            Console.WriteLine(string.Join(" ",numbers.Skip(2)));

            numbers.Take(2);// takes first (2) elements from colection
            Console.WriteLine(string.Join(",", numbers.Take(2)));

            numbers.OrderBy(x => x);// or numbers.Sort// orders elements ascending order
            Console.WriteLine(string.Join(",", numbers.OrderBy(x => x)));

            numbers.OrderByDescending(x => x);// sorts elements descending order
            Console.WriteLine(string.Join(",", numbers.OrderByDescending(x => x)));

            numbers.Where(x => x > 0);// find all number bigger than 0
            Console.WriteLine(string.Join(" ", numbers.Where(x => x > 0)));
            numbers.Where(x => x % 2==0); // find all even numbers in colection
            Console.WriteLine(string.Join(" ", numbers.Where(x => x %2== 0)));

            // where = там, където.....(условието)
            
            //BOOL METHODS

            numbers.All(x => x > 0);// if all numbers are bigger than 0.

            // This is a boolean Method - returns true or false

            numbers.All(x => x % 2 == 0);// if all numbers are even
            Console.WriteLine(string.Join(" ", numbers.All(x => x % 2 == 0)));




            numbers.Any(x => x > 0);// if at least 1 number is bigger than zero


            // returns TRUE OR FALSE
            numbers.Any(x=>x<0);
            Console.WriteLine(string.Join(" ", numbers.Any(x=>x>3)));



            numbers.Select(x=> x+2);
            Console.WriteLine(string.Join(" ", numbers.Select(x => x + 2)));



            //GENERATE RANDOM NUMBERS
            int[] nums = new int[10]; 
            for(int i  = 0; i < nums.Length;i++)
            {
                nums[i] = new Random().Next(1, 101);// тук слагам интервал, в който да бъдат числата с последното невключително
            }
           
            
            Console.WriteLine(string.Join(" ", nums));


        }
    }
}
