using System.Text.RegularExpressions;

namespace _3._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            double income = 0;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                string patern = "[^\\|\\$\\%\\.]*?%(?<name>[A-Z][a-z]+)%[^\\|\\$\\%\\.]*?<(?<product>\\w+)>[^\\|\\$\\%\\.]*?\\|(?<count>\\d+)\\|[^\\|\\$\\%\\.]*?(?<price>\\d+?(\\.\\d+){0,1})\\$[^\\|\\$\\%\\.]*";


                //  в групата price е как се взима дробно число -> (?<price>\\d+?(\\.\\d+){0,1}) ако има точка да има след нея поне една цифра и тази подгрупа може или да я няма (тоест числото е цяло, или да е една)

                // за да направиш една група Lazy (тоест да взима колкото може по малко символи, така, че да не "открадне символи от следващата група) след групата се слага въпросителен знак?

                // групите се четат отляво надясно и обикновено са Greedy - тоест взимат максимално много символи, което не винаги е желано. Затова понякога се налага да направим групата Lazy
                Regex regex = new Regex(patern);
                Match match = regex.Match(input);
                double totalPrice = 0;
                
                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    double price = double.Parse(match.Groups["price"].Value);
                    totalPrice = price * count;
                    Console.WriteLine($"{name}: {product} - {totalPrice:f2}");
                    income += totalPrice;
                }
                

                
                
            }
            Console.WriteLine($"Total income: {income:f2}");
        }
    }
}