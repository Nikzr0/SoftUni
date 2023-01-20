using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02.FootballBetting.Models
{
    public class User
    {
        public int UserId { get; set; }
        public int Username { get; set; }
        public int Password { get; set; }
        public int Email { get; set; }
        public int Name { get; set; }
        public int Balance { get; set; }
    }
}