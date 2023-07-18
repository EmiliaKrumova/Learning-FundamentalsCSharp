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
                input = Operations(input, comArgs, realCom);
            }
            Console.WriteLine($"Your activation key is: {input}");
        }

        private static string Operations(string input, string[] comArgs, string realCom)
        {
            if (realCom == "Contains")
            {
                Contains(input, comArgs);
            }
            else if (realCom == "Flip")
            {
                input = FlipMethod(input, comArgs);

            }
            else if ((realCom == "Slice"))
            {
                input = SliceMethod(input, comArgs);

            }

            return input;
        }

        private static string SliceMethod(string input, string[] comArgs)
        {
            int startIndex = int.Parse(comArgs[1]);
            int endIndex = int.Parse(comArgs[2]);
            string substring = input.Substring(startIndex, endIndex - startIndex);
            input = input.Remove(startIndex, substring.Length);
            Console.WriteLine(input);
            return input;
        }

        private static string FlipMethod(string input, string[] comArgs)
        {
            string secCom = comArgs[1];
            int startIndex = int.Parse(comArgs[2]);
            int endIndex = int.Parse(comArgs[3]);

            if (secCom == "Upper")
            {
                string substring = input.Substring(startIndex, endIndex - startIndex);
                input = input.Remove(startIndex, substring.Length);
                substring = substring.ToUpper();
                input = input.Insert(startIndex, substring);
                Console.WriteLine(input);
                // (startIndex,endIndex).ToUpper();

            }
            else if (secCom == "Lower")
            {
                string substring = input.Substring(startIndex, endIndex - startIndex);
                input = input.Remove(startIndex, substring.Length);
                substring = substring.ToLower();
                input = input.Insert(startIndex, substring);
                Console.WriteLine(input);
            }

            return input;
        }

        private static void Contains(string input, string[] comArgs)
        {
            string substring = comArgs[1];
            if (input.Contains(substring))
            {
                Console.WriteLine($"{input} contains {substring}");
            }
            else
            {
                Console.WriteLine("Substring not found!");  
            }
        }
    }
}