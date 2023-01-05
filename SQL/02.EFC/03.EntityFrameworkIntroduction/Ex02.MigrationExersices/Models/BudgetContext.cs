using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Ex02.MigrationExersices.Models
{
    internal class BudgetContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Integrated Security=true;Database=Budget");
        }
        public DbSet<Person> Person { get; set; }
        public DbSet<Expenses> Expens { get; set; }
    }
}
