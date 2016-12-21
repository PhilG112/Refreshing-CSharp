using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DataTypeExercises
{
    public class Eight
    {
        public void Radius()
        {
            var radius = float.Parse(Console.ReadLine());
            var surfaceArea = 4 * Math.PI * Math.Pow(radius, 2);
            var volume = (4/3) * Math.PI * Math.Pow(radius, 3);

            Console.WriteLine($"Surface area: {surfaceArea} \nVolume: {volume}");

        }
    }
}
