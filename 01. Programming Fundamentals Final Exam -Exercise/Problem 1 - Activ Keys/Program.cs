using System.ComponentModel.Design;

namespace Problem_1___Activ_Keys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input  = Console.ReadLine();
            string command;
            while ((command = Console.ReadLine()) != "Generate")
            {
                string[] comArgs = command.Split(">>>", StringSplitOptions.RemoveEmptyEntries);
                string realCom = comArgs[0];
                if (realCom == "Contains")
                {
                    string substring = comArgs[1];
                    if (input.Contains(substring))
                    {
                        Console.WriteLine($"{input} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");  // Emili aK rumova
                    }
                }else if (realCom == "Flip")
                {
                    string secCom = comArgs[1];
                    int startIndex = int.Parse(comArgs[2]);
                    int endIndex = int.Parse(comArgs[3]);
                    if(secCom== "Upper")
                    {
                        string substring = input.Substring(startIndex, endIndex - startIndex);
                        input = input.Remove(startIndex, substring.Length);
                        substring = substring.ToUpper();
                       input =  input.Insert(startIndex, substring);
                           // (startIndex,endIndex).ToUpper();

                    }else if (secCom== "Lower")
                    {
                        string substring = input.Substring(startIndex, endIndex - startIndex);
                        input = input.Remove(startIndex, substring.Length);
                        substring = substring.ToLower();
                        input = input.Insert(startIndex, substring);
                        Console.WriteLine(input);
                    }


                }else if ((realCom == "Slice"))
                {
                    int startIndex = int.Parse(comArgs[1]);
                    int endIndex = int.Parse(comArgs[2]);
                    string substring = input.Substring(startIndex, endIndex - startIndex);
                    input = input.Remove(startIndex, substring.Length);
                    Console.WriteLine(input);

                }
            } Console.WriteLine($"Your activation key is: {input}");
        }
    }
}