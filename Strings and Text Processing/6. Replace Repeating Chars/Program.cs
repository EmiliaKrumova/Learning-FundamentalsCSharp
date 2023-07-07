namespace _6._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = string.Empty;
            for (int i = 0; i< input.Length; i++)
            {
                if (i == input.Length - 1)
                {
                    result += input[i];
                    break;
                }
                char currChar = input[i];
                if (currChar == input[i+1])
                {
                    continue;
                }
                else
                {
                    result += currChar;
                }
            }
            Console.WriteLine(result);

        }
    }
}