using System.Text.RegularExpressions;

namespace MessageTranslator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            string pattern = "\\!(?<command>[A-Z][a-z]{2,})\\!\\:\\[(?<string>[A-Za-z]{8,})\\]";
            Regex regex = new Regex(pattern);
            for(int i = 0; i < rows; i++)
            {
                Match match = regex.Match(Console.ReadLine());
                if (!match.Success)
                {
                    Console.WriteLine("The message is invalid");
                    continue;
                }
                List<int> asciiNumbers = new List<int>();
                string currString = match.Groups["string"].Value;
                foreach(char c in currString)
                {
                    int curNum = c;
                    asciiNumbers.Add(curNum);
                }
                Console.WriteLine($"{match.Groups["command"]}: {(String.Join(" ", asciiNumbers))}");
            }
           
        }
    }
}