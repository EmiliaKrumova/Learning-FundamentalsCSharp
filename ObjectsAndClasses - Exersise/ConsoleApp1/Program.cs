using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Vehicle_Catalogue
{
    //"{typeOfVehicle} {model} {color} {horsepower}"

    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            int sumOfCarsHP = 0;
             int sumOfTruckHP = 0;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] vehicleArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string type = vehicleArgs[0];
                string model = vehicleArgs[1];
                string color = vehicleArgs[2];
                int horsePower = int.Parse(vehicleArgs[3]);
                if (type == "car")
                {
                     sumOfCarsHP += horsePower;
                    Car currCar = new Car(model, color, horsePower);
                    cars.Add(currCar);
                }
                else if (type == "truck")
                {
                     sumOfTruckHP += horsePower;
                    Truck currTruck = new Truck(model, color, horsePower);
                    trucks.Add(currTruck);
                }
            }
            string secondCommand;
            while ((secondCommand = Console.ReadLine()) != "Close the Catalogue")
            {

                if (trucks.Any(t => t.Model == secondCommand))
                {
                    Truck truckToPrint = trucks.First(t => t.Model == secondCommand);
                    Console.WriteLine("Type: Truck");
                    Console.WriteLine($"Model: {truckToPrint.Model}");
                    Console.WriteLine($"Color: {truckToPrint.Color}");
                    Console.WriteLine($"Horsepower: {truckToPrint.HorsePower}");
                }
                else if (cars.Any(c => c.Model == secondCommand))
                {
                    Car carToPrint = cars.First(c => c.Model == secondCommand);
                    Console.WriteLine("Type: Car");
                    Console.WriteLine($"Model: {carToPrint.Model}");
                    Console.WriteLine($"Color: {carToPrint.Color}");
                    Console.WriteLine($"Horsepower: {carToPrint.HorsePower}");
                }


            }
            //double avrTrucksHp = 0;
            if (cars.Count > 0)
            {
                double avrCarsHP =(double) sumOfCarsHP / cars.Count;
                Console.WriteLine($"Cars have average horsepower of: {avrCarsHP:f2}.");
            }
            if (trucks.Count > 0)
            {
                double avrTrucksHp = (double)sumOfTruckHP / trucks.Count;
                Console.WriteLine($"Trucks have average horsepower of: {avrTrucksHp:f2}.");
            }

            //double avrTrucksHp = trucks.Any() ? trucks.Average(t => t.HorsePower) : 0;
            //double avrCarsHP = cars.Any() ? cars.Average(c => c.HorsePower) : 0;
            //Console.WriteLine($"Cars have average horsepower of: {avrCarsHP:f2}.");
            //Console.WriteLine($"Trucks have average horsepower of: {avrTrucksHp:f2}.");
        }

    }
    public class Car
    {
        public Car(string model, string color, int horsePower)
        {
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }


    }
    public class Truck
    {
        public Truck(string model, string color, int horsePower)
        {
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }



    }
}

