using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TeisterMask.Data.Models
{
    public class Task
    {
        public int Id { get; set; }

        [MaxLength(40), MinLength(2)]
        public string Name { get; set; }

        [Required]
        public DateTime OpenDate { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        [Required]
        public ExecutionType ExecutionDate { get; set; }

        [Required]
        public LableType LableType { get; set; } 

        public int ProjectId { get; set; }

        public Project Project { get; set; }
        public IEnumerable<EmployeeTask> EmployeesTasks { get; set; }
    }
}
