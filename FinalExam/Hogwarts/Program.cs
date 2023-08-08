namespace Hogwarts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string spell = Console.ReadLine();
           // string output = string.Empty;
            string command;
            while((command = Console.ReadLine()) != "Abracadabra")
            {
                string[] comArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string realCommand = comArgs[0];
                if(realCommand == "Abjuration")
                {
                    spell = spell.ToUpper();
                    Console.WriteLine(spell);

                }else if(realCommand == "Necromancy")
                {
                    spell = spell.ToLower();
                    Console.WriteLine(spell);

                }
                else if (realCommand == "Illusion")
                {

                    
                    int index = int.Parse(comArgs[1]);
                    
                    if(index>=0 && index < spell.Length)
                    {
                        char letter = char.Parse(comArgs[2]);
                        char old = spell[index];
                        spell = spell.Remove(index, 1).Insert(index,letter.ToString());
                        Console.WriteLine("Done!");
                    }
                    else
                    {
                        Console.WriteLine("The spell was too weak.");
                        continue;
                    }
                    

                }else if ((realCommand == "Divination"))
                {
                    string first = comArgs[1];
                    string second = comArgs[2];
                    if (!spell.Contains(first))
                    {
                        continue;
                    }
                    while (spell.Contains(first))
                    {
                        spell = spell.Replace(first, second);
                    }
                    Console.WriteLine(spell);

                }else if((realCommand == "Alteration"))
                {
                    string toDelete = comArgs[1];
                    if(!spell.Contains(toDelete))
                    {
                        continue;
                    }
                    spell = spell.Replace(toDelete,string.Empty);
                    Console.WriteLine(spell);
                }
                else
                {
                    Console.WriteLine("The spell did not work!");
                }
            }
        }
    }
}