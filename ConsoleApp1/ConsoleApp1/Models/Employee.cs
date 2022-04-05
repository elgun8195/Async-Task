using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    internal class Employee
    {
        private static int _id;
        public int Id { get; set; }
        public double Salary { get; set; }
        public string Name { get; set; }

        public Employee(string name,double salary)
        {
            _id++;
            Id = _id;
            Name = name;
            Salary = salary;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id} - Name: {Name} - Salary: {Salary}");
        }
    }
}
