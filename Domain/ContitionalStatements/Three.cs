using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ContitionalStatements
{
    public class Three
    {
        public void IsPosOrNeg()
        {
            var input = int.Parse(Console.ReadLine());
            Console.WriteLine(input >= 0 ? $"{input} is positive." : $"{input} is negative.");
        }
    }
}
