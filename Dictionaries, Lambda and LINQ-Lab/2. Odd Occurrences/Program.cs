namespace _2._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string currWord = word.ToLower();
                if (!counts.ContainsKey(currWord))
                {
                    counts[currWord] = 0;

                }
                counts[currWord]++;
            }
            foreach (var count in counts)
            {
                if(count.Value % 2 != 0)
                {
                    Console.Write(count.Key +" ");
                }
            }
        }
    }
}