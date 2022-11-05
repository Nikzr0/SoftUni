namespace CarRacing
{
    using CarRacing.Models.Cars.Contracts;

    public class ProfessionalRacer : Racer
    {
        public ProfessionalRacer(string userName, string racingBehavior, int drivingExperience, ICar ctorCar) : base(userName, racingBehavior, drivingExperience, ctorCar)
        {
            DrivingExperience = 30;
            RacingBehavior = "aggressive";
        }

        public override void Race()
        {
            base.Race();
            DrivingExperience += 5;
        }
    }
}
