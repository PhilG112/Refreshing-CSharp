using System;

namespace Domain.DataTypeExercises
{
    public class Five
    {
        public void Perimeter()
        {
            var radius = double.Parse(Console.ReadLine());
            var pi = Math.PI;
            var result = 2 * pi * radius;
            Console.WriteLine(result);
        }
    }
}
