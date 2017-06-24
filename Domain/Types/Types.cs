using System;

namespace Domain.Types
{

    public class PointC
    {
        public int X, Y;
    }

    public struct PointS
    {
        public int X, Y; // 8 bytes of memory, 4 bytes each.
    }

    /// <summary>
    /// Value types comprise most built-in types, as well as custom
    /// struct and enum types.
    /// 
    /// Reference types comprise all class, array, delegate, and interface types.
    /// 
    /// The fundamental difference between value types and reference 
    /// types is how they are handled in memory.
    /// </summary>
    public class Types
    {
        // VALUE TYPES
        public void ValueTypes()
        {
            PointS p1 = new PointS();
            p1.X = 7;

            PointS p2 = p1; // Assignment causes copy

            Console.WriteLine(p1.X); // => 7
            Console.WriteLine(p2.X); // => 7

            p1.X = 0; // Change p1.X

            Console.WriteLine(p1.X); // => 9
            Console.WriteLine(p2.X); // => 7
        }

        // REFERENCE TYPES
        public void ReferenceTypes()
        {
            PointC p1 = new PointC();
            p1.X = 7;

            PointC p2 = p1; // Copies p1 reference

            Console.WriteLine(p1.X); // => 7
            Console.WriteLine(p2.X); // => 7

            p1.X = 9; // Change p1.X

            Console.WriteLine(p1.X); // => 9
            Console.WriteLine(p2.X); // => 9
        }

        // NULL
        public void WorkingWithNull()
        {
            PointC p = null;
            Console.WriteLine(p == null); // => true

            // The following oline generates a runtime error
            // (a NullReferenceException is throw):
            Console.WriteLine(p.X);

            // In contrast, a value type cannot ordinarily have a null value:
            // PointS p2 = null; // Compile-time error
            // int x = null; // Compile-time error
        }

    }
}
