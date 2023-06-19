using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string command;
            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] commArg = command.Split();
                string realCmd = commArg[0];

                // List<string> FinalList = new List<string>();
                if (realCmd == "merge")
                {
                    string substring = string.Empty;
                    int startIndex = int.Parse(commArg[1]);
                    int endIndex = int.Parse(commArg[2]);
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex < 0)
                    {
                        endIndex = 0;
                    }
                    if (endIndex >= list.Count)
                    {
                        endIndex = list.Count - 1;
                    }
                    if (startIndex >= list.Count)
                    {
                        startIndex = list.Count - 1;
                    }
                    for (int i = startIndex; i <= endIndex; i++)// !!! да направя проверка дали е валиден индекса!!! Дава ексепшън
                    {
                        string currElement = list[i];
                        substring += currElement;


                    }
                    list.RemoveRange(startIndex, endIndex - startIndex + 1);
                    list.Insert(startIndex, substring);
                    // до тук работи!! само да добавя проверката за индекс

                    //Console.WriteLine(string.Join(" ", list));
                }
                else if (realCmd == "divide")
                {
                    int divideIndex = int.Parse(commArg[1]);
                    int partitions = int.Parse(commArg[2]);
                    string stringToDevide = list[divideIndex].ToString();// tozi string trqbva da go mahna ot lista!!!!
                    list.RemoveAt(divideIndex); // премахвам стринга, който ще деля на парчета
                    int lengthOfSubstrings = stringToDevide.Length / partitions;// пресмятам дължината на всяко парче
                    int remainsOfChars = stringToDevide.Length % partitions;// дали ми остават символи след целочисленото деление
                    int lenghtOfLastSubstring = lengthOfSubstrings + remainsOfChars;// дължината на последното парче
                                                                                    // int newLenghtOfDividedString = stringToDevide.Length - lenghtOfLastSubstring;
                    List<string> substrings = new List<string>();// тук ще пълня с разделените парчета от стринга
                    string currSubstring = "";// празно парченце субстринг - последното и най-голямото
                    for (int i = stringToDevide.Length - 1; i >= 0; i--)// взимам последните символи от стринга отзад-напред
                    {

                        if (currSubstring.Length < lenghtOfLastSubstring)
                        {
                            currSubstring += stringToDevide[i];
                        }
                        if(currSubstring.Length == lenghtOfLastSubstring)
                        {
                            break;
                        }

                    }
                    string lastSubstring = String.Empty;// последното парченце
                    for (int j = currSubstring.Length - 1; j >= 0; j--) // преобръщам взетите с горния цикъл символи, за да направя крайния вариант на последния субстринг
                    {
                        lastSubstring += currSubstring[j];
                    }
                   ;
                    for (int k = 0; k < partitions - 1; k++) // начина да си взема парчетата субстринг
                    {
                       char [] currCharArr = stringToDevide // правя масив от символи, който от стринга (от който трябва да деля парчета) пропускам индекса* дължината на всяко парче. Ако индекса е 0* 2 = 0; ако индекса е 1*2 = 2. Т.е ако съм в първото завъртане, ще взема началните символи, ако съм във второто, ще пропусна началните 2 и ще взема следващите 2 и т.н
                            .Skip(k*lengthOfSubstrings)// пропусни....еди колко си
                            .Take(lengthOfSubstrings)// вземи колкото трябва
                            .ToArray();// направи го на масив от символи
                        string substring = string.Join("", currCharArr);//масива от символи го правя на "истински стринг"
                        substrings.Add(substring);// добавям всички равни парчета субстринг в масива за субстрингове
                    }
                    substrings.Add(lastSubstring);// след цикъла за равните парчета, дабавям и последното "нестандартното" субстринг парче

                  list.InsertRange(divideIndex, substrings); //вмъквам листа с парченца в големия лист(първоначалния)
                    

                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
