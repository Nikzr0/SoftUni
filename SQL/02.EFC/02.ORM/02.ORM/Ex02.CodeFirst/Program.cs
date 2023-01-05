using Ex02.CodeFirst.Models;
using System;

namespace Ex02.CodeFirst
{
    public class Program
    {
        // Terrible naming
        static void Main()
        {
            var context = new Context();
            context.Database.EnsureCreated();
            context.SaveChanges();

            var db = new Context();

            db.Title.Add(new Title
            {
                NewsId = 1,
                New = new Newa
                { Length = 1, }

            }
            );

            db.SaveChanges();
        }
    }
}