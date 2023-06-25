using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            List<People> people = new List<People>();
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = cmdArgs[0];
                string id = cmdArgs[1];
                int age = int.Parse(cmdArgs[2]);

                if(people.Any(p =>p.Id == id))
                {
                    //Truck truckToPrint = trucks.First(t => t.Model == secondCommand);
                    People humanToChange = people.First(p => p.Id == id);
                    humanToChange.Age = age;
                    humanToChange.Name = name;
                }
                
                People human = new People(name, id,age);
                people.Add(human);
            }
            List<People> orderedByAge = people.OrderBy(p => p.Age).ToList();
            foreach(People human in orderedByAge)
            {
                Console.WriteLine(human.ToString());
            }
        }
    }

    public class People
    {
        public People(string name, string id, int age)
        {
            Name = name; 
            Id = id;
            Age = age;
            
        }
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {Id} is {Age} years old.";
        }
    }
}
