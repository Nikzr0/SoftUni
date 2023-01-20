using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.StudentSystem.Models
{
    public class Students
    {
        public Students()
        {
            this.CourseEnrollments = new HashSet<StudentCousceMapping>();
            this.HomeworkSubmission = new HashSet<Homework>();
        }

        [Key]
        public int StudentId { get; set; }

        //[Required(AllowEmptyStrings = true)]
        public DateTime? BirthDay { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [StringLength(10)]
        public string PhoneNumber { get; set; }  
        public bool RegistratedOn { get; set; }

        public ICollection<StudentCousceMapping> CourseEnrollments { get; set; }
        public ICollection<Homework> HomeworkSubmission { get; set; }
    }
}
