namespace _1._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<char, int> chars = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                char currChar = text[i];
                if (currChar != ' ')
                {
                    if (!chars.ContainsKey(currChar))
                    {
                        chars[currChar] = 0;
                    }
                    chars[currChar]++;
                }
            }
            foreach (var kvp in chars) 
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
            
    }
}