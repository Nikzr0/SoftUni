using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        [Test]
        public void WeaponShouldLoseDurabilityAfterEachAttack()
        {
            var weapon = new Axe(5,13);
            var dummy = new Dummy(10,67);
            weapon.Attack(dummy);
            Assert.AreEqual(12, weapon.DurabilityPoints);
        }

        [Test]
        public void WeaponIsAlreadyBroaken()
        {
            var weapon = new Axe(5, 0);
            var dummy = new Dummy(10, 67);

            Assert.Throws<InvalidOperationException>
                (() => weapon.Attack(dummy));
        }
    }
}