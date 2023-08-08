namespace Messages_Manager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            string command;
            Dictionary<string,Users> users = new Dictionary<string,Users>();
            while((command = Console.ReadLine()) != "Statistics")
            {
                string[] comArgs = command.Split("=", StringSplitOptions.RemoveEmptyEntries);
                string realCom = comArgs[0];
                if (realCom == "Add")
                {
                    //"Add={username}={sent}={received}"
                    string userName = comArgs[1];
                    int sent = int.Parse(comArgs[2]);
                    int received = int.Parse(comArgs[3]);
                    if(!users.ContainsKey(userName))
                    {
                        Users user = new Users( userName,  sent,  received);
                        users[userName] = user;

                    }
                    else
                    {
                        continue;
                    }
                }else if(realCom == "Message")
                {
                    //"Message={sender}={receiver}"
                    string sender = comArgs[1];
                    string reciever = comArgs[2];
                    if (users.ContainsKey(sender) && users.ContainsKey(reciever))
                    {
                        users[sender].Sent += 1;
                        users[reciever].Recieved += 1;
                        int totalMesg = users[sender].Sent + users[sender].Recieved;
                        if (totalMesg >= capacity)
                        {
                            Console.WriteLine($"{sender} reached the capacity!");
                            users.Remove(sender);

                        }
                        int totalMesgRsv = users[reciever].Sent + users[reciever].Recieved;
                        if (totalMesgRsv >= capacity)
                        {
                            Console.WriteLine($"{reciever} reached the capacity!");
                            users.Remove(reciever);

                        }
                    }
                     

                    
                }else if(realCom == "Empty")
                {
                    //"Empty={username}"
                    string userName = comArgs[1];
                    if (users.ContainsKey(userName))
                    {
                        users.Remove(userName);
                    }
                    if (userName == "All")
                    {
                        users.Clear();
                    }
                }
            } Console.WriteLine($"Users count: {users.Count}");
            foreach(var user in users)//.OrderBy(user=>user.Key))
            {
                int totalMSg = user.Value.Sent+ user.Value.Recieved;
                Console.WriteLine($"{user.Key} - {totalMSg}");
            }
        }
    }
    public class Users
    {
        public Users(string userName, int sent, int received)
        {
            Name = userName;
            Sent = sent;
            Recieved = received;
            
        }
        
        public string Name{ get; set;  }
        public int Sent { get; set; }
        public int Recieved { get; set; }
        public int Total { get; set; }
        public static int Messages(int sent, int recieved)
        {
            int totalMSG = sent + recieved;
            return totalMSG;
        }
    }
}