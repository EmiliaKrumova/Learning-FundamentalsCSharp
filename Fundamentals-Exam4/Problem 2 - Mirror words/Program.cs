using System.Data.SqlTypes;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem_2___Mirror_words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = "(\\@|#)(?<first>[A-Za-z]{3,})\\1\\1(?<second>[A-Za-z]{3,})\\1";
            string input = Console.ReadLine();
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            if(matches.Count <= 0 )
            {
                Console.WriteLine("No word pairs found!");
                
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }
           
            Dictionary<string, string> matchWords = new Dictionary<string, string>();

            foreach (Match match in matches)
            {
                string firstWord = string.Empty;
                string secondWord = string.Empty;
                firstWord += match.Groups["first"].Value;
                secondWord += match.Groups["second"].Value;
                string reversedSecond = string.Empty;
                for (int i = secondWord.Length - 1; i >= 0; i--)
                {
                    reversedSecond += secondWord[i];
                }
                
                if (firstWord == reversedSecond)
                {
                    if (!matchWords.ContainsKey(firstWord))
                    {
                        matchWords.Add(firstWord, secondWord);
                    }
                    else
                    {
                        matchWords[firstWord] = secondWord;
                    }

                }

            }
            
            if(matchWords.Count <= 0)
            {
                Console.WriteLine("No mirror words!");
              
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                
              
                
                   string  output = string.Join(", ", matchWords.Select(x => x.Key + " <=> " + x.Value).ToArray());
                
                Console.WriteLine(output);
            }

        }
    }
}