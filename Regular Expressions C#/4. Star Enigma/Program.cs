using System.Text;
using System.Text.RegularExpressions;

namespace _4._Star_Enigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<string> attacked = new List<string>();
            List<string>destroyed = new List<string>();
            for(int i = 0; i < lines; i++)
            {
                string encriptedMsg = Console.ReadLine();
                string decrypted = DecriptionMethod(encriptedMsg);
                string patern = "[^\\@\\!\\-\\:\\>]*\\@(?<planet>[A-Za-z]+)[^\\@\\!\\-\\:\\>]*\\:\\d+[^\\@\\!\\-\\:\\>]*\\!(?<atackType>A|D)\\![^\\@\\!\\-\\:\\>]*\\-\\>\\d+";
                Regex regex = new Regex(patern);
                Match match = regex.Match(decrypted);
                if (match.Success)
                {
                    string planetName = match.Groups["planet"].Value;
                    string atackType = match.Groups["atackType"].Value;
                    if (atackType == "A")
                    {
                        attacked.Add(planetName);
                    }
                    else if (atackType == "D")
                    {
                        destroyed.Add(planetName);
                    }
                }
               
            }PrintPlanets(attacked, "Attacked");
            PrintPlanets(destroyed, "Destroyed");
            
        }
        static void PrintPlanets (List<string> planets,string atackType)
        {
            Console.WriteLine($"{atackType} planets: {planets.Count}");
            foreach (string planet in planets.OrderBy(x => x))
             {

                Console.WriteLine($"-> {planet}");
            }
        }
        static string DecriptionMethod (string encriptedMsg)
        {
            StringBuilder decryptedMsg = new StringBuilder();
            int count = CountOfSTAR(encriptedMsg);
            foreach (char curChar in encriptedMsg)
            {
                decryptedMsg.Append((char)(curChar-count));
            }
            return decryptedMsg.ToString();
        }
        static int CountOfSTAR(string encriptedMsg)
        {
            int count = 0;
            foreach(char s in encriptedMsg.ToLower())
            {
                if (s == 's'|| s=='t'|| s=='a'|| s == 'r')
                {
                    count++;
                }
                
            }
            return count;
        }
    }
}