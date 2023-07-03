namespace _2._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            Dictionary<string, int> resourses = new Dictionary<string, int>();
            while ((command = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (!resourses.ContainsKey(command))
                {
                    resourses[command] = 0;
                }
                resourses[command] += quantity;
            }
            foreach (var kvp in resourses)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}