using System;
using System.Diagnostics;

namespace Problem_1___Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double totalPrice = 0;
            double totalWithTaxes = 0;
            while (command!="regular"&& command!= "special")
            {
                double price = double.Parse(command);
                
                if(price < 0)
                {
                    Console.WriteLine("Invalid price!");
                    command = Console.ReadLine();
                    continue;
                }
                totalPrice += price;
                double priceWithTax = price * 1.2;
                totalWithTaxes += priceWithTax;




                command = Console.ReadLine();
            }
            double taxes = totalWithTaxes - totalPrice;
            if (command == "special")
            {
                totalWithTaxes *= 0.9;
            }
            if (totalWithTaxes == 0)
            {
                Console.WriteLine("Invalid order!");

            }
            else
            {   
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPrice:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalWithTaxes:f2}$");
            }
        }
    }
}
