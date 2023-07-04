namespace _1._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select (int.Parse)
                .ToList();
            SortedDictionary<int, int> counts = new SortedDictionary<int, int>();
            foreach (int number in numbers)
            {
                if (!counts.ContainsKey(number))
                {
                    counts[number] = 0;
                }
                counts[number]++;
            }
            foreach (var number in counts)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}