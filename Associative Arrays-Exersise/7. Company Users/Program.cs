namespace _7._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,List<string>> companies = new Dictionary<string,List<string>>();
            string cmd;
            while ((cmd = Console.ReadLine()) != "End") 
            {
                string[] cmdArg = cmd.Split(" -> ");
                string compName = cmdArg[0];
                string employeeID = cmdArg[1];
                if (!companies.ContainsKey(compName))
                {
                    companies[compName] = new List<string>();
                }
                if (companies[compName].Contains(employeeID))
                {
                    continue;
                }
                companies[compName].Add(employeeID);
            }
            foreach (var kvp in  companies)
            {
                Console.WriteLine(kvp.Key);
                foreach (var iD in kvp.Value)
                {
                    Console.WriteLine($"-- {iD}");
                }

            }
        }
    }
}