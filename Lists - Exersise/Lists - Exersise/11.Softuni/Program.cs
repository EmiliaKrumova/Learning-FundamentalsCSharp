using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> courseSchedule = Console.ReadLine()
               .Split(", ")
               .ToList();


            string commandsInput = "";

            while ((commandsInput = Console.ReadLine()) != "course start")
            {
                List<string> stringInput = commandsInput.Split(":").ToList();

                string command = stringInput[0];
                string lessonTitle = stringInput[1];

                switch (command)
                {
                    case "Add":
                        if (!courseSchedule.Contains(lessonTitle))
                        {
                            courseSchedule.Add(lessonTitle);
                        }
                        break;

                    case "Insert":

                        int index = int.Parse(stringInput[2]);
                        if (!courseSchedule.Contains(lessonTitle))
                        {
                            courseSchedule.Insert(index, lessonTitle);
                        }
                        break;

                    case "Remove":

                        if (courseSchedule.Contains(lessonTitle))
                        {
                            courseSchedule.Remove(lessonTitle);

                            if (courseSchedule.Contains($"{lessonTitle}-Exercise"))
                            {
                                courseSchedule.Remove($"{lessonTitle}-Exercise");
                            }
                        }
                        break;

                    case "Swap":

                        string lessonToSwap = stringInput[2];
                        if (courseSchedule.Contains(lessonTitle) && courseSchedule.Contains(lessonToSwap))
                        {
                            int firstLessonIndex = courseSchedule.IndexOf(lessonTitle);
                            int secondLessonIndex = courseSchedule.IndexOf(lessonToSwap);

                            courseSchedule[firstLessonIndex] = lessonToSwap;
                            courseSchedule[secondLessonIndex] = lessonTitle;

                            if (courseSchedule.Contains($"{lessonTitle}-Exercise"))
                            {
                                courseSchedule.Insert(secondLessonIndex + 1, $"{lessonTitle}-Exercise");
                                courseSchedule.RemoveAt(firstLessonIndex + 2);
                            }

                            if (courseSchedule.Contains($"{lessonToSwap}-Exercise"))
                            {
                                courseSchedule.Insert(firstLessonIndex + 1, $"{lessonToSwap}-Exercise");
                                courseSchedule.RemoveAt(secondLessonIndex + 2);
                            }
                        }
                        break;

                    case "Exercise":

                        string exercise = $"{lessonTitle}-Exercise";

                        if (!courseSchedule.Contains(exercise))
                        {
                            if (courseSchedule.Contains(lessonTitle))
                            {
                                int indexLesson = courseSchedule.IndexOf(lessonTitle);

                                courseSchedule.Insert(indexLesson + 1, exercise);
                            }

                            else
                            {
                                courseSchedule.Add(lessonTitle);
                                courseSchedule.Add(exercise);
                            }
                        }

                        break;
                }
            }

            for (int i = 1; i <= courseSchedule.Count; i++)
            {
                Console.WriteLine($"{i}.{courseSchedule[i - 1].TrimStart()}");
            }
        }
    }
}
