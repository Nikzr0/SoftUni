using Ex02.MigrationExersices.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Ex02.MigrationExersices
{
    internal class Program
    {
        static void Main()
        {
            var db = new BudgetContext();
            db.Database.Migrate();
            
        }
    }
}
