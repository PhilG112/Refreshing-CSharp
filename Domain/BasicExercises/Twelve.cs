using System;

namespace csharpPractice.BasicExercises
{
    public class Twelve
    {
        public void Duplicate()
        {
            // Init Input
            var input = int.Parse(Console.ReadLine());

            Console.WriteLine($"{input} {input} {input} {input}");
            Console.WriteLine($"{input}{input}{input}{input}");
            Console.WriteLine($"{input} {input} {input} {input}");
            Console.WriteLine($"{input}{input}{input}{input}");
        }
    }
}
