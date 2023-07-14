using System.Text.RegularExpressions;

namespace _5._Nether_Realms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] demons = Regex.Split(Console.ReadLine(), @" *,{1} *");// сплитвам по регекс ,който може да е интервал (0 или повече), запетайка и пак интервал, за да направя масив с имената на демоните

            SortedDictionary<string,Dictionary<int, double>> demonsDict = new SortedDictionary<string,Dictionary<int, double>>();// Речник за информацията за демоните
           

            for (int i = 0; i < demons.Length; i++)
            {
                int currDemonHealt = 0;// живот на демона
                string currDemonName = demons[i];// име на демона
               
                string healthPattern = "[^\\*\\-\\+\\/\\.\\d]"; // създавам патерн, който игнорира математическите знаци, точка и цифри
                Regex health = new Regex(healthPattern, RegexOptions.None);
                
                MatchCollection matchHealth = health.Matches(currDemonName);// правя колекция от всички символи , без тези в патерна
                foreach (Match matchChar in matchHealth)
                {
                   char currChar =char.Parse( matchChar.Value);
                    currDemonHealt += currChar;
                }


                double currDamage = 0;
                string damagePattern = "((|-)\\d+\\.\\d+|(|-)\\d+)";
                Regex damage = new Regex(damagePattern);
                MatchCollection matchDmg = damage.Matches(currDemonName);
                foreach (Match matchNumber in matchDmg)
                {
                    double currDmg = double.Parse( matchNumber.Value);
                    currDamage += currDmg;
                }
                foreach(char ch in currDemonName)
                {
                    if (ch ==  '*')
                    {
                        currDamage *= 2;
                    }else if (ch == '/')
                    {
                        currDamage/=2;
                    }
                }
                if (!demonsDict.ContainsKey(currDemonName))
                {
                    demonsDict[currDemonName] = new Dictionary<int, double>();
                    if (!demonsDict[currDemonName].ContainsKey(currDemonHealt))
                    {
                        demonsDict[currDemonName][currDemonHealt] = currDamage;
                    }
                }

            }
            foreach(var demon in demonsDict)
            {

                Dictionary<int, double> secondDict = demon.Value;
               // Console.WriteLine($"{demon.Key} - {demon.Value.Keys.SingleOrDefault()} health, {demon.Value.Values.Single():f2} damage");

                foreach(var key in secondDict)
                {
                    Console.WriteLine($"{demon.Key} - {key.Key} health, {key.Value:f2} damage");
                }

                
            }
            
        }
    }
}