using Ex01.StudentSystem.Models;
using System;

namespace Ex01.StudentSystem
{
    public class Program
    {
        static void Main()
        {
            var db = new StudentSystemContext();
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
        }
    }
}