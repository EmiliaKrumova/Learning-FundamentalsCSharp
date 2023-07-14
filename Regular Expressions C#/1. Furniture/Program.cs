using System.Text.RegularExpressions;

namespace _1._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = "^>>(?<furnitureName>[A-Z]*[a-z]*)<<(?<price>\\d+\\.?\\d+)!(?<quantity>\\d+)(\\.\\d+){0,1}$";
            string input;
            List<string> output = new List<string>();
            decimal sum = 0;    
            while ((input = Console.ReadLine()) != "Purchase") 
            {
                Match match = Regex.Match(input, regex);
                if (match.Success)
                {
                    string furniture = match.Groups["furnitureName"].Value;
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    output.Add(furniture);
                    sum += price * quantity;
                }
                
            }
            Console.WriteLine("Bought furniture:");
            foreach(string furniture in output)
            {
                Console.WriteLine(furniture);
            }
            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}