using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace _4._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for(int i = 0; i < countOfStudents; i++)
            {
                string[] studentArgs = Console.ReadLine().Split(' ');
                string firstName = studentArgs[0];
                string lastName = studentArgs[1];
                double grade = double.Parse(studentArgs[2]);
                Student currStudent = new Student(firstName, lastName,grade);
                students.Add(currStudent);
            }
            List<Student> orderedStudents = students.OrderByDescending(s => s.Grade).ToList();
            foreach(Student student in orderedStudents)
            {
                Console.WriteLine(student.ToString());
            }
        }
        
    }
    public class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
}
