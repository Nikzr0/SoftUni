using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TeisterMask.DataProcessor.ExportDto
{
    public class ExportEmployeeDto
    {
        public string Username { get; set; }
        public IEnumerable<TeisterMask.Data.Models.Task> Tasks { get; set; }
    }
}
