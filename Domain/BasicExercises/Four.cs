using System;
using System.Collections.Generic;

namespace csharpPractice.BasicExercises
{
    public class Four 
    {
        private List<int> calcs = new List<int> 
        { 
            -1 + 4 *6,
            (35 + 5) % 7,
            14 + -4 * 6 / 11,
            2 + 15 / 6 * 1 -7 % 2
        };
        public void Calculations()
        {
            foreach (var i in calcs)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}