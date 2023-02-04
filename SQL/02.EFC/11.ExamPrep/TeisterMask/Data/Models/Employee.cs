using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TeisterMask.Data.Models
{
    public class Employee
    {        
        public int Id { get; set; }

        [MaxLength(40), MinLength(4)]
        [RegularExpression("^[a-zA-Z0-9]+$")]
        public string Username { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$")]
        public string Phone { get; set; }
        public IEnumerable<EmployeeTask> EmployeesTasks { get; set; }
    }
}
