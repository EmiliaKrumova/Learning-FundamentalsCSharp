using System.Text.RegularExpressions;
using System.Linq;

namespace _2._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = "\\+{1}359([\\s|-])2\\1([\\d]{3})\\1([\\d]{4})\\b";
            string phoneNumber = Console.ReadLine();
            MatchCollection mathes = Regex.Matches(phoneNumber, regex);
            string[] mathesToPrint = mathes
               .Cast<Match>()
               .Select(m => m.Value.Trim())
               .ToArray();
            Console.WriteLine(string.Join(", ", mathesToPrint));
        }
    }
}