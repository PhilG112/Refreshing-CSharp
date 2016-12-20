using System;

namespace csharpPractice.BasicExercises
{
    public class Thirteen
    {
        public void Rectangle()
        {
            // init input
            var input = int.Parse(Console.ReadLine());
            Console.WriteLine($"{input}\t{input}\t{input}");
            Console.WriteLine($"{input} \t \t{input}");
            Console.WriteLine($"{input} \t \t{input}");
            Console.WriteLine($"{input} \t \t{input}");
            Console.WriteLine($"{input}\t{input}\t{input}");        
        }
    }
}