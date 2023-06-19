using System;
using System.Dynamic;

namespace _03.IntFloatDoubleDecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
                  30
                  Students
                  Sunday
 
                  40
                  Regular
                  Saturday
            */
            int peopleCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            decimal totalMoney = 0;
            //KOGATO: float;  double;  decimal; 
            decimal pricePerPerson = 0;

            switch (groupType)
            {
                case "Students":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            pricePerPerson = 8.45m;
                            //TOGAVA: f;  d ili nishto; m
                            break;
                        case "Saturday":
                            pricePerPerson = 9.80m;
                            break;
                        case "Sunday":
                            pricePerPerson = 10.46m;
                            break;
                    }

                    totalMoney = peopleCount * pricePerPerson;

                    if (peopleCount >= 30)
                    {
                        totalMoney -= (totalMoney * 15) / 100;
                    }
                    break;


                case "Business":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            pricePerPerson = 10.90m;
                            break;
                        case "Saturday":
                            pricePerPerson = 15.60m;
                            break;
                        case "Sunday":
                            pricePerPerson = 16m;
                            break;
                    }

                    if (peopleCount >= 100)
                    {
                        peopleCount -= 10;
                    }

                    totalMoney = peopleCount * pricePerPerson;

                    break;
                case "Regular":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            pricePerPerson = 15m;
                            break;
                        case "Saturday":
                            pricePerPerson = 20m;
                            break;
                        case "Sunday":
                            pricePerPerson = 22.50m;
                            break;
                    }

                    totalMoney = peopleCount * pricePerPerson;
                    if (peopleCount >= 10 && peopleCount <= 20)
                    {
                        totalMoney -= totalMoney * 5 / 100;
                    }

                    break;
            }

            Console.WriteLine($"Total price: {totalMoney:F2}");
        }
    }
}