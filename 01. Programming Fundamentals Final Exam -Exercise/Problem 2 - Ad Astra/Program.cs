using System.Text.RegularExpressions;

namespace Problem_2___Ad_Astra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = "(\\||#)(?<name>[A-Za-z\\s]+)\\1(?<date>\\d{2}/\\d{2}/\\d{2})\\1(?<quantity>\\d{1,5})\\1";
            string input = Console.ReadLine();
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            int totalCallories = 0;
            foreach (Match match in matches)
            {
                string name = match.Groups["name"].Value;
                string date = match.Groups["date"].Value;
                int quantity = int.Parse(match.Groups["quantity"].Value);
                totalCallories += quantity;
            }
            int days = totalCallories / 2000;
            Console.WriteLine($"You have food to last you for: {days} days!");
            foreach (Match match in matches)
            {
                Console.WriteLine($"Item: {match.Groups["name"].Value}, Best before: {match.Groups["date"].Value}, Nutrition: {match.Groups["quantity"].Value}");
            }
        }
    }
}