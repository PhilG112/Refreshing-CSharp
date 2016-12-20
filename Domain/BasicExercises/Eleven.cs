using System;

namespace csharpPractice.BasicExercises
{
    public class Eleven
    {
        // Method 1
        // public Eleven(int age)
        // {
        //     Console.WriteLine($"You look older than {age}");
        // }

        // Method 2
        public void Age()
        {
            var input = Console.ReadLine();
            Console.WriteLine($"You look older than {input}");
        }
    }
}
