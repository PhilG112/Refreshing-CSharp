using System;

namespace csharpPractice.BasicExercises
{
    public class Fourteen
    {
        public void Output()
        {
            // init input
            var input = double.Parse(Console.ReadLine());
            Console.WriteLine(ToKelvin(input));
            Console.WriteLine(ToFahrenheit(input));
        }

        public double ToKelvin(double c)
        {
            // k = c + 273.15
            var k = 273.15;
            return c + k;
        }

        public double ToFahrenheit(double c)
        {
            // f = c * 9 / 5 + 32
            return c * 1.8 + 32;
        }
    }
}