using System.Text;

namespace _01._Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //9992 562 8933
           // This is some message for you
           // 0123456789112345678921234567        
                        string [] separateDigits = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < separateDigits.Length; i++)
            {
                int currIndex = 0;
                int  currNum = int.Parse(separateDigits[i]);

                while(currNum > 0)
                {
                    currIndex += currNum % 10;
                    currNum = currNum / 10;

                }
                if(currIndex>text.Length)
                {
                    currIndex = currIndex%text.Length;
                }
                sb.Append(text[currIndex]);
                text = text.Remove(currIndex,1);
              
                
            }
            Console.WriteLine(sb.ToString());
        } 
    }
}