using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.StudentSystem.Models
{
    public class Homework
    {
        public int HomeworkId { get; set; }
        [MaxLength(250)]
        public string Context { get; set; }
        public ContextType ContextType { get; set; }
   
        public DateTime SubmitionTime { get; set; }
        public int StudentId { get; set; }     
        public int CourseId { get; set; }

        // Not sure if it is needed
        public Course Course { get; set; }
        public Students Student { get; set; }
    }
}
