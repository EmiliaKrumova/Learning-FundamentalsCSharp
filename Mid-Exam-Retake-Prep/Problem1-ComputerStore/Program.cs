using System;

namespace Problem1_ComputerStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double finalPriceWithoutTax = 0;
            double taxes = 0;
            while (command!="special" && command!= "regular")
            {
                double pricePerCurrentpart = double.Parse(command);
                
                if (pricePerCurrentpart < 0)
                {
                    Console.WriteLine("Invalid price!");
                    command= Console.ReadLine();
                    continue;
                }
                finalPriceWithoutTax+= pricePerCurrentpart;
                taxes += pricePerCurrentpart * 0.2;
                command = Console.ReadLine();
            }
            if (finalPriceWithoutTax==0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }
            double finalPrice = finalPriceWithoutTax * 1.2;
            if (command == "special")
            {
                finalPrice *= 0.9;
            }
            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {finalPriceWithoutTax:f2}$");
            Console.WriteLine($"Taxes: {taxes:f2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {finalPrice:f2}$");
        }
    }
}
