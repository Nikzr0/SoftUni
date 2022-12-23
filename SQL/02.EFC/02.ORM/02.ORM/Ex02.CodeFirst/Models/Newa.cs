using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02.CodeFirst.Models
{
    internal class Newa
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(200)]
        public int Length { get; set; }
    }
}
