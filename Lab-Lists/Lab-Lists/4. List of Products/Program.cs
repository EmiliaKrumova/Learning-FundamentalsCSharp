using System;
using System.Collections.Generic;

namespace _4._List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfProducts = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();
            for(int i = 0; i < countOfProducts; i++)
            {
                string product = Console.ReadLine();
                products.Add(product);
            }
            products.Sort();

            for(int i = 0; i < products.Count; i++)
            {
                Console.Write($"{i+1}.{products[i]}");
                Console.WriteLine();
            }
            
            //Console.WriteLine(string.Join(", ", products));
        }
    }
}
