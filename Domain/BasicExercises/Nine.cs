using System;
using System.Collections.Generic;
using System.Linq;

namespace csharpPractice.BasicExercises
{
    public class Nine
    {
        public void Average()
        {
            // Init array
            var list = new List<int>(3);
            while (list.Count < 4)
            {
                var input = int.Parse(Console.ReadLine());
                list.Add(input);
            }
            Console.WriteLine(list.Average(x => x));
        }
    }
}
