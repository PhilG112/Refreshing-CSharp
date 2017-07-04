using System;
using System.IO;
using System.Linq;

namespace Domain.ProgrammingProblems
{
    public class FizzBuzz
    {
        public FizzBuzz(string inputFile)
        {
            var file = File.ReadAllLines("fizzbuzz.txt");
            foreach (var line in file)
            {
                var split = line.Split(' ').Select(x => int.Parse(x)).ToList();
                var div1 = split[0];
                var div2 = split[1];
                var limit = split[2];
                for (var i = 1; i <= limit; i++)
                {
                    var result = i % div1 == 0 && i % div2 == 0 ? "FB" :
                        i % div1 == 0 ? "F" :
                        i % div2 == 0 ? "B" : i.ToString();
                    Console.Write($"{result} ");
                }
                Console.WriteLine("\n");
            }

        }
    }
}
