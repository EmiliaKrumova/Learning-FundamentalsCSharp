using System.Text.RegularExpressions;

namespace Problem_2_Fancy_Barcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string pattern = "(\\@#+)(([A-Z][A-Za-z0-9]{4,})[A-Z])\\@#+";
            int n = int.Parse(Console.ReadLine());
            //Dictionary<Match,int> map = new Dictionary<Match,int>();
            for(int i = 0; i < n; i++)
            {
                //string pattern = "(\\@#+)(([A-Z][A-Za-z0-9]{5,})[A-Z])\\1";
                string input = Console.ReadLine();
                Regex regex1 = new Regex(pattern);
                Match match  = regex1.Match(input);
                if(!match.Success)
                {
                    Console.WriteLine("Invalid barcode");
                    continue;

                }
                string secondPatern = "\\d";
                Regex regex = new Regex(secondPatern);
                string productGroup = string.Empty;

               

                MatchCollection digits = regex.Matches(match.ToString());
                
                if (digits.Count > 0)
                {
                    
                    foreach (Match m in digits)
                    {
                        productGroup += m.Value;

                    }
                }
                else
                {
                    productGroup += "00";
                    
                }
                
               
                Console.WriteLine($"Product group: {productGroup}");
            }
           
        }
    }
}