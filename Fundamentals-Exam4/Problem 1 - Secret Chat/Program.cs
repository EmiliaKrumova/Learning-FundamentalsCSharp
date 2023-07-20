namespace Problem_1___Secret_Chat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hidenMsg = Console.ReadLine();
            string command;
            while((command = Console.ReadLine()) != "Reveal")
            {
                string[] cmdArgs = command.Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                string realCom = cmdArgs[0];
                if( realCom== "InsertSpace")
                { int index = int.Parse(cmdArgs[1]);
                   hidenMsg =  hidenMsg.Insert(index, " ");

                    Console.WriteLine(hidenMsg);
                }else if( realCom== "Reverse")

                {
                    string substring = cmdArgs[1];
                    string reversedSubstring = string.Empty;
                    for (int i = substring.Length-1;i>= 0; i--)
                    {
                        reversedSubstring += substring[i];
                    }
                   // Console.WriteLine(reversedSubstring);
                    if (!hidenMsg.Contains(substring))
                    {
                        Console.WriteLine("error");
                        continue;
                    }

                     int index =  hidenMsg.IndexOf(substring);
                      hidenMsg = hidenMsg.Remove(index, substring.Length);
                     hidenMsg = hidenMsg + reversedSubstring;


                    Console.WriteLine(hidenMsg);

                }
                else if ( realCom== "ChangeAll")
                {
                    string substring = cmdArgs[1];
                    string replace = cmdArgs[2];
                    while (hidenMsg.Contains(substring))
                    {
                        hidenMsg = hidenMsg.Replace(substring, replace);
                    }

                    Console.WriteLine(hidenMsg);
                }
            }
            Console.WriteLine($"You have a new text message: {hidenMsg}");
        }
    }
}