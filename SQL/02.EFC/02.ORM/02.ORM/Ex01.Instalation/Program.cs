using Ex01.Instalation.Models;
using System;
using System.Linq;

namespace Ex01.Instalation
{
    internal class Program
    {
        static void Main()
        {
            var db = new SoftUniContext();

            //Console.WriteLine(db.Employees.Where(x=>x.Salary > 28000 && x.Salary < 30000 ).Count());

            //var employeesWithLowSalary = db.Employees.Where(x => x.Salary < 35000).ToList();

            //foreach (var employee in employeesWithLowSalary)
            //{
            //    Console.WriteLine($"The employee id is {employee.EmployeeId} and his salary is {employee.sa}");
            //}

         


            //Add into SoftUni
            //db.Employees.Add(new Employee 
            //{
            //    FirstName = "Nikola",
            //    LastName = "Pepelov",
            //    JobTitle = ".Net Programmer",
            //    DepartmentId = 1,
            //    HireDate = DateTime.Parse("1998-07-31"),
            //    Salary = 18000
            //}
            //);

            //db.SaveChanges();

            var me = db.Employees.Where(x => x.FirstName == "Nikola" && x.LastName == "Pepelov");
            
            //foreach (var employee in me)
            //{
            //    db.Employees.Remove(employee);
            //}

            //db.SaveChanges();


            // --------------------------------


            var employees = db.Employees.Where(x => x.FirstName.StartsWith("N"))
             .Select(x => new { x.FirstName, x.LastName, x.Salary })
             .ToList();

            foreach (var employee in employees)
            {                 
                Console.WriteLine($"{employee.FirstName} - {employee.LastName} - {employee.Salary}");
            }

        }
    }
}
