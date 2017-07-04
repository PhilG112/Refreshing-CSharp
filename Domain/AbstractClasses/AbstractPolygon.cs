using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.AbstractClasses
{
    public abstract class AbstractPolygon
    {
        public int NumOfSides { get; set; }
        public int SideLength { get; set; }


        public AbstractPolygon(int sides, int length)
        {
            NumOfSides = sides;
            SideLength = length;
        }

        public double GetPerimeter()
        {
            return NumOfSides * SideLength;
        }

        public abstract double GetArea();
    }
}
