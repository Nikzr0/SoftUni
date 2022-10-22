namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class WarriorTests
    {
        [Test]
        public void PropCheck()
        {
            var warrior = new Warrior("Nikola", 50, 300);
            Assert.That(warrior.Name, Is.Not.Null);
            Assert.That(warrior.Damage > 0);
            Assert.That(warrior.HP > 0);
        }
        [Test]
        public void MinAttackCheck()
        {
            var warrior = new Warrior("Nikola", 50, 20);
            var sam = new Warrior("Sam", 500, 2770);
            Assert.Throws<InvalidOperationException>(()=> warrior.Attack(sam));
        }
        [Test]
        public void EnemyHpToLow()
        {
            var warrior = new Warrior("Nikola", 50, 800);
            var sam = new Warrior("Sam", 500, 20);
            Assert.Throws<InvalidOperationException>(() => warrior.Attack(sam));
        }
        [Test]
        public void EnemyToStrong()
        {
            var warrior = new Warrior("Nikola", 50, 200);
            var sam = new Warrior("Sam", 500, 950);
            Assert.Throws<InvalidOperationException>(() => warrior.Attack(sam));
        }
    }
}