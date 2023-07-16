namespace Problem_1___The_Imitation_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string encryptedMsg = Console.ReadLine();// първоначален текст
            string command;
            while((command = Console.ReadLine()) != "Decode")
            {
                string[] commandArgs = command.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string realCommand = commandArgs[0];
                if(realCommand== "Move")
                {
                    int countOfCharsToMove = int.Parse(commandArgs[1]);
                    string substring = encryptedMsg.Substring(0, countOfCharsToMove);// правя си субстринг от индекс 0 до броя на символите, които са ми дадени
                    encryptedMsg= encryptedMsg.Remove(0, countOfCharsToMove);// премахвам този субстринг
                    encryptedMsg=encryptedMsg+substring;// добавям го в края на стринга
                    //Console.WriteLine(encryptedMsg);

                }
                else if (realCommand== "Insert")
                {
                    int indexToInsert = int.Parse(commandArgs[1]);
                    string insertValue = commandArgs[2];
                    encryptedMsg = encryptedMsg.Insert(indexToInsert, insertValue);// вмъквам субстринг от индекса, който ми е даден
                    //Console.WriteLine(encryptedMsg);

                }
                else if (realCommand== "ChangeAll")
                {
                    string stringToReplace = commandArgs[1];
                    string insertValue = commandArgs[2];
                    encryptedMsg = encryptedMsg.Replace(stringToReplace, insertValue);// където срещне субстринг или символ, го реплейсва с новия
                    //Console.WriteLine(encryptedMsg);
                }
            }
            Console.WriteLine($"The decrypted message is: {encryptedMsg}");
        }
    }
}