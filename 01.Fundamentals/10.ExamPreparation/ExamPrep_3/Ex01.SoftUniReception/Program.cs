using System;

namespace Ex01.SoftUniReception
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int employeeCapabilityOne = int.Parse(Console.ReadLine());
            int employeeCapabilityTwo = int.Parse(Console.ReadLine());
            int employeeCapabilityThree = int.Parse(Console.ReadLine());

            int studentsCount = int.Parse(Console.ReadLine());

            int hours = 0;

            while (studentsCount > 0)
            {
                int anHourWork = employeeCapabilityOne + employeeCapabilityTwo + employeeCapabilityThree;
                studentsCount = studentsCount - anHourWork;

                if (hours % 4 == 0 && hours != 0)
                {
                    hours += 2;
                }
                else
                {
                    hours++;
                }

            }

            if (hours % 4 == 0 && hours != 0)
            {
                hours++;
            }

            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}