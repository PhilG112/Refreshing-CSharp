using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ProgrammingProblems
{
    public class Allergens
    {
        public Allergens()
        {
            var allergens = new Dictionary<string, int>
            {
                {"eggs", 1},
                {"peanuts", 2},
                {"shellfish", 4},
                {"strawberries", 8},
                {"tomatoes", 16},
                {"chocholate", 32},
                {"pollen", 64},
                {"cates", 128}
            };


        }
    }
}
