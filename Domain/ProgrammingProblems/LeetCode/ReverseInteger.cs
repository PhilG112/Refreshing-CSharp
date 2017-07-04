using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ProgrammingProblems.LeetCode
{
    public static class ReverseInteger
    {
        public static int Reverse(int x)
        {
            var y = x.ToString().Reverse().Aggregate("", (current, c) => current += c);
            return int.Parse(y);
        }
    }
}
