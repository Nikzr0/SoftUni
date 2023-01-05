using Ex07.EmployeesAndProjects.Models;
using System;
using System.Linq;

namespace Ex07.EmployeesAndProjects
{
    internal class Program
    {
        static void Main()
        {
            var db = new SoftUniContext();
            var emps = db.Employees
                .Where(e => e.EmployeesProjects
                .Any(p=>p.Project.StartDate.Year > 2000 && p.Project.StartDate.Year < 2004))
                .ToList();

            var others = db.Employees
               .Where(e => e.EmployeesProjects
               .Any(p => p.Project.StartDate.Year < 2000 || p.Project.StartDate.Year > 2004))
               .ToList();

            int x = 0;
            foreach (var emp in emps)
            {
                if (x == 10)
                {
                    break;
                }           
                Console.WriteLine($"{emp.FirstName} {emp.LastName} {emp.ManagerId}");
                x++;
            }

            foreach (var emp in emps)
            {
                Console.WriteLine($"-- {emp.EmployeesProjects.}");
            }
        }
    }
}