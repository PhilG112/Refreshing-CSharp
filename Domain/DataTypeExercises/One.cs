using System;
using System.Collections.Generic;

namespace Domain.DataTypeExercises
{
    public class One
    {
        public void Reverse()
        {
            List<char> array = new List<char>(3);
            while (array.Count < 3)
            {
                var input = char.Parse(Console.ReadLine());
                array.Add(input);
            }
            array.Reverse();
            foreach (var c in array)
            {
                Console.WriteLine(c);
            }
        }
    }
}
