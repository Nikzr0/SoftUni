namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class ArenaTests
    {
        [Test]
        public void ConstructorCheck()
        {
            Arena arena = new Arena();
            Assert.IsNotNull(arena);
        }
        [Test]
        public void CountTest()
        {
            Arena arena = new Arena();
            var carInstance = (Arena)Activator.CreateInstance(typeof(Arena), true);

            Assert.That(carInstance.Warriors.Count == carInstance.Count);
        }
        [Test]
        public void EnrollCheck()
        {
            Arena arena = new Arena();
            Warrior nikola = new Warrior("Nikola", 40, 50);
            arena.Enroll(nikola);
            Assert.Throws<InvalidOperationException>(()=>arena.Enroll(nikola));
        }
        [Test]
        public void BothWarriorsMustBeEnrolled()
        {
            Arena arena = new Arena();
            Assert.Throws<InvalidOperationException>(()=> arena.Fight("Nikola",""));
        }
    }
}
