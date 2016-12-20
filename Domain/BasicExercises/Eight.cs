using System;
using System.Collections.Generic;

namespace csharpPractice.BasicExercises
{
    public class Eight
    {
        public void Multiply()
        {
            // Initalize array of multiples
            int[] nums = {0,1,2,3,4,5,6,7,8,9,10,11,12};
            // Setup user input
            var input = int.Parse(Console.ReadLine());
            // Interate through array multiplying by input
            foreach (var n in nums)
                Console.WriteLine(input * n);
        }
    }
}
