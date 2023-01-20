using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.StudentSystem.Models
{
    public class Course
    {
        public Course()
        {
            this.StudentsEnrolled = new HashSet<StudentCousceMapping>();
            this.Resources = new HashSet<Resource>();
            this.HomeworkSubmission = new HashSet<Homework>();
        }
        public int CourseId { get; set; }

        [MaxLength(80)]
        public string  Name { get; set; }

        [Required(AllowEmptyStrings = true)]
        public string Description { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }

        public ICollection<StudentCousceMapping> StudentsEnrolled { get; set; }
        public ICollection<Resource> Resources { get; set; }
        public ICollection<Homework> HomeworkSubmission { get; set; }
    }
}
