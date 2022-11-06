namespace CarRacing.Repositories.Contracts
{
    using CarRacing.Models.Cars.Contracts;
    using CarRacing.Models.Racers.Contracts;
    using CarRacing.Utilities.Messages;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CarRepository : IRepository<ICar>
    {
        private List<ICar> cars;

        public CarRepository()
        {
            this.cars = new List<ICar>();
        }
        public IReadOnlyCollection<ICar> Models => this.cars;

        public void Add(ICar model)
        {
            if (model == null)
            {
                throw new ArgumentException("Cannot add null in Car Repository");
            }

            this.cars.Add(model);
        }
        public ICar FindBy(string property)
        {
            return this.cars.FirstOrDefault(x => x.VIN == property);
        }
        public bool Remove(ICar model)
        {
            return this.cars.Remove(model);
        }
    }
}
