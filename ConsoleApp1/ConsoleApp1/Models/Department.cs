using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    internal class Department : IEnumerable<Department>
    {
        private static int _id;
        private List<Employee> _employee;
        private Employee[] _emps;
        public int Id { get; set; }
        public string Name { get; set; }
        //public Employee this[int index]
        //{
        //    get
        //    {
        //        if (index < _employee.Count)
        //        {
        //            return _employee[index];
        //        }
        //        throw new IndexOutOfRangeException("Partladi");
        //    }
        //    set
        //    {
        //        if (index < _employee.Count)
        //        {


        //            _employee[index] = value;
        //            return;
        //        }
        //        throw new IndexOutOfRangeException("Partladi");
        //    }
        //}
        public Department(string name)
        {
            _id++;
            Id = _id;
            Name = name;
            _employee = new List<Employee>();
            _emps = new Employee[0];
        }


        public void AddEmployee(Employee employee)
        {
            _employee.Add(employee);
        }

        public IEnumerator<Department> GetEnumerator()
        {
             _employee.GetEnumerator();
            yield break;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
