using System;

namespace TravellingToSunWithSoundSpeed
{
    class Program
    {
        static void Main(string[] args)
        {
            const double speedOfSound = 1225.044;
            const long distToSun = 149600000;
            double timeNeeded = Math.Round(distToSun / speedOfSound);
            double timeNeededInYears = Math.Floor(timeNeeded / 8760);
            double leftoverDays = Math.Floor(((timeNeeded / 8760) - timeNeededInYears) * 365);

            Console.WriteLine($"The time needed to travel from the Earth to the Sun is {timeNeeded} hours, or " +
                $"{timeNeededInYears} years and {leftoverDays} days.");
        }
    }
}
