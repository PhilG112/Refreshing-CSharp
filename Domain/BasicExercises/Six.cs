using System;

namespace csharpPractice.BasicExercises
{
    public class Six
    {
        public void Multiply()
        {
            // 2 x 3 x 6
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(num1 * num2 * num3);
        }
    }
}