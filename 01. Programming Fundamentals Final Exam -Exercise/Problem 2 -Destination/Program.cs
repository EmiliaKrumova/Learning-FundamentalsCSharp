using System.Text.RegularExpressions;

namespace Problem_2__Destination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = "(=|/)(?<location>[A-Z][A-Za-z]{2,})\\1";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            int points = 0;
            List<string> destinations = new List<string>();
            foreach (Match match in matches)
            {
                points += match.Groups["location"].Length;
                destinations.Add(match.Groups["location"].Value);
            }
           // Console.Write("Destinations: ");
           // Console.WriteLine(String.Join(", ", destinations));
            Console.WriteLine($"Travel Points: {points}");
            Console.WriteLine($"Destinations: {(String.Join(", ", destinations))}");
        }
    }
}