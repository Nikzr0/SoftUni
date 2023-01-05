using Ex01.ImportSoftUniDatabase.Models;
using System;
using System.Linq;

namespace Ex01.ImportSoftUniDatabase
{
    internal class Program
    {
        static void Main()
        {
            var db = new SoftUniContext();

            // FK must be added
            //var newEmployee = new Employee()
            //{
            //    FirstName = "Test",
            //    LastName = "Test",
            //    JobTitle = "Test",
            //    HireDate= DateTime.Now,
            //    Salary = 780000
            //};


            //db.Employees.Add(newEmployee);
            //db.SaveChanges();


            var EmployeesWithBigSalary = db.Employees
                .Where(x => x.Salary > 90000)
                .OrderBy(x => x.Salary)
                .Select(x => new { x.FirstName, x.LastName, x.JobTitle, x.Salary })                
                .ToList();
           
            foreach (var employee in EmployeesWithBigSalary)
            {        
                Console.WriteLine($"{employee.FirstName}, {employee.LastName}, {employee.JobTitle}, {employee.Salary}");
            }
        }
    } 
}