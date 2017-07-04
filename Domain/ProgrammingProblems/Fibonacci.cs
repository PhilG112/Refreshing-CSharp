using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ProgrammingProblems
{
    public static class Fibonacci
    {
        public static void FibonacciSequence(long a, long b, int counter, int number)
        {
            Console.WriteLine(a);
            if (counter < number) FibonacciSequence(b, a + b, counter + 1, number); 
        }
    }
}
