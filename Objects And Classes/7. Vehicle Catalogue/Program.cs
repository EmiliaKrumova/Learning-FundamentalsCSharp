using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vehicle; // входни данни с автомобили
            List<Truck> trucks = new List<Truck>();// колекция за камионите
            List<Car> cars = new List<Car>();// колекция за колите
            CatalogV catalog = new CatalogV();// колекция каталог от камиони и коли
            while ((vehicle = Console.ReadLine()) != "end")
            {
                string[] vehicleInfo = vehicle.Split('/');
                //"{type}/{brand}/{model}/{horse power / weight}"
                string typeOfVehicle = vehicleInfo[0];// всеки автомобил има  - вид (кола или камион)
                string brandOfVehicle = vehicleInfo[1];// марка
                string modelOfVehicle = vehicleInfo[2];// модел
                int hpOrWeight =int.Parse( vehicleInfo[3]);// ако е кола е конски сили, ако е камион - тегло

                if (typeOfVehicle == "Car")
                {
                    Car car = new Car(brandOfVehicle, modelOfVehicle, hpOrWeight);// създавам обект кола в класа коли
                    catalog.Cars.Add(car);// !!!!!!!!! ОБЪРНИ ВНИМАНИЕ директно в листа каталог, записвам в листа коли, текущата кола с всички параметри
                }else if (typeOfVehicle == "Truck")
                {
                    Truck truck = new Truck(brandOfVehicle, modelOfVehicle, hpOrWeight);
                    catalog.Truck.Add(truck);// викам от каталога, листа с камионите и добавям текущия камион
                }

            }
            if (catalog.Cars.Count > 0)// ако броя на колите в каталога е над 0
            {
                Console.WriteLine("Cars:");
            }
            foreach(Car car in catalog.Cars.OrderBy(x=>x.Brand))// сортиране по азбучен ред, според критерий - МАРКА на колата
            {
                
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");

            }
            if (catalog.Truck.Count>0)
            {
                Console.WriteLine("Trucks:");
            }
            foreach(Truck truck in catalog.Truck.OrderBy(x=>x.Brand))
            {
                
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }
    public class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
    public class Car
    {
        public Car(string brand, string model, int hp)
        {
            Brand = brand;
            Model = model;
            HorsePower = hp;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower
        {
            get; set;
        }
    }
    public class CatalogV
    {
        public CatalogV()// за да добавиш в каталога - задължително трябва да подадеш масив от коли и масив от камиони
        {
            Cars = new List<Car>();
            Truck = new List<Truck>();// обърни внимание на синтаксиса и скобите накрая!!!
        }

        public List<Car> Cars { get; set; }// пропъртитата на каталога са листи( от коли и камиони)
        public List<Truck> Truck { get; set; }
    }
}
//Define a class Truck with the following properties: Brand, Model, and Weight.
//Define a class Car with the following properties: Brand, Model, and Horse Power.
//Define a class Catalog with the following properties: Collections of Trucks and Cars
