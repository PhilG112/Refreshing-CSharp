using System;

namespace Domain.DataTypeExercises
{
    public class Two
    {
        public void Pyramid()
        {
            var num = int.Parse(Console.ReadLine());
            var width = int.Parse(Console.ReadLine());

            var height = width;
            for (int row = 0; row < height; row++)
            {
                for (int column = 0; column < width; column++)
                {
                    Console.Write(num);
                }
                Console.WriteLine();
                width--;
            }
            


        }
    }
}