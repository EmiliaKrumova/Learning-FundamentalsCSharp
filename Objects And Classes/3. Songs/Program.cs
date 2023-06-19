using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace _3._Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());// число от конзолата за броя песни
            List<Song> listOfObjectSong = new List<Song>();// създаден празен лист - виж ред 23
            for (int i = 0; i < numberOfSongs; i++) //от 0 до числото
            {
                string[] song = Console.ReadLine().Split('_');// взимам всяка песен и я деля на
                string typeList = song[0];// в кой списък е
                string songName = song[1];// името на песента
                string songTime = song[2];// времето

                // после създавам клас - ПЕСНИ
                 Song songAsObject = new Song(typeList,songName,songTime);// създавам нов обект - нова песен с характеристики тип, име. време

                // след това създавам ЛИСТ, който ще съхранява Обектите - Песни
                listOfObjectSong.Add(songAsObject);// добавям обекта ПЕСЕН в листа
            }
            string filter = Console.ReadLine();// получавам променлива по която ще филтрирам песните в листа
            
            for(int i = 0;i < listOfObjectSong.Count; i++)// въртя листа от ОБЕКТИ
            {
                Song song = listOfObjectSong[i];// текущата песен (обект)
                if (filter == "all")// принтирай името на всички песни в листа
                {
                    Console.WriteLine(song.Name);

                }else if (filter == song.Type)// принтирай имената на песни от съответен тип
                {
                    Console.WriteLine(song.Name);
                }
               
               
                //Console.WriteLine(song.Type);
            }
        }
    }
    public class Song // клас песни
    {
        public Song(string type, string name, string time) // създавам конструктор за този клас, така че за всеки обект да се запълни следната информация - стринг "тип", стринг "име", стринг"време"
        {
            Type = type;// типа се взима от променливата тип от горния фор цикъл
            Name = name; //името - от променливата за име
            Time = time;// времето от променливата за време
        }
        public string Type { get; set; }// класа ще има  характеристики: тип на песента
        
        public string Name { get; set; }// име на песента
        public string Time { get; set; }// време на песента
    }
}
