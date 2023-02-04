using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace TeisterMask.DataProcessor.ImportDto
{
    public class ImportProjectDto
    {
        public int Name { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime? DueDate { get; set; }
        public IEnumerable<Task> Tasks { get; set; }
        public int LabelType { get; set; }
    }
}
