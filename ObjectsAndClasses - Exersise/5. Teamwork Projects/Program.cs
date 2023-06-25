using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Teamwork_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfTeams = int.Parse(Console.ReadLine());// броя на отборите
            string [] createTeam;

            List<Teams> teamsCollection = new List<Teams>();// колекцията от отбори
            for(int i = 0; i < countOfTeams; i++)
            {
                createTeam = Console.ReadLine().Split("-",StringSplitOptions.RemoveEmptyEntries);
                string creator = createTeam[0];// създателя
                string teamName = createTeam[1];// име на отбора

                if( teamsCollection.Any (t=>t.TeamName==teamName))// ако съществува вече такъв отбор...изпиши, че съществува
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                if (teamsCollection.Any (t=>t.Creator==creator))// ако този човек вече е създал друг отбор, изпиши, че не може да създаде втори отбор
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }
                // Ако мине предходните проверки:

                // създавам нова инстанция в класа с този създател и име на отбор

                Teams newTeam = new Teams(creator,teamName);
                teamsCollection.Add(newTeam);// добавям в колекцията
                Console.WriteLine($"Team {teamName} has been created by {creator}!");
                
            }
            string tryingToJoin;
          
            while ((tryingToJoin = Console.ReadLine()) != "end of assignment")// чета нова команда
            {
                string[] userAndTeam = tryingToJoin.Split("->", StringSplitOptions.RemoveEmptyEntries);
                string user = userAndTeam[0];// потребител
                string teamName = userAndTeam[1];// име на отбора, в който се опитва да влезе
                
                if (!teamsCollection.Any(t => t.TeamName == teamName))// ако няма отбор с такова име
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }
                if (teamsCollection.Any(t=>t.Creator == user) ||teamsCollection.Any( t=> t.Members.Contains(user)))// ако потребителя е вече член или създател на отбор
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                    continue;
                }
               // Ако мине предните 2 проверки:
               // първо намирам съответния отбор, който потребителя опитва да достъпи
                Teams teamToJoin = teamsCollection.First(t=>t.TeamName == teamName);
                teamToJoin.AddMember(teamToJoin, user);// чрез метода на класа, добавям потребителя

            }
            List<Teams> teamsWithMembers = teamsCollection// създавам нова колекция, от отбори с брой играчи над 0, без да броим създателя
                .Where(t=>t.Members.Count>0)
                .OrderByDescending(t=>t.Members.Count)// подреждаме ги низходящо по броя играчи
                .ThenBy(t=>t.TeamName)// след това по азбучен ред
                .ToList();
            foreach(Teams team in teamsWithMembers)// за всеки от тези отбори
            {
                Console.WriteLine($"{team.TeamName}");// отпечатваме името
                Console.WriteLine($"- {team.Creator}");// създателя
               foreach( string member in team.Members.OrderBy(m=>m))// въртим само в членовете на текущия отбор /подредени по азбучен ред самите членове/вложен foreach!!!
                {
                    Console.WriteLine($"-- {member}");// отпечатваме всеки член на отбора
                }
            }
            List<Teams> teamsToDisband = teamsCollection// отбори, които отпадат
                .Where(t=>t.Members.Count==0)// нямат членове, освен създателя
                .OrderBy(t=>t.TeamName)// подредени по азбучен ред
                .ToList();
            Console.WriteLine("Teams to disband:");
            foreach(Teams team in teamsToDisband)
            {
                Console.WriteLine($"{team.TeamName}");// отпечатваме отпадащите отбори
            }
                
            
        }
    }
    public class Teams
    {
        private  List<string> members;// ВАЖНО!!!  винаги колекция в класа се изнася като field!!! и после се праи на ПРОПЪРТИ
        public Teams(string creator, string teamName)
        {
            Creator = creator;
            TeamName = teamName;

            this.members = new List<string>();// създава филда, като празен лист от стрингове //
                                              // трябва да се инициализира пропъртито, за да не е null
        }

        public string Creator { get; set; }
        public string TeamName { get; set; }
        public List<string> Members // Get-only Property - което връща текущата колекция( тоест членовете на съответния отбор)
            => this.members;

        public void AddMember (Teams teamName, string user)// метод на класа, направен с цел в този отбор да се добавят членове
        {
            members.Add(user);
        }
    }
}
