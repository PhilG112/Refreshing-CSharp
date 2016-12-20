using System;
using System.Collections.Generic;

namespace csharpPractice.BasicExercises
{
    public class Seven
    {
        public void Calculcations()
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Multiply {0}", num1 * num2);
            Console.WriteLine("Minus {0}", num1 - num2);
            Console.WriteLine("Add {0}", num1 + num2);
            Console.WriteLine("Divide {0}", num1 / num2);
            Console.WriteLine("Remainder {0}", num1 % num2);
        }
    }
}

