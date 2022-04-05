using homeworkFileDirectorySerialization.Models;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.IO;

namespace homeworkFileDirectorySerialization
{
    class Program
    {

        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"C:\Users\User\Desktop\homeworkFileDirectorySerialization\homeworkFileDirectorySerialization\homeworkFileDirectorySerialization\Files");
            if (!File.Exists(@"C:\Users\User\Desktop\homeworkFileDirectorySerialization\homeworkFileDirectorySerialization\homeworkFileDirectorySerialization\Files\Database.json"))
            {
                File.Create(@"C:\Users\User\Desktop\homeworkFileDirectorySerialization\homeworkFileDirectorySerialization\homeworkFileDirectorySerialization\Files\Database.json");
            }

            Console.WriteLine("====Menu===");
            Console.WriteLine("1. Add employee");
            Console.WriteLine("2. Get employee by id");
            Console.WriteLine("3. Remove employee");
            Console.WriteLine("0. Quit");
            object secim = Console.ReadLine();
            switch (secim)
            {
                case "1":
                    Employee employee1 = new Employee();
                    Console.WriteLine("Adinizi girin");
                    string name = Console.ReadLine();
                    employee1.NAME = name;
                    Console.WriteLine("Salary girin");
                    double salary = Convert.ToInt32(Console.ReadLine());
                    employee1.Salary = salary;
                    Department department = new Department();
                    department.AddEmployee(employee1);
                    string jsonStr = JsonConvert.SerializeObject(department);
                    using (StreamWriter depart = new StreamWriter(@"C:\Users\User\Desktop\homeworkFileDirectorySerialization\homeworkFileDirectorySerialization\homeworkFileDirectorySerialization\Files\Database.json"))
                    {
                        depart.WriteLine(jsonStr);
                    }
                    break;
                case "2":
                    Employee employee2 = new Employee();
                    int id = Convert.ToInt32(Console.ReadLine());
                    employee2.Id = id;
                    using (StreamReader depart= new StreamReader(@"C:\Users\User\Desktop\homeworkFileDirectorySerialization\homeworkFileDirectorySerialization\homeworkFileDirectorySerialization\Files\Database.json"))
                    {
                    }
                    break;
            }

        }
    }
}
