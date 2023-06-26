using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Company_Roster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfEmployees = int.Parse(Console.ReadLine());
            List<Department> departments = new List<Department>();
            for (int i = 0; i < countOfEmployees; i++)
            {
                string [] empInfo = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string name = empInfo[0];
                decimal salary = decimal.Parse(empInfo[1]);
                string department = empInfo[2];

                if (!departments.Any(d=> d.DeptName == department))
                {
                    departments.Add(new Department(department));
                }

                //departments.AddNewEmployee(name, salary);
                departments.Find(d=>d.DeptName==department).AddNewEmployee(name, salary);
              
            }
            Department highestPaydDept = departments.OrderByDescending(d=>d.DeptSalary/d.list.Count()).FirstOrDefault();
            Console.WriteLine($"Highest Average Salary: {highestPaydDept.DeptName}");
            foreach(Employee employee in highestPaydDept.list.OrderByDescending(e => e.Salary))
            {
                Console.WriteLine(employee.ToString());
            }
        }
    }
    public class Employee
    {
        public Employee(string name, decimal salary )
        {
            Name = name;
            Salary = salary;
           
        }

        public string Name { get; set; }
        public decimal Salary { get; set; }
        

        public override string ToString()
        {
            return $"{Name} {Salary:f2}";
        }

       
    }
    public class Department
    {
        public Department(string department)
        {
            DeptName = department;
        }
        public List<Employee> list = new List<Employee>();// field
        public string DeptName { get; set; }    
        public decimal DeptSalary { get; set;}

        public void AddNewEmployee(string emp, decimal salary)// add new employee with it`s salary to the Department
        {
            this.DeptSalary += salary;
            this.list.Add(new Employee(emp, salary));
        }
    }
}
