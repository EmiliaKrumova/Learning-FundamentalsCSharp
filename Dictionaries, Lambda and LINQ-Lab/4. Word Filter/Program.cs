namespace _4._Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for(int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                if (word.Length %2 == 0)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}