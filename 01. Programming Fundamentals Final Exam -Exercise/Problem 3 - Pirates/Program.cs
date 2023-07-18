namespace Problem_3___Pirates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            Dictionary<string, double[]> info = new Dictionary<string, double[]>();
            while ((command = Console.ReadLine()) != "Sail")
            {
                FillTheMapOfCities(command, info);
            }
            string comand2;
            comand2 = StealOrProsperMethod(info);
            PrintOutputMethod(info);
        }

        private static string StealOrProsperMethod(Dictionary<string, double[]> info)
        {
            string comand2;
            while ((comand2 = Console.ReadLine()) != "End")
            {
                string[] comArgs = comand2.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string realCom = comArgs[0];
                string town = comArgs[1];

                if (realCom == "Plunder")
                {
                    PlunderMethod(info, comArgs, town);

                }
                else if (realCom == "Prosper")
                {
                    double gold = double.Parse(comArgs[2]);

                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        continue;
                    }
                    info[town][1] += gold;
                    double totalGold = info[town][1];
                    Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {totalGold} gold.");

                }
            }

            return comand2;
        }

        private static void PrintOutputMethod(Dictionary<string, double[]> info)
        {
            if (info.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {info.Count} wealthy settlements to go to:");
                foreach (var item in info)
                {
                    Console.WriteLine($"{item.Key} -> Population: {item.Value[0]} citizens, Gold: {item.Value[1]} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }

        private static void PlunderMethod(Dictionary<string, double[]> info, string[] comArgs, string town)
        {
            double people = double.Parse(comArgs[2]);
            double gold = double.Parse(comArgs[3]);
            info[town][0] -= people;
            info[town][1] -= gold;
            Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
            if (info[town][0] <= 0 || info[town][1] <= 0)
            {
                Console.WriteLine($"{town} has been wiped off the map!");
                info.Remove(town);
            }
        }

        private static void FillTheMapOfCities(string command, Dictionary<string, double[]> info)
        {
            string[] comArgs = command.Split("||", StringSplitOptions.RemoveEmptyEntries);
            string city = comArgs[0];
            double people = double.Parse(comArgs[1]);
            double gold = double.Parse(comArgs[2]);
            if (!info.ContainsKey(city))
            {
                info[city] = new double[2];
                info[city][0] = people;
                info[city][1] = gold;
            }
            else
            {
                info[city][0] += people;
                info[city][1] += gold;
            }
        }
    }
}