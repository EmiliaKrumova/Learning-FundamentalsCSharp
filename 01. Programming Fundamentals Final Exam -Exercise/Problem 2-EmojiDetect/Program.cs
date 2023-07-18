using System.Text.RegularExpressions;

namespace Problem_2_EmojiDetect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int result = CalculateCoolTrehold(input);

            MatchCollection matchesEmojies;
            Dictionary<string, int> coolnes;

            DefineCoolnessOfEmoji(input, out matchesEmojies, out coolnes);

            Console.WriteLine($"Cool threshold: {result}");
            Console.WriteLine($"{matchesEmojies.Count} emojis found in the text. The cool ones are:");
            foreach (var kvp in coolnes)
            {
                if ((kvp.Value) >= result)
                {
                    Console.WriteLine(kvp.Key);
                }
            }
        }

        private static void DefineCoolnessOfEmoji(string input, out MatchCollection matchesEmojies, out Dictionary<string, int> coolnes)
        {
            string patternForEmojies = "(:{2}|\\*{2})(?<emoji>[A-Z][a-z]{2,})\\1";
            Regex regexEmoji = new Regex(patternForEmojies);
            matchesEmojies = regexEmoji.Matches(input);// колекцията от Емоджита
            coolnes = new Dictionary<string, int>();// речник - срещу името на всяко емоджи ще стои неговата "coolnes"
            foreach (Match match in matchesEmojies)
            {
                string emoji = match.Value; // трябва да събера АСКИ стойността на всеки символ от емоджи

                int cool = 0;
                for (int i = 0; i < emoji.Length; i++)
                {
                    if (emoji[i] == ':' || emoji[i] == '*')// с изключение на символите ':' и '*'
                    {
                        continue;
                    }
                    cool += emoji[i];

                }
                if (!coolnes.ContainsKey(emoji))// пълня речника
                {
                    coolnes[emoji] = 0;
                }
                coolnes[emoji] = cool;
            }
        }

        private static int CalculateCoolTrehold(string input)
        {
            string patternForDigits = "\\d"; //търся само единични цифри
            Regex regexDigits = new Regex(patternForDigits);
            MatchCollection matchesOfDigits = regexDigits.Matches(input);
            int result = 1;
            foreach (Match match in matchesOfDigits)
            {
                result *= int.Parse(match.Value);// умножавам всички намерени цифри в стринга
            }

            return result;// връщам резултат
        }
    }
}