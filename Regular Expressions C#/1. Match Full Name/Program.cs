using System.Text.RegularExpressions;
using System.Linq;

namespace _1._Match_Full_Name
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b[A-Z][a-z]+\b[' ']\b[A-Z][a-z]+\b";
            string names = Console.ReadLine();
            MatchCollection matchedNames = Regex.Matches(names, regex);
           
            foreach (Match name in matchedNames)
            {
                Console.Write(name.Value+" ");
                

            }Console.WriteLine();
        }
    }
        
    
}