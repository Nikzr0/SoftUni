using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02.FootballBetting.Models
{
    public   class Player
    {
        public int PlayerId { get; set; }
        public string Name  { get; set; }
        public int SquadNumber { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public int PositionId { get; set; }
        public int ScoredGoal { get; set; }
        public int Assistance { get; set; }
        public int MinutesPlayed { get; set; }
    }
}
