namespace _5._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string digits = string.Empty;
            string letters = string.Empty;
            string otherChars = string.Empty;
            for (int i = 0;i< text.Length;i++)
            {
                char curChar = text[i];
               if (char.IsDigit(curChar))
                {
                    digits += curChar;

                }else if (char.IsLetter(curChar))
                {
                    letters += curChar;
                }
                else
                {
                    otherChars += curChar;
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(otherChars);
        }
    }
}