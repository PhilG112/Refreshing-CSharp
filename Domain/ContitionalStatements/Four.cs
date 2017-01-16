using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ContitionalStatements
{
    public class Four
    {
        public void IsLeapYear()
        {
            var year = int.Parse(Console.ReadLine());
            Console.WriteLine(DateTime.IsLeapYear(year) ? $"{year} is a leap year." : $"{year} is not a leap year.");
        }
    }
}
