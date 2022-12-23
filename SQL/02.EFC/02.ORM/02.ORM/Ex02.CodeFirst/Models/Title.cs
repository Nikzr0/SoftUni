using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02.CodeFirst.Models
{
    internal class Title
    {
        public int Id { get; set; }
        public int NewsId { get; set; }
        public Newa New { get; set; }
    }
}
