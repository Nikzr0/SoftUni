using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02.FootballBetting.Models
{
    public class FootballBettingContext : DbContext
    {
        public FootballBettingContext()
        {

        }
        public FootballBettingContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Bet> Bet { get; set; }
        public DbSet<Bet> Color { get; set; }
        public DbSet<Bet> Country { get; set; }
        public DbSet<Bet> Game { get; set; }
        public DbSet<Bet> Player { get; set; }
        public DbSet<Bet> Team { get; set; }
        public DbSet<Bet> Town { get; set; }
        public DbSet<Bet> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Integrated Security=true;Database=FootballBetting");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // I don't know if it is needed
           // base.OnModelCreating(modelBuilder);
        }
    }
}