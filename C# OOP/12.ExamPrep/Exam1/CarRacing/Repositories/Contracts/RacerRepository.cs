using CarRacing.Utilities.Messages;
using System.Collections.Generic;
using System;
using CarRacing.Models.Racers.Contracts;
using System.Linq;

namespace CarRacing.Repositories.Contracts
{
    public class RacerRepository : IRepository<IRacer>
    {
        private List<IRacer> racers;

        public RacerRepository()
        {
            this.racers = new List<IRacer>();
        }

        public IReadOnlyCollection<IRacer> Models => this.racers;

        public void Add(IRacer model)
        {
            if (model == null)
            {
                throw new ArgumentException("Cannot add null in Racer Repository");
            }

            this.racers.Add(model);
        }

        public IRacer FindBy(string property)
        {
            return this.racers.FirstOrDefault(x => x.Username == property);
        }

        public bool Remove(IRacer model)
        {
            return this.racers.Remove(model);
        }
    }
}
