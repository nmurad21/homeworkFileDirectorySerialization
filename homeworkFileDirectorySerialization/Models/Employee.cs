using System;
using System.Collections.Generic;
using System.Text;

namespace homeworkFileDirectorySerialization.Models
{
    class Employee
    {
        public int Id { get; set; }
        public string NAME { get; set; }
        public double Salary { get; set; }
        public string ShowInfo()
        {
            return $"ID-{Id}  Name-{NAME}  Salary-{Salary}";
        }
    }
}
