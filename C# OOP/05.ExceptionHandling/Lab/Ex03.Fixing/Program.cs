using System;

namespace Ex03.Fixing
{
    public class Program
    {
        static void Main()
        {
            string[] weekDays = new string[5];
            weekDays[0] = "Monday";
            weekDays[1] = "Thesday";
            weekDays[2] = "Wednesday";
            weekDays[3] = "Thursday";
            weekDays[4] = "Friday";

            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine(weekDays[i]);
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}