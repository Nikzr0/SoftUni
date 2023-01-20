using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.StudentSystem.Models
{
    public class StudentSystemContext : DbContext
    {
        public StudentSystemContext()
        {

        }
        public StudentSystemContext(DbContextOptions options)
            : base(options)
        {
        }

        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<Course> Cources { get; set; }
        public virtual DbSet<Homework> Homework { get; set; }
        public virtual DbSet<Resource> Resources { get; set; }
        public virtual DbSet<StudentCousceMapping> StudentCousceMapping { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Integrated Security=true;Database=StudentSystem");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCousceMapping>
            (
                x => { x.HasKey(x => new { x.CourseId, x.StudentId }); }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
