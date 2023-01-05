using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Ex04.EmployeesWithSalaryOver50000.Models
{
    [Table("Deleted_Employees")]
    public partial class DeletedEmployee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string JobTitle { get; set; }
        public int DepartmentId { get; set; }
        [Column(TypeName = "money")]
        public decimal? Salary { get; set; }
    }
}
