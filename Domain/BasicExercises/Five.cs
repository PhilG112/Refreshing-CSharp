using System;

namespace csharpPractice.BasicExercises 
{
    public class Five 
    {
        public void Swap() 
        {
            Console.WriteLine("Input numbers");
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var temp = num1;
            Console.WriteLine(num1 = num2);
            Console.WriteLine(num2 = temp);


        }
    }
}