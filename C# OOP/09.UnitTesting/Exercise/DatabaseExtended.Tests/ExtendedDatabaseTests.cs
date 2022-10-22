namespace DatabaseExtended.Tests
{
    using ExtendedDatabase;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class ExtendedDatabaseTests
    {
        [Test]
        public void CreatePerson()
        {
            Person person = new Person(12, "userName1");
            Database db = new Database();
            db.Add(person);
            Assert.True(db.Count == 1);
        }
        [Test]
        public void OverLoadWithPeople()
        {
            Database db = new Database();
            for (int i = 0; i < 16; i++)
            {
                Person person = new Person(12 + i, "userName1" + i);
                db.Add(person);

            }

            Person person2 = new Person(10, "yusfd");

            Assert.Throws<InvalidOperationException>(() =>
                 db.Add(person2));
        }
        [Test]
        public void AddWithTheSameName()
        {
            List<Person> people = new List<Person>();
            var db = new Database();
            for (int i = 0; i < 15; i++)
            {
                Person person = new Person(12 + i, "userName1" + i);
                db.Add(person);
                people.Add(person);
            }

            Person person2 = new Person(10, "yusfd");
            bool isTrue = true;
            foreach (var item in people)
            {
                if (item.UserName == person2.UserName)
                {
                    isTrue = false;
                }
            }
            Assert.True(isTrue);
        }
        [Test]
        public void AddWithTheSameId()
        {
            List<Person> people = new List<Person>();
            var db = new Database();
            for (int i = 0; i < 15; i++)
            {
                Person person = new Person(12 + i, "userName1" + i);
                db.Add(person);
                people.Add(person);
            }

            Person person2 = new Person(10, "yusfd");
            bool isTrue = true;
            foreach (var item in people)
            {
                if (item.Id == person2.Id)
                {
                    isTrue = false;
                }
            }
            Assert.True(isTrue);
        }
        [Test]
        public void RemoveFromEmpty()
        {
            var db = new Database();
            Assert.Throws<InvalidOperationException>(()=> db.Remove());
        }

    }
}