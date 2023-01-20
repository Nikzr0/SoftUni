using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02.FootballBetting.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public string LogoUrl { get; set; }
        public string Initials { get; set; }
        public decimal Budget { get; set; }

        //Relation?
        public int PrimaryKitColorId { get; set; }
        //Relation?
        public int SecondaryKitColorId { get; set; }
        public int TownId { get; set; }
        public Town Town { get; set; }
    }
}