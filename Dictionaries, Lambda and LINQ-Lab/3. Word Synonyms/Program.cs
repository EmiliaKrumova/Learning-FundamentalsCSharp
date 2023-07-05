namespace _3._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> synonims = new Dictionary<string, List<string>>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string keyWord = Console.ReadLine();
                if (!synonims.ContainsKey(keyWord))
                {
                    synonims[keyWord] = new List<string>();
                }
                string synonimWord = Console.ReadLine();
                synonims[keyWord].Add(synonimWord);
            }

            foreach( KeyValuePair<string, List<string>> keyValuePair in synonims )
            {
                Console.WriteLine($"{keyValuePair.Key} - {string.Join(", ", keyValuePair.Value)}");
            }
            
        }
    }
}