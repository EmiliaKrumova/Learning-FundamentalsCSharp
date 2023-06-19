
List<string>friends = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).ToList();
string command;
int counterBlacklisted = 0;
int counterLost = 0;

while ((command = Console.ReadLine()) != "Report")
{
    string[] commandArgs = command.Split(" ",StringSplitOptions.RemoveEmptyEntries);
    string realCommand = commandArgs[0];
    if(realCommand== "Blacklist")
    {
        string name = commandArgs[1];
        if (friends.Contains(name))
        {
            int index = friends.IndexOf(name);
            friends.Remove(name);
            friends.Insert(index, "Blacklisted");
            //friends[index] = "Blacklisted";
            counterBlacklisted++;
            Console.WriteLine($"{name} was blacklisted.");
        }
        else
        {
            Console.WriteLine($"{name} was not found.");
        }

    }else if (realCommand == "Error")
    {
        int index = int.Parse(commandArgs[1]);
        string name = friends[index];
        if(index >= 0 && index < friends.Count)
        {
            if (friends[index] =="Blacklisted"|| friends[index] == "Lost")
            {
                continue;
            }
            else
            {
                friends[index] = "Lost";
                counterLost++;
                Console.WriteLine($"{name} was lost due to an error.");
            }
        }
        else
        {
            continue;
        }
    }else if(realCommand == "Change")
    {
        int index = int.Parse(commandArgs[1]);
        string name = commandArgs[2];
        if(index >= 0 && index < friends.Count)
        {
            string currName = friends[index];
            friends.RemoveAt(index);
            friends.Insert(index, name);
            //friends[index] = name;
            Console.WriteLine($"{currName} changed his username to {name}.");
        }
        else
        {
            continue;
        }

    }
    else { continue; }
}
Console.WriteLine($"Blacklisted names: {counterBlacklisted}");
Console.WriteLine($"Lost names: {counterLost}");
Console.WriteLine(string.Join(" ", friends));
