namespace Problem_3___Heroes_of_Code_and_Logic_VII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int[]> heroes = new Dictionary<string, int[]>();

            for (int i = 0; i < n; i++)
            {
                string heroInfo = Console.ReadLine();
                string[] argsHero = heroInfo.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string heroName = argsHero[0];
                int hPoins = int.Parse(argsHero[1]);
                int mPoints = int.Parse(argsHero[2]);
                if (!heroes.ContainsKey(heroName))
                {
                    heroes[heroName] = new int[2];
                }
                heroes[heroName][0] = hPoins;
                heroes[heroName][1] = mPoints;

            }
            string command;
            while((command = Console.ReadLine())!= "End")
            {
                string[] comArgs = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string realCommand = comArgs[0];
                string heroName = comArgs[1];
                if(realCommand== "CastSpell")
                {
                    int points = int.Parse(comArgs[2]);
                    string spell = comArgs[3];
                    if (heroes[heroName][1]>=points)
                    {
                        int mana = heroes[heroName][1];
                        int leftMana = mana-points;
                        Console.WriteLine($"{heroName} has successfully cast {spell} and now has {leftMana} MP!");
                        heroes[heroName][1] = leftMana;
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spell}!");
                    }

                }else if(realCommand== "TakeDamage")
                {
                    int damage = int.Parse(comArgs[2]);
                    string attacker = comArgs[3];
                    int hpointsLeft = heroes[heroName][0] - damage;
                    if (hpointsLeft <= 0)
                    {
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        heroes.Remove(heroName);
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {hpointsLeft} HP left!");
                        heroes[heroName][0] = hpointsLeft;
                    }


                }else if (realCommand== "Recharge")
                {
                    int amount = int.Parse(comArgs[2]);
                    int newAmount = amount + heroes[heroName][1];
                    //heroes[heroName][1] += amount;
                    if (newAmount > 200)
                    {
                        amount = 200 - heroes[heroName][1];
                        heroes[heroName][1] = 200;
                        Console.WriteLine($"{heroName} recharged for {amount} MP!");
                    }
                    else
                    {
                        heroes[heroName][1] = newAmount;
                        Console.WriteLine($"{heroName} recharged for {amount} MP!");
                    }
                    

                }else if(realCommand== "Heal")
                {
                    int amount = int.Parse(comArgs[2]);
                    int newMPoints = heroes[heroName][0] + amount;
                   // heroes[heroName][0] += amount;
                    if (newMPoints > 100)
                    {
                        amount = 100 - heroes[heroName][0];
                        heroes[heroName][0] = 100;
                        Console.WriteLine($"{heroName} healed for {amount} HP!");
                    }
                    else
                    {
                        heroes[heroName][0] = newMPoints;
                        Console.WriteLine($"{heroName} healed for {amount} HP!");
                    }
                    

                }
            } foreach(var hero in heroes)
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($"  HP: {hero.Value[0]}");
                Console.WriteLine($"  MP: {hero.Value[1]}");
            }
        }
    }
}