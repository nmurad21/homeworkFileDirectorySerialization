using System;
using System.Collections.Generic;
using System.Text;

namespace homeworkFileDirectorySerialization.Models
{
    class Department
    {
        private static int _id;
        public int Id { get; }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
        public void AddEmployee(Employee employee)
        {
            Employees = new List<Employee>();
        }
        public void GetEmployeeById(int id)
        {

        }
        public void RemoveEmployee(int id)
        {

        }
        public Department()
        {
            _id++;
            Id = _id;
        }
    }
}
