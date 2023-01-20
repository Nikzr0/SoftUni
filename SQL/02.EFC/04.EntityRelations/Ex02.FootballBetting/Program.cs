using Ex02.FootballBetting.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Ex02.FootballBetting
{
    public class Program
    {
        static void Main()
        {
            var db = new FootballBettingContext();

            db.Database.Migrate();
        }
    }
}