using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TeisterMask.Data.Models;

namespace TeisterMask.DataProcessor.ExportDto
{
    public class ExportTaskDto
    {
        public string Name { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime DueDate { get; set; }
        public ExecutionType ExecutionDate { get; set; }
        public LableType LableType { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public IEnumerable<EmployeeTask> EmployeesTasks { get; set; }
    }
}
