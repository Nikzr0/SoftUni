using Ex04.EmployeesWithSalaryOver50000.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Ex04.EmployeesWithSalaryOver50000
{
    public class Program
    {
        static void Main()
        {
            var db = new SoftUniContext();

            // Ex4
            //var employees = GetEmployeesWithSalaryOver50000(db);
            //Console.WriteLine(employees);

            //Ex5
            //var employess = GetEmployeesFromResearchAndDevelopment(db);
            //Console.WriteLine(employees);

            //Ex6
            //var employees = AddNewAddressToEmployee(db);
            //Console.WriteLine(employees);

            //Ex7
            var employees = GetEmployeesInPeriod(db);
            Console.WriteLine(employees);

        }
        public static string GetEmployeesWithSalaryOver50000(SoftUniContext db)
        {
            var richEmployees = db.Employees
                .Where(x => x.Salary > 50000).ToList()
                .OrderBy(x => x.FirstName);

            var sb = new StringBuilder();

            foreach (var employee in richEmployees)
            {
                sb.AppendLine($"{employee.FirstName} {employee.Salary:f2}");
            }

            return sb.ToString().TrimEnd();
        }
        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext db)
        {
            var employees = db.Employees
                .Where(x => x.Department.Name == "Research and Development")
                .OrderBy(x => x.Salary)
                .ThenBy(x => x.FirstName);

            var sb = new StringBuilder();

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName} {employee.LastName} {employee.Department.Name} {employee.Salary:f2}");
            }

            return sb.ToString().TrimEnd();
        }
        public static string AddNewAddressToEmployee(SoftUniContext db)
        {
            var address = new Address
            {
                AddressText = "Vitoshka 15",
                TownId = 4
            };
            db.Addresses.Add(address);
            db.SaveChanges();

            var nakov = db.Employees
                .FirstOrDefault(x => x.FirstName == "Nakov");

            nakov.AddressId = address.AddressId;

            var allEmployees = db.Employees
                .Select(x => new
                {
                    x.Address.AddressText,
                    x.Address.AddressId
                })
                .OrderByDescending(x => x.AddressId)
                .ToList();

            var sb = new StringBuilder();

            int counter = 1;
            foreach (var employee in allEmployees)
            {
                if (counter <= 10)
                {
                    sb.AppendLine($"{employee.AddressText}");
                    counter++;
                }
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetEmployeesInPeriod(SoftUniContext db)
        {
            var employees = db.Employees
                .Include(x=>x.EmployeesProjects)
                .ThenInclude(x => x.Project)
                .Take(10)
                .ToList();

            var sb = new StringBuilder();

            foreach (var employee in employees)
            {
                int x = 0;
                foreach (var item in employee.EmployeesProjects)
                {
                    if (x == 0)
                    {
                        if (item.Project.StartDate.Year >= 2001 && item.Project.StartDate.Year <= 2003)
                        {
                            // maybe a problem with null
                            sb.AppendLine($"{employee.FirstName} {employee.LastName}" +
                            $" {employee.Manager.FirstName} {employee.Manager.LastName}");
                        }
                        else
                        {
                            break;
                        }
                    }
                    x++;

                    sb.AppendLine($"{item.Project.Name} - {item.Project.StartDate} - not finished");
                }           
            }

            return sb.ToString().TrimEnd();
        }
    }
}