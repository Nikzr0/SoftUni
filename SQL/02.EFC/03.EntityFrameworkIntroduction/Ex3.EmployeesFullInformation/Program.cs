using Ex3.EmployeesFullInformation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex3.EmployeesFullInformation
{
    public class Program
    {
        static void Main()
        {
            var db = new SoftUniContext();
            
            Console.WriteLine(GetEmployeesFullInformation(db));
        }
        public static string GetEmployeesFullInformation(SoftUniContext db)
        {
            var emplpoyees = db.Employees.OrderBy(x => x.EmployeeId).ToList();

            var sb = new StringBuilder();

            foreach (var employee in emplpoyees)
            {
                sb.AppendLine($"{employee.FirstName} {employee.MiddleName} {employee.LastName} {employee.JobTitle} {employee.Salary:f2}");
            }

            return sb.ToString().TrimEnd();
        }

    }
}