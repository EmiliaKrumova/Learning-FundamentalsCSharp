namespace _8._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            decimal totalSum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string currString = input[i];
                string substringInt = currString.Substring(1, currString.Length - 2);
                int number = int.Parse(substringInt);
                char firstChar = currString[0];
                char secondChar = currString[currString.Length - 1];
                decimal currSum = 0;
                if (char.IsUpper(firstChar))
                {
                    int firstCharPos = firstChar - 64;
                    currSum = (decimal)number / firstCharPos;


                }
                else
                {
                    int firstCharPos = firstChar - 96;
                    currSum = (decimal)number * firstCharPos;
                }
                if (char.IsUpper(secondChar))
                {
                    int secondCharPos = secondChar - 64;
                    currSum -= secondCharPos;


                }
                else
                {
                    int secondCharPos = secondChar - 96;
                    currSum += secondCharPos;
                }
                totalSum += currSum;

            } Console.WriteLine($"{totalSum:f2}");
        }
    }
}