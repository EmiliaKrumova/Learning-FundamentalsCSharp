List<string>friends = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
string comand;
int countBlack = 0;
int countLost = 0;
while((comand = Console.ReadLine())!= "Report")
{
    string[] comArg = comand.Split(" ");
    string realCom = comArg[0];
    if(realCom== "Blacklist")
    {
        string name = comArg[1];
        if (friends.Contains(name))
        {
            countBlack++;
            int indexOfName = friends.IndexOf(name);
            friends.Remove(name);
            friends.Insert(indexOfName, "Blacklisted");
            Console.WriteLine($"{name} was blacklisted.");

        }
        else
        {
            Console.WriteLine($"{name} was not found.");
        }
    }else if (realCom == "Error")
    {
        int index = int.Parse(comArg[1]);
       
        if(index<0 || index>=friends.Count)
        {
            continue;
        }else if (friends[index]== "Blacklisted" || friends[index] == "Lost")
        {
            continue;
        }
        else
        {
            string name = friends[index].ToString();
            countLost++;
            friends.RemoveAt(index);
            friends.Insert(index, "Lost");
            Console.WriteLine($"{name} was lost due to an error.");
        }

    }else if(realCom == "Change")
    {
        int index = int.Parse(comArg[1]);
       
        string newName = comArg[2]; 
        if (index < 0 || index >= friends.Count)
        {
            continue;
        }
        else if (friends[index] == "Blacklisted" || friends[index] == "Lost")
        {
            continue;
        }
        else
        {
            string currName = friends[index].ToString();
            friends.RemoveAt(index);
            friends.Insert(index, newName);
            Console.WriteLine($"{currName} changed his username to {newName}.");

        }

    }
    else
    {
        break;
    }

} Console.WriteLine($"Blacklisted names: {countBlack}");
Console.WriteLine($"Lost names: {countLost}");
Console.WriteLine(string.Join(" ", friends));

//Дебъгнете с тези входни данни John, Mike, Eddie Error 3 Blacklist John Change 1 Mike123 Error 2 Report
