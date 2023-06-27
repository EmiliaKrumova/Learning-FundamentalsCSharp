using System.Diagnostics;

namespace _4._Raw_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // получавам данни за кола 
            //: "<Model> <EngineSpeed> <EnginePower> <CargoWeight> < CargoType > "
            int number = int.Parse(Console.ReadLine());// брой коли
            List<Car> cars = new List<Car>();// списък с колите
            for (int i = 0; i < number; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = carInfo[0];
                int engineSpeed = int.Parse(carInfo[1]);
                int enginePower = int.Parse(carInfo[2]);
                int weight = int.Parse(carInfo[3]);
                string cargoType = carInfo[4];
                Engine engine = new Engine(engineSpeed, enginePower);// създавам обект -  двигател
                Cargo cargo = new Cargo(weight, cargoType);// създавам обект - карго
                Car car = new Car(model,engine,cargo);// създавам обект - кола с пропъртита (модел, обект двигател и обект карго)
                cars.Add(car);// добавям колата в списъка с колите

                
            }
            string command = Console.ReadLine();

            if (command == "fragile")
            {
                //!!! .Where  - ми връща списък с коли, веднъж го ползвам да сравни вида на колата и после втори път за теглото
                cars
                    .Where(c => c.CarCargo.CargoType == command)
                    .Where(c => c.CarCargo.Weight < 1000)
                    .ToList()// задължително да станат на списък
                    .ForEach(c => Console.WriteLine(c.Model));// за всяка от намерените коли, които отговарят на условията - отпечатвам модела й
                
                

            }
            else if (command == "flamable")
            {
                cars
                    .Where(x => x.CarCargo.CargoType == command)
                    .Where(x => x.CarEngine.EnginePower > 250)
                    .ToList()
                    .ForEach(x => Console.WriteLine(x.Model));
                

            }
        }
        
    }
    public class Car
    {
        public Car(string model, Engine engine, Cargo cargo)
        {
            Model = model;
            CarEngine = engine;
            CarCargo = cargo;
        }
        public string Model { get; set; }
        public Engine CarEngine { get; set; }
        public Cargo CarCargo { get; set; }
    }
    public class Engine
    {
        public Engine(int engineSpeed, int enginePower)
        {
            EngineSpeed = engineSpeed;
            EnginePower = enginePower;
        }
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }
    }
    public class Cargo
    {
        public Cargo (int weight, string cargoType)
        {
            Weight = weight;
            CargoType = cargoType;
        }
        public int Weight { get; set; }
        public string CargoType { get; set; }
    }
}