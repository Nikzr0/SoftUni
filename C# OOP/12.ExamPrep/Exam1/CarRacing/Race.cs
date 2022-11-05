namespace CarRacing
{
    using CarRacing.Models.Cars.Contracts;
    using CarRacing.Models.Racers.Contracts;
    using CarRacing.Utilities.Messages;
    using System;

    public class Racer : IRacer
    {
        private string username;
        private string racingbehaviour;
        private int drivingexperience;
        private ICar car;
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                if (value == null || value == "")
                {
                    throw new ArgumentException(ExceptionMessages.InvalidRacerName);
                }
                username = value;
            }
        }
        public string RacingBehavior
        {
            get
            {
                return racingbehaviour;
            }
            set
            {
                if (value == null || value == "")
                {
                    throw new ArgumentException(ExceptionMessages.InvalidRacerBehavior);
                }
                racingbehaviour = value;
            }
        }
        public int DrivingExperience
        {
            get
            {
                return drivingexperience;
            }
            set
            {
                if (value < 0|| value > 100)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidRacerDrivingExperience);
                }
                drivingexperience = value;
            }
        }
        public ICar Car
        {
            get
            {
                return car;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidRacerCar);
                }
                car = value;
            }
        }
        public Racer(string userName, string racingBehavior, int drivingExperience, ICar ctorCar)
        {
            userName = Username;
            racingBehavior = RacingBehavior;
            drivingExperience = DrivingExperience;
            ctorCar = Car;
        }
        public bool IsAvailable()
        {
            return car.FuelAvailable >= car.FuelAvailable - car.FuelConsumptionPerRace;
        }

        public virtual void Race()
        {
            car.Drive();
        }
    }
}
