namespace WildZoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string command;
            Dictionary<string, Animal> animals = new Dictionary<string, Animal>();
            while((command = Console.ReadLine())!= "EndDay")
            {
                string[] cmdArgs = command.Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string realCmd = cmdArgs[0];
                if (realCmd == "Add")
                {
                    string[] tokens = cmdArgs[1].Split("-", StringSplitOptions.RemoveEmptyEntries);
                    string animalName = tokens[0];
                    int neededFood = int.Parse(tokens[1]);
                    string area = tokens[2];
                    Animal animal = new Animal(animalName, neededFood, area);
                    if (!animals.ContainsKey(animalName))
                    {
                        animals.Add(animalName, animal);
                    }
                    else
                    {
                        animals[animalName].Food += neededFood;
                    }

                }else if(realCmd == "Feed")
                {
                    string[] tokens = cmdArgs[1].Split("-", StringSplitOptions.RemoveEmptyEntries);
                    string animalName = tokens[0];
                    int food = int.Parse(tokens[1]);
                    if (animals.ContainsKey(animalName))
                    {
                        animals[animalName].Food -= food;
                        if (animals[animalName].Food<=0)
                        {
                            Console.WriteLine($"{animalName} was successfully fed");
                            animals.Remove(animalName);
                        }
                    }
                    else
                    {
                        continue;
                    }

                }
            } Console.WriteLine("Animals:");
            foreach(var animal in animals)
            {
                Console.WriteLine($"{animal.Key} -> {animal.Value.Food}g");
                   
            }
            Console.WriteLine("Areas with hungry animals:");
            Dictionary<string,List<string>> areas = new Dictionary<string,List<string>>();
            foreach(var animal in animals)
            {
                if(animal.Value.Food>=0)
                {
                    if (!areas.ContainsKey(animal.Value.Area))
                    {
                        areas[animal.Value.Area] = new List<string>();
                    }
                    //areas.Add(animal.Value.Area,animal.Key.);
                    areas[animal.Value.Area].Add(animal.Key);
                }
            }
            foreach(var area  in areas)
            {
                Console.WriteLine($"{area.Key}: {area.Value.Count}");
            }
        }
    }
    public class Animal
    {
        public Animal(string name, int food, string area)
        {
            Name = name;
            Food = food;
            Area = area;


            
        }
        public string Name { get; set; }
        public int Food { get; set; }
        public string Area { get; set; }

    }
}