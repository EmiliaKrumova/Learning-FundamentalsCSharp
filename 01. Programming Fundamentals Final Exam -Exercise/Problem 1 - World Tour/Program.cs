namespace Problem_1___World_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destinations = Console.ReadLine();
            string command;
            while ((command = Console.ReadLine()) != "Travel")
            {
                string[] commandArgs = command.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string realCom = commandArgs[0];
                if(realCom == "Add Stop")
                {
                    destinations = AddStopToString(destinations, commandArgs);
                }
                else if(realCom == "Remove Stop")
                {
                    destinations = RemoveStop(destinations, commandArgs);
                }
                else if(realCom== "Switch")
                {
                    destinations = Replace(destinations, commandArgs);

                }
            } Console.WriteLine($"Ready for world tour! Planned stops: {destinations}");
        }

        private static string Replace(string destinations, string[] commandArgs)
        {
            string old = commandArgs[1];
            string newString = commandArgs[2];
            destinations.Where(x => x.Equals(old));
            {
                destinations = destinations.Replace(old, newString);
            }


            //while(destinations.Contains(old))
            //{
            //    destinations = destinations.Replace(old, newString);
            //}
            // И ТОВА РЕШЕНИЕ Е ВЯРНО, НО НЕ Е ОПТИМАЛНО КАТО ВРЕМЕ!!! 83/100 Test #6 (Time limit)


            Console.WriteLine(destinations);
            return destinations;
        }

        private static string RemoveStop(string destinations, string[] commandArgs)
        {
            int firstIndex = int.Parse(commandArgs[1]);
            int secondIndex = int.Parse(commandArgs[2]);
            if (IsValidIndex(destinations, firstIndex) && IsValidIndex(destinations, secondIndex))
            {
                destinations = destinations.Remove(firstIndex, secondIndex - firstIndex + 1);
            }
            Console.WriteLine(destinations);
            return destinations;
        }

        private static string AddStopToString(string destinations, string[] commandArgs)
        {
            int index = int.Parse(commandArgs[1]);
            string newDestination = commandArgs[2];
            if (IsValidIndex(destinations, index))
            {
                destinations = destinations.Insert(index, newDestination);
            }
            Console.WriteLine(destinations);
            return destinations;
        }

        private static bool IsValidIndex(string destinations, int index)
        {
            bool IsValid = false;
            if (index >= 0 && index < destinations.Length)
            {
                IsValid = true;

            }
            return IsValid;
        }
    }
}