using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ProgrammingProblems
{
    public class WheatCheesboardProblem
    {
        public double Grains()
        {
            return Enumerable.Range(0, 64).Sum(i => Math.Pow(2, i));
        }
    }
}
