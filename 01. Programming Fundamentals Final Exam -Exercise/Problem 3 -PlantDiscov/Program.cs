namespace Problem_3__PlantDiscov
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Dictionary<string, double> plants = new Dictionary<string, double>();
            Dictionary<string,List<double>> rating = new Dictionary<string,List<double>>();
            for(int i = 0; i < n; i++)
            {
                string []plantInfo = Console.ReadLine().Split("<->",StringSplitOptions.RemoveEmptyEntries);
                string plantName = plantInfo[0];
                double rarity = double.Parse(plantInfo[1]);
                if(!plants.ContainsKey(plantName))
                {
                    plants[plantName] = 0;
                    rating.Add(plantName,new List<double>());
              
                }
                plants[plantName] = rarity;
            }
            string command;
            while((command = Console.ReadLine()) != "Exhibition")
            {
                string[] comArgs = command.Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string realCmd = comArgs[0];
                string[] tokens = comArgs[1].Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string plantName = tokens[0];

                if (!plants.ContainsKey(plantName.Trim()))
                {
                    Console.WriteLine("error");
                    continue;
                }
                Operations(plants, rating, realCmd, tokens, plantName);
            }
            Console.WriteLine("Plants for the exhibition:");
            foreach (var plant in plants)
            {
                string key = plant.Key;
                double rarity = plant.Value;

                double averageRate = rating[key].Count>0 ? rating[key].Average() : 0;

                Console.WriteLine($"- {key}; Rarity: {rarity}; Rating: {averageRate:f2}");              
          
            }
        }

        private static void Operations(Dictionary<string, double> plants, Dictionary<string, List<double>> rating, string realCmd, string[] tokens, string plantName)
        {
            if (realCmd == "Rate")
            {
                double rate = double.Parse(tokens[1]);
                rating[plantName].Add(rate);
            }
            else if (realCmd == "Update")
            {
                double newRarity = double.Parse(tokens[1]);
                plants[plantName] = newRarity;
            }
            else if (realCmd == "Reset")
            {
                if (rating.ContainsKey(plantName))
                {
                    rating[plantName].Clear();
                }
            }
        }
    }
}