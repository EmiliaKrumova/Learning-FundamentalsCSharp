namespace Problem_3___Need_for_Speed_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n  = int.Parse(Console.ReadLine());
            Dictionary<string,Car> cars = new Dictionary<string,Car>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] carInfo = input.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string brand = carInfo[0];
                double km = double.Parse(carInfo[1]);
                double fuel = double.Parse(carInfo[2]);
                Car car  = new Car(brand, km, fuel);
                cars.Add(brand, car);

            }
            string command;
            while((command = Console.ReadLine()) != "Stop")
            {
                string[] comArgs = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string realCom = comArgs[0];
                string brand = comArgs[1];
                if (realCom == "Drive")
                {
                    double distance = double.Parse(comArgs[2]);
                    double fuel = double.Parse(comArgs[3]);
                    if (cars[brand].Fuel < fuel)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        cars[brand].Fuel -= fuel;
                        cars[brand].KM += distance;
                        Console.WriteLine($"{brand} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                        if (cars[brand].KM >= 100000)
                        {
                            Console.WriteLine($"Time to sell the {brand}!");
                            cars.Remove(brand);
                        }
                        
                    }

                }else if(realCom == "Refuel")
                {
                    double fuel = double.Parse(comArgs[2]);
                    double oldFuelQnty = cars[brand].Fuel;
                    cars[brand].Fuel += fuel;
                    if (cars[brand].Fuel > 75)
                    {
                        cars[brand].Fuel = 75;
                    }
                    double actualLoadedFuel = cars[brand].Fuel-oldFuelQnty;//?????
                    Console.WriteLine($"{brand} refueled with {actualLoadedFuel} liters");

                }else if (realCom == "Revert")
                {
                    double kilometres = double.Parse(comArgs[2]);
                    
                    cars[brand].KM-=kilometres;
                    if (cars[brand].KM <= 10000)
                    {
                        cars[brand].KM = 10000;
                        continue;
                    }
                    Console.WriteLine($"{brand} mileage decreased by {kilometres} kilometers");

                }
               
            } foreach(var kvp in cars)
            {
                Console.WriteLine($"{kvp.Key} -> Mileage: {kvp.Value.KM} kms, Fuel in the tank: {kvp.Value.Fuel} lt.");

            }
        }
    } 
    public class Car
    {
        public Car(string brand, double km, double fuel)
        {
            Brand = brand;
            KM = km;

            Fuel = fuel;
        }
        public string Brand { get; set; }
        public double KM { get; set; }
        public double Fuel { get; set; }

    }
}