using System;
using System.Collections.Immutable;
using static System.Net.Mime.MediaTypeNames;

namespace _5._Dragon_Army
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Dictionary< string, SortedDictionary <string, int[]>> dragons = new Dictionary < string, SortedDictionary<string, int[]>>();

            //Речник от <Тип на дракона, Сортиран Речник< Име, инт масив числовите данни с индекси 0,1,2>>
             
            

            int countOfDragond = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfDragond; i++)
            {
                //The input is in the following format "{type} {name} {damage} {health} {armor}".
                string[] dragonInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string type = dragonInfo[0];
                string name = dragonInfo[1];

                int damage = int.TryParse(dragonInfo[2], out damage) ? damage : 45;
                int health = int.TryParse(dragonInfo[3], out health) ? health : 250;
                int armor = int.TryParse(dragonInfo[4], out armor) ? armor : 10;

                // метода TryParse (връща bool (true,false)) заедно с тернарен оператор
                // опитай да парснеш и ако успееш го запиши, ако не успееш - сложи дефолтна стойност (45,250 и 10)


                if (!dragons.ContainsKey(type))
                {
                    dragons[type] = new SortedDictionary<string, int[]>();
                    
                }
                if (!dragons[type].ContainsKey(name))
                {
                    dragons[type][name] = new int[3];
                }
                dragons[type][name][0]=damage;
                dragons[type][name][1] = health;
                dragons[type][name][2]= armor;


            }

            foreach(var typeKvP in dragons)
            {
               
                Console.WriteLine($"{typeKvP.Key}::({typeKvP.Value.Select(x => x.Value[0]).Average():f2}/{typeKvP.Value.Select(x => x.Value[1]).Average():f2}/{typeKvP.Value.Select(x => x.Value[2]).Average():f2})");
                // достъпвам вътрешния речник и чрез ламбда функция и метод Average определям средната стойност на данните за всички дракони от съответния тип

                foreach(var nameKvp in typeKvP.Value)// достъпвам вътрешния речник 
                {
                    Console.WriteLine($"-{nameKvp.Key} -> damage: {nameKvp.Value[0]}, health: {nameKvp.Value[1]}, armor: {nameKvp.Value[2]}");
                }
            }
            
           
        }
    }
}