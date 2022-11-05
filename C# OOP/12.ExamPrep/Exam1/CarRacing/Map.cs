namespace CarRacing
{
    using CarRacing.Models.Maps.Contracts;
    using CarRacing.Models.Racers.Contracts;
    using CarRacing.Utilities.Messages;

    public class Map : IMap
    {
        public string StartRace(IRacer racerOne, IRacer racerTwo)
        {
            if (racerOne.IsAvailable() && racerTwo.IsAvailable())
            {
                double racerOneStats = 0;
                double racerTwoStats = 0;

                racerOne.Race();
                racerTwo.Race();

                racerOneStats = racerOne.Car.HorsePower * racerOne.DrivingExperience;
                racerTwoStats = racerTwo.Car.HorsePower * racerTwo.DrivingExperience;

                if (racerOne.RacingBehavior == "strict")
                {
                    racerOneStats *= 1.2;
                }
                else
                {
                    racerOneStats *= 1.1;
                }

                if (racerTwo.RacingBehavior == "strict")
                {
                    racerTwoStats *= 1.2;
                }
                else
                {
                    racerTwoStats *= 1.1;
                }

                if (racerOneStats > racerTwoStats)
                {
                    return OutputMessages.RacerWinsRace;
                    //return $"{racerOne.Username} wins the race!";
                }
                else
                {
                    return OutputMessages.RacerWinsRace;
                    //return $"{racerTwo.Username} wins the race!";
                }
            }
            else if (racerOne.IsAvailable() && !racerTwo.IsAvailable())
            {
                return OutputMessages.OneRacerIsNotAvailable;
                //return $"{racerOne.Username} wins the race! {racerTwo.Username} was not available to race!";
            }
            else if (racerTwo.IsAvailable() && !racerOne.IsAvailable())
            {
                return OutputMessages.OneRacerIsNotAvailable;
                //return $"{racerTwo.Username} wins the race! {racerOne.Username} was not available to race!";
            }
            else if (!racerTwo.IsAvailable() && !racerOne.IsAvailable())
            {
                return OutputMessages.RaceCannotBeCompleted;
            }
            else
            {
                return "Race cannot be completed because both racers are not available!";
            }
        }
    }
}
