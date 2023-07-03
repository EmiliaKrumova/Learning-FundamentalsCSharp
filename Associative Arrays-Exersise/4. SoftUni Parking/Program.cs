namespace _4._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int count = int.Parse(Console.ReadLine());
            Dictionary<string, string> parking = new Dictionary<string, string>();
            for (int i = 0; i < count; i++)
            {
                string[] carInfo = Console.ReadLine().Split(' ');
                string realCmd = carInfo[0];
                string user = carInfo[1];
                if (realCmd == "register")
                { 
                    string number = carInfo[2];
                    if (!parking.ContainsKey(user))
                    {
                        parking[user] = number;
                        Console.WriteLine($"{user} registered {number} successfully");
                    }else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parking[user]}");
                    }

                }else if (realCmd == "unregister")
                {
                    if (!parking.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                    else
                    {
                        parking.Remove(user);
                        Console.WriteLine($"{user} unregistered successfully");
                    }
                }
            }
            foreach (var kvp in  parking)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}