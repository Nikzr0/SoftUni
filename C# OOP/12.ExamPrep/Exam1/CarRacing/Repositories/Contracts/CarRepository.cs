namespace CarRacing.Repositories.Contracts
{
    using CarRacing.Models.Cars.Contracts;
    using CarRacing.Models.Racers.Contracts;
    using CarRacing.Utilities.Messages;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class CarRepository<T> : IRepository<T>
    {
        private List<T> models;
        public IReadOnlyCollection<T> Models
        {
            get { return models; }
            set { models = new List<T>(value); }
        }
        public void Add(T model)
        {
            if (model == null)
            {
                throw new ArgumentException(ExceptionMessages.InvalidAddCarRepository);
            }

            //var oldModels = new List<T>(Models);
            //oldModels.Add(model);
            //Models.Add(oldModels);

            models.Add(model);
        }

        public T FindBy(string vin)
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(T model)
        {
            bool result = false;

            if (models.Contains(model))
            {
                models.Remove(model);
                result = true;
            }

            return result;
        }
    }
}
