namespace CarManager.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class CarManagerTests
    {
        [Test]
        public void EmptyConstructor()
        {
            var carInstance = (Car)Activator.CreateInstance(typeof(Car), true);

            Assert.That(carInstance.FuelAmount == 0);
        }
        [Test]
        public void ConstructorCheck()
        {
            var car = new Car("VW", "Passat", 12, 60);

            Assert.That(car.Make == "VW");
            Assert.That(car.Model == "Passat");
            Assert.That(car.FuelConsumption == 12);
            Assert.That(car.FuelCapacity == 60);
        }
        [Test]
        public void PropartiesCheck()
        {
            var car = new Car("VW", "Passat", 12, 60);
            Assert.IsNotNull(car.Model);
            Assert.That(car.Model != "");
            Assert.IsNotNull(car.Make);
            Assert.That(car.Make != "");
            Assert.That(car.FuelConsumption > 0);
            Assert.That(car.FuelCapacity > 0);
        }
        [Test]
        public void EmptyRefuelCheck()
        {
            var car = new Car("VW", "Passat", 12, 60);
            Assert.Throws<ArgumentException>(() => car.Refuel(0));
        }
        [Test]
        public void RefuelCheck()
        {
            var car = new Car("VW", "Passat", 12, 60);
            car.Refuel(15);
            Assert.That(car.FuelAmount == 15);
        }
        [Test]
        public void Drive()
        {
            var car = new Car("VW", "Passat", 12, 80);
            Assert.Throws<InvalidOperationException>(()=> car.Drive(2000));
        }
    }
}