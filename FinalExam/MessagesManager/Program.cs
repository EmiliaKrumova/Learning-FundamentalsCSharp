namespace MessagesManager
{
    using System;
    using System.Data;

    internal class Program
    {
        static void Main(string[] args)
        {
            int messageCapacity = int.Parse(Console.ReadLine());
            string command = string.Empty;
            Dictionary<string, List<int>> list = new Dictionary<string, List<int>>();

            while ((command = Console.ReadLine()) != "Statistics")
            {
                string[] commandData = command.Split("=", StringSplitOptions.RemoveEmptyEntries);
                string typeOfCommand = commandData[0];

                if (typeOfCommand == "Add")
                {
                    string username = commandData[1];
                    int sent = int.Parse(commandData[2]);
                    int received = int.Parse(commandData[3]);

                    if (!list.ContainsKey(username))
                    {
                        list[username] = new List<int>();
                        list[username].Add(sent); // index 0 == sent
                        list[username].Add(received); // index 1 == recived
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (typeOfCommand == "Message")
                {
                    string senderName = commandData[1];
                    string reciverName = commandData[2];

                    if (list.ContainsKey(senderName) && list.ContainsKey(reciverName))
                    {
                        list[senderName][0]++;
                        list[reciverName][1]++;

                        if (list[senderName][0] + list[senderName][1] >= messageCapacity)
                        {
                            list.Remove(senderName);
                            Console.WriteLine($"{senderName} reached the capacity");
                        }

                        if (list[reciverName][0] + list[reciverName][1] >= messageCapacity)
                        {
                            list.Remove(reciverName);
                            Console.WriteLine($"{reciverName} reached the capacity");
                        }
                    }
                }
                else if (typeOfCommand == "Empty")
                {
                    string username = commandData[1];

                    if (username == "All")
                    {
                        list.Clear();
                        continue;
                    }

                    if (list.ContainsKey(username))
                    {
                        list.Remove(username);
                    }
                }
            }

            Console.WriteLine($"Users count: {list.Count}");

            foreach (var user in list.OrderBy(x => x.Value.Sum()))
            {
                Console.WriteLine($"{user.Key} - {user.Value.Sum()}");
            }
        }
    }
}