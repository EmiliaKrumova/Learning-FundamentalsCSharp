using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
//Data Types, Objects, Lists
//Arrays, Lists, Methods


namespace _10._SoftUni_Course_Planning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> initialLessons = Console.ReadLine().Split(", ").ToList();
            string command;
            while ((command = Console.ReadLine()) != "course start")
            {
                string[] commandArg = command.Split(':');
                string realcommand = commandArg[0];
                string lessonTitle = commandArg[1];


                if (realcommand == "Add")
                {
                    
                    if (initialLessons.Contains(lessonTitle))
                    {
                        continue;
                    }
                    else
                    {
                        initialLessons.Add(lessonTitle);
                    }
                    //Console.WriteLine(string.Join(", ", initialLessons));

                }
                else if (realcommand == "Insert")
                {
                    //string lessonTitle = commandArg[1];
                    int index = int.Parse(commandArg[2]);
                    if (index >= 0 && index<initialLessons.Count) 
                    {
                        if (initialLessons.Contains(lessonTitle))
                        {
                            continue;
                        }
                        else
                        {
                            initialLessons.Insert(index, lessonTitle);
                        }

                    }
                    
                   // Console.WriteLine(string.Join(", ", initialLessons));

                }
                else if (realcommand == "Remove")
                {
                   // string lessonTitle = commandArg[1];
                    string exersiseName = ($"{lessonTitle}-Exercise");
                    if (initialLessons.Contains(lessonTitle) )
                    {
                        initialLessons.Remove(lessonTitle);
                        if (initialLessons.Contains(exersiseName))
                        {
                            initialLessons.Remove(exersiseName);
                        }
                        
                    }                   
                    else
                    {
                        continue;
                    }
                    //Console.WriteLine(string.Join(", ", initialLessons));
                }

                else if ((realcommand == "Swap"))
                {
                    //string lessonTitle = commandArg[1];
                    string lessonTitle2 = commandArg[2];
                    
                   

                    if (initialLessons.Contains(lessonTitle) && initialLessons.Contains(lessonTitle2))
                    {

                        int firstLessonIndex = initialLessons.IndexOf(lessonTitle);
                        int secondLessonIndex = initialLessons.IndexOf(lessonTitle2);

                        initialLessons[firstLessonIndex] = lessonTitle2;
                        initialLessons[secondLessonIndex] = lessonTitle;

                        if (initialLessons.Contains($"{lessonTitle}-Exercise"))
                        {
                            initialLessons.Insert(secondLessonIndex + 1, $"{lessonTitle}-Exercise");
                            initialLessons.RemoveAt(firstLessonIndex + 2);
                        }

                        if (initialLessons.Contains($"{lessonTitle2}-Exercise"))
                        {
                            initialLessons.Insert(firstLessonIndex + 1, $"{lessonTitle2}-Exercise");
                            initialLessons.RemoveAt(secondLessonIndex + 2);
                        }
                    }


                }
                else if ((realcommand == "Exercise"))
                {
                    //string lessonTitle = commandArg[1];
                    string exersiseName = ($"{lessonTitle}-Exercise");
                    
                        if (initialLessons.Contains(exersiseName))
                        {
                            continue;
                        }
                        else if (initialLessons.Contains(lessonTitle))
                        {
                            int lastLessonIndex = initialLessons.IndexOf((lessonTitle));
                            initialLessons.Insert(lastLessonIndex + 1, exersiseName);
                        }
                        else
                        {
                            initialLessons.Add(lessonTitle);
                            initialLessons.Add(exersiseName);
                        }
                    
                    //Console.WriteLine(string.Join(", ", initialLessons));

                }

                // }

            }
            for (int i = 0; i < initialLessons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{initialLessons[i]}");
            }
            //Console.WriteLine(string.Join(", ", initialLessons));
        }
    }
}
