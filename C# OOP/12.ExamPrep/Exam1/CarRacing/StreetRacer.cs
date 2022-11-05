namespace CarRacing
{
    using CarRacing.Models.Cars.Contracts;

    public class StreetRacer : Racer
    {
        public StreetRacer(string userName, string racingBehavior, int drivingExperience, ICar ctorCar) : base(userName, racingBehavior, drivingExperience, ctorCar)
        {
            DrivingExperience = 30;
            RacingBehavior = "strict";
        }

        public override void Race()
        {
            base.Race();
            DrivingExperience += 10;
        }
    }
}
