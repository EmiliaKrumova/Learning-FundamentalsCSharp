namespace _3._Take_Skip_Rope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> numbers = new List<int>();
            List<char> chars = new List<char>();
            for(int i = 0; i< input.Length; i++)
            {
               char currChar = input[i];
                if (char.IsDigit(currChar))
                {
                    int currNum = (int)currChar;
                    numbers.Add((currNum));
                }
                else
                {
                    chars.Add(currChar);
                }
            } 
            List<int> take = new List<int>();
            List<int> skip = new List<int>();
            for(int i = 0; i  < numbers.Count; i++)
            {
                if(i%2 == 0)
                {
                    take.Add(numbers[i]);

                }
                else
                {
                    skip.Add(numbers[i]);
                }
            }
            string result = string.Empty;
            for (int i = 0; i < chars.Count; i++)
            {
                result += chars.Take(take[i]);
            }
            
        }
    }
}