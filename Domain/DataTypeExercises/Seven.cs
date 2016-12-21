using System;

namespace Domain.DataTypeExercises
{
    public class Seven
    {
        public void Calculations()
        {
            var meters = float.Parse(Console.ReadLine());
            var hours = float.Parse(Console.ReadLine());
            var minutes = float.Parse(Console.ReadLine());
            var seconds = float.Parse(Console.ReadLine());
            var totalSeconds = (hours * 3600) + (minutes * 60) + seconds;

            var mps = meters / totalSeconds;
            var kph = (meters / 1000) / (totalSeconds / 3600);
            var mph = kph / 1.609;

            Console.WriteLine($"Meters per second: {mps}");
            Console.WriteLine($"km\\h: {kph}");
            Console.WriteLine($"m\\ph: {mph}");

        }

    }
}