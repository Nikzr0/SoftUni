using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TeisterMask.Data.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(40), MinLength(2)]
        public string Name { get; set; }
        [Required]
        public DateTime OpenDate { get; set; }
        public DateTime? DueDate { get; set; }
        public IEnumerable<Task> Tasks { get; set; }
    }
}
