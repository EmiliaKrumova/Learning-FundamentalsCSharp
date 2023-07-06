using System.Linq;

namespace _3._MOBA_Challenger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"{player} -> {position} -> {skill}"
            Dictionary<string,Dictionary<string,int>> players = new Dictionary<string,Dictionary<string,int>>();

            string command;
            while ((command = Console.ReadLine()) != "Season end")
            {
                string[] separators = new string[] { " -> ", " vs " };
                string[] playerInfo = command.Split(separators,StringSplitOptions.RemoveEmptyEntries);

                if (playerInfo.Length == 3 )
                {
                    string playerName = playerInfo[0];
                    string position = playerInfo[1];
                    int skill = int.Parse(playerInfo[2]);
                    if (!players.ContainsKey(playerName))
                    {
                        players[playerName] = new Dictionary<string, int>();
                    }
                    if (!players[playerName].ContainsKey(position))
                    {
                        players[playerName][position] = 0;
                    }
                    if (skill > players[playerName][position])
                    {
                        players[playerName][position] = skill;
                    }
                }else if (playerInfo.Length == 2)
                {
                    string firstPlayer = playerInfo[0];
                    string secondPlayer = playerInfo[1];
                    if (players.ContainsKey(firstPlayer) && players.ContainsKey(secondPlayer))
                    {
                        string loser = string.Empty;
                        foreach(var firstPosition in players[firstPlayer])
                        {
                            foreach(var secondPosition in players[secondPlayer])
                            {
                                if (firstPosition.Key == secondPosition.Key)
                                {
                                    if (players[firstPlayer].Values.Sum() > players[secondPlayer].Values.Sum())
                                    {
                                        loser = secondPlayer;
                                        break;
                                    }                                        
                                    else if (players[firstPlayer].Values.Sum() < players[secondPlayer].Values.Sum())
                                    {
                                        loser = secondPlayer;
                                        break;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                       
                                }
                                
                            }
                            

                        }
                        if (loser != string.Empty)
                        {
                            players.Remove(loser);
                            continue;
                        }



                    }
                    else
                    {
                        continue;
                    }
                }
                
            }  
            foreach(var player in players.OrderByDescending(s => s.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");
                foreach (var position in player.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }
            
                
                

            

        }
    }
}