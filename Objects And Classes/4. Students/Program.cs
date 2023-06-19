using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks.Dataflow;

namespace _4._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentInput;
            List<Student> students = new List<Student>();// празен лист за обектите
            while ((studentInput = Console.ReadLine()) != "end") // чета входа, докато е различен от енд
            {
                string[] studentInfo = studentInput.Split(' ');// правя входа на масив
                string firstName = studentInfo[0];// взимам си инфо за студента  - Имена, години и град
                string lastName = studentInfo[1];
                int age = int.Parse(studentInfo[2]);
                string town = studentInfo[3];

                Student studentObject = new Student(firstName, lastName, age, town);// създавам нов обект - СТУДЕНТ

                bool exists = false;// булева дали вече го има в списъка
                foreach (var currStudent in students)// за всеки обект в листа
                {
                    if (currStudent.FirstName == studentObject.FirstName && currStudent.LastName == studentObject.LastName)// проверявам обект по обект дали има съвпадение на имената
                    {
                        exists = true;// ако има съвпадение
                        currStudent.Age = studentObject.Age;// презаписвам нова  възраст
                        currStudent.Town = studentObject.Town;// презаписвам нов град
                    }
                   // !!!! С повишено внимание, когато се опитвам да променям листа и други данни във FOREACH!!!
                }
                if (!exists)// ако не съществува такъв обект
                {
                    students.Add(studentObject);// Добавям в празния лист от обекти
                }

            }
            string townToSort = Console.ReadLine();// ще ги сортирам по град

            for (int i = 0; i < students.Count; i++)// въртя листа от обектите
            {
                Student currStudent = students[i];// текущия обект

                if (currStudent.Town == townToSort)// ако града съвпада
                {
                    Console.WriteLine($"{currStudent.FirstName} {currStudent.LastName} is {currStudent.Age} years old.");
                }
            }
            // Student studentObject = students.FirstOrDefault(x => x.FirstName == firstName);


        }



        public class Student// клас студент
        {
            public Student(string firstName, string lastName, int age, string town) // конструктор за въвеждане на нов обект - Студент
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
                Town = town;

            }
            public string FirstName { get; set; }// ще има първо име
            public string LastName { get; set; }// фамилия
            public int Age { get; set; }// възраст
            public string Town { get; set; }// град
        }
    }
}
