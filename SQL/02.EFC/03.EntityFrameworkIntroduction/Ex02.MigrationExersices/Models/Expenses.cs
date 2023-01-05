using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02.MigrationExersices.Models
{
    public class Expenses
    {
        [Key]
        public int Id { get; set; }
        public int Amount { get; set; }
        public string comment { get; set; }
        public Expenses expens { get; set; }
    }
}
