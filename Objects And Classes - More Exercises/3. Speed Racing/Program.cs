using System.Diagnostics.Metrics;
using System.Reflection;

namespace _3._Speed_Racing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = carInfo[0];
                double fuel = double.Parse(carInfo[1]);
                double consumptionPerKM = double.Parse(carInfo[2]);
                Car currCar = new Car(model, fuel, consumptionPerKM );
                cars.Add(currCar);

            }
            string command;
            while((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command.Split(" ");
                string model = cmdArgs[1];
                double travelKM = double.Parse(cmdArgs[2]);
                Car drivenCar = cars.Find(c => c.Model == model);
                if (drivenCar != null)
                {
                    drivenCar.DrivenCar( travelKM);
                }
            }
            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.Fuel:f2} {car.TravelKM}");
            }
        }
    }
    public class Car
    {
        public Car (string model, double fuel, double consumptionPerKM )
        {
            Model = model;
            Fuel = fuel;
            ConsumptionPerKM = consumptionPerKM;
            TravelKM = default;
        }
        public string Model { get; set; }
        public double Fuel { get; set; }
        public double ConsumptionPerKM { get; set; }
        public double TravelKM { get; set; }
            
                
            

        //public bool IsFuelEnough (double fuel, double consumtionPerKM, double TravelKM) { }

        public Car DrivenCar ( double travelKM)
        {
            double neededFuel = travelKM * ConsumptionPerKM;
            if (neededFuel <= Fuel) 
            {
                Fuel -= neededFuel;
                TravelKM += travelKM;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
                
            }
            return  this;
        }
        //public override string ToString()
        //{
        //    return $"{Model} {Fuel:f2} {TravelKM}";//Print the fuel amount rounded to two digitsafter the decimal separator
        //}
    }
//    Define a class Car that keeps a track of a car's model, fuel amount, fuel consumption per kilometer and traveled 
//distance.A Car's model is unique - there will never be 2 cars with the same model
}