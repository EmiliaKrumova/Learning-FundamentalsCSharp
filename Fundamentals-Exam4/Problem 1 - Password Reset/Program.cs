using System.Text;

namespace Problem_1___Password_Reset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command;
           
            StringBuilder sb = new StringBuilder();
            string password = input;

            while ((command = Console.ReadLine()) != "Done")
            {
                string[] commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string realCom = commandArgs[0];

                if (realCom == "TakeOdd")
                {
                    password = TakeODD(sb, password);

                }
                else if (realCom == "Cut")
                {
                    password = Cut(password, commandArgs);

                }
                else if (realCom == "Substitute")
                {
                    password = Substitute(password, commandArgs);
                }
            }     
                Console.WriteLine($"Your password is: {password}");
            
            
        }

        private static string Substitute(string password, string[] commandArgs)
        {
            string substring = commandArgs[1];
            string substitute = commandArgs[2];
            if (password.Contains(substring))
            {
                password = password.Replace(substring, substitute);
                Console.WriteLine(password);
            }
            else
            {
                Console.WriteLine("Nothing to replace!");
            }

            return password;
        }

        private static string Cut(string password, string[] commandArgs)
        {
            int index = int.Parse(commandArgs[1]);
            int lenght = int.Parse(commandArgs[2]);
            password = password.Remove(index, lenght);
            Console.WriteLine(password);
            return password;
        }

        private static string TakeODD(StringBuilder sb, string password)
        {
            for (int i = 1; i < password.Length; i += 2)
            {
                sb.Append(password[i]);
            }
            password = sb.ToString();
            Console.WriteLine(password);
            return password;
        }
    }
}