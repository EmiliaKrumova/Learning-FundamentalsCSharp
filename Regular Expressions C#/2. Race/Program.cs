using System.Text.RegularExpressions;

namespace _2._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> racers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string patternName = "(?<name>[A-Za-z])";


            string patternRan = "(?<ran>[0-9])";
            string raserInfo;
            
            Dictionary<string,double> raserAndDistance = new Dictionary<string,double>();
            while ((raserInfo = Console.ReadLine()) != "end of race")
            {
                string name = string.Empty;
                MatchCollection nameChars = Regex.Matches(raserInfo, patternName);
                foreach (Match nameChar in nameChars)
                {
                    name += nameChar.Value;
                }

                MatchCollection ran = Regex.Matches(raserInfo, patternRan);
                //if(!raserAndDistance.ContainsKey(name))
                //{
                //    distanceCurrRaces = 0;
                //}
               

                if (racers.Contains(name))
                {
                    double distanceCurrRacer = 0;
                    foreach (Match match in ran)
                    {
                        distanceCurrRacer += double.Parse(match.Value);
                    }
                    if (!raserAndDistance.ContainsKey(name))
                    {
                        raserAndDistance[name]= distanceCurrRacer;
                    }
                    else
                    {
                        raserAndDistance[name] += distanceCurrRacer;
                    }
                }
                else
                {
                    continue;
                }

            }
            Dictionary<string,double> ordered  = raserAndDistance.OrderByDescending(kvp => kvp.Value).Take(3).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            Console.WriteLine($"1st place: {ordered.Keys.ElementAt(0)}");
            Console.WriteLine($"2nd place: {ordered.Keys.ElementAt(1)}");
            Console.WriteLine($"3rd place: {ordered.Keys.ElementAt(2)}");
        }

        //var result = dict.OrderByDescending(x => x.Value).Take(3).ToList();

        //    for (int i = 1; i <= result.Count; i++) // или i <= 3. Take(3) става излишен
        //    {
        //        string place = i == 1 ? "st" : i == 2 ? "nd" : "rd";// с тернарен оператор - ако i==1, напиши "1st", ако е ==2, напиши 2nd, в противен случай напиши 3rd
        //Console.WriteLine($"{i}{place} place: {result[i - 1].Key}");
        //    }
}
}