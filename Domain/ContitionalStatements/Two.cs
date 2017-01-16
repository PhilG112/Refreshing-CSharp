using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ContitionalStatements
{
    public class Two
    {
        public void IsOddOrEven()
        {
            var input = int.Parse(Console.ReadLine());
            Console.WriteLine(input % 2 == 0 ? $"{input} is even.": $"{input} is not even.");
        }
    }
}
