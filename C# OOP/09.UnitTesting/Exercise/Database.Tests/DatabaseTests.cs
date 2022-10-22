namespace Database.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class DatabaseTests
    {

        [Test]
        public void TheSizeOfTheArrayShouldBe16()
        {
            var db = new Database();
            for (int i = 0; i < 16; i++)
            {
                db.Add(i);
            }
            Assert.That(db.Count == 16);
        }

        [Test]
        public void ShouldNotAdd17thElement()
        {
            var db = new Database();
            for (int i = 0; i < 16; i++)
            {
                db.Add(i);
            }
            Assert.Throws<InvalidOperationException>(() => db.Add(17));
        }

        [Test]
        public void ShouldNotRemoveFromAnEmptyStack()
        {
            var db = new Database();
            for (int i = 0; i < db.Count; i++)
            {
                db.Remove();
            }
            Assert.Throws<InvalidOperationException>(() => db.Remove());
        }

        [Test]
        public void ConstructorShouldTakeIntegersOnlyAndShoulfStoreThemIntoTheArray()
        {
            var db = new Database(new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 9, 10, 11, 12, 13, 14, 15, 16 });
            Assert.That(db.Count == 16);
        }

        [Test]
        public void FetchMustReturnArray()
        {
            var db = new Database(new int[] { 2, 4, 6 });
            Assert.AreEqual(new int[] { 2, 4, 6 }, db.Fetch());
        }
    }
}
