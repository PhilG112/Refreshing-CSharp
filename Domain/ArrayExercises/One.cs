using System;

namespace Domain.ArrayExercises
{
    public class One
    {
        public One()
        {
            var arr = new int[] { 1,2,3,4,5,6,7,8,9,10 };

            foreach (var n in arr)
                Console.WriteLine(n);
        }
    }
}