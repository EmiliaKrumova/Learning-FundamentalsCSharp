using System;
using System.Net.Http.Headers;

namespace Lab5_Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            CalcilationOfOrder(product, quantity);
            
        static void CalcilationOfOrder( string product, int quantity)
        {
                double price = 0;
                switch (product)
                {
                    case "coffee":
                        price = 1.50;
                        break;
                    case "water":
                        price = 1.00;
                        break;
                    case "coke":
                        price = 1.40;
                        break;
                    case "snacks":
                        price = 2.00;
                        break;
                }
                double result = price* quantity;
                Console.WriteLine($"{result:f2}");
            }
        }
    }
}
