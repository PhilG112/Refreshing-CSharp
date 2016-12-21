using System;

namespace Domain.DataTypeExercises
{
    public class Six
    {
        public void Range()
        {
            int x;
            for (int y = -5; y <= 5; y++)
            {
                x = (y * y) + (2 * y) + 1;
                Console.WriteLine(x);
            }

        }
    }
}