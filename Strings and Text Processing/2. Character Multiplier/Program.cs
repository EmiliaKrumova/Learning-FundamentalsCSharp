namespace _2._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();
            string firstWord = words[0];
            string secondWord = words[1];
            int lentgth = Math.Min(firstWord.Length, secondWord.Length);
            int sum = 0;
            for (int i = 0; i < lentgth; i++)
            {
                char currFirstchar = (char)firstWord[i];
                char currSecondChar = (char)secondWord[i];
                sum += currFirstchar * currSecondChar;
                
            }
            if (firstWord.Length > lentgth)
            {
                for (int i = lentgth; i < firstWord.Length; i++)
                {
                    sum += firstWord[i];
                }
            }
            else if (secondWord.Length > lentgth)
            {
                for (int i = lentgth;i < secondWord.Length; i++)
                {
                    sum += secondWord[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}