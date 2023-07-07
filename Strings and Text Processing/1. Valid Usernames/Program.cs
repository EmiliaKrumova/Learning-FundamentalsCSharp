namespace _1._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(", ").ToList();

            
            foreach (string inputItem in input)
            {
                bool isValid = true;
                if (inputItem.Length<3 || inputItem.Length > 16)
                {
                    isValid = false;
                    continue; ;
                }
                for (int i = 0; i < inputItem.Length; i++)
                {
                    char currChar = inputItem[i];
                    
                    if (!((char.IsLetterOrDigit(currChar) || currChar == '-' || currChar == '_')))
                    {
                        isValid = false;
                        break;
                    }
                
                
                }
                if (isValid)
                {
                    Console.WriteLine(inputItem);
                }

            }
            
        }
    }
}